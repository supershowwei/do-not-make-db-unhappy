using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using Dapper;
using Elasticsearch.Net;
using Nest;
using Newtonsoft.Json;

namespace ElasticsearchLab
{
    public partial class Form1 : Form
    {
        private readonly string connectionString =
            @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TestDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private readonly TcpClient logShipper = new TcpClient();

        private ElasticClient esClient;

        public Form1()
        {
            this.InitializeComponent();
        }

        private ElasticClient ESClient
        {
            get
            {
                if (this.esClient == null)
                {
                    var nodes = new[] { new Uri(@"http://192.168.8.108:9200") };

                    // , new Uri(@"http://192.168.8.107:9200"),
                    // new Uri(@"http://192.168.8.105:9200")
                    var connectionSettings = new ConnectionSettings(new StaticConnectionPool(nodes));

                    this.esClient = new ElasticClient(connectionSettings);
                }

                return this.esClient;
            }
        }

        private TcpClient LogShipper
        {
            get
            {
                if (!this.logShipper.Connected)
                {
                    this.logShipper.NoDelay = true;
                    this.logShipper.Connect("192.168.8.102", 1304);
                }

                return this.logShipper;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var data =
                @"2016-09-19 23:35:54 GET /js/jquery.royalslider.min.js versionParams=2016-0607-001 202.140.72.47 17146 1296 11139"
                + Environment.NewLine;

            var networkStream = this.LogShipper.GetStream();

            var dataBytes = Encoding.UTF8.GetBytes(data);
            networkStream.Write(dataBytes, 0, dataBytes.Length);
            networkStream.Flush();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            var updatedNews = new News
                                  {
                                      Id = Guid.Parse("2fd41d47-1637-477a-9fb7-0f3964667bec"),
                                      Title = "八軍團協助災後復原告一段落　明起個案處理",
                                      Content = "（過時了）",
                                      Author = "溫蘭魁",
                                      Press = "中廣新聞網",
                                      Date = new DateTime(2016, 9, 18)
                                  };

            this.ESClient.Update(
                new DocumentPath<News>(updatedNews.Id).Index("demoindex").Type("news"),
                u => u.Doc(updatedNews));
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            var deletedNewsId = Guid.Parse("2fd41d47-1637-477a-9fb7-0f3964667bec");

            this.ESClient.Delete(new DocumentPath<News>(deletedNewsId).Index("demoindex").Type("news"));
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            var response = this.ESClient.DeleteByQuery<object>(
                Indices.Index("demoindex"),
                Types.Type("news"),
                d => d.Query(q => q.QueryString(qs => qs.Fields(f => f.Field("press")).Query("中國時報"))));
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            var dir = @"D:\Downloads\iislogs";
            var files = Directory.GetFiles(dir, "*.log");

            foreach (var file in files)
            {
                foreach (var content in File.ReadAllLines(file))
                {
                    if (string.IsNullOrEmpty(content) || content.StartsWith("#"))
                    {
                        continue;
                    }

                    var networkStream = this.LogShipper.GetStream();
                    var dataBytes = Encoding.UTF8.GetBytes(content + Environment.NewLine);
                    networkStream.Write(dataBytes, 0, dataBytes.Length);
                    networkStream.Flush();
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            var newsList = this.GetNewsList<dynamic>();

            foreach (var news in newsList)
            {
                // Index name 必須全部小寫
                this.ESClient.Index((object)news, idx => idx.Index("demoindex").Type("news").Id((Guid)news.Id));
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            var newsList = this.GetNewsList<News>();

            foreach (var news in newsList)
            {
                // Index name 必須全部小寫
                this.ESClient.Index(news, idx => idx.Index("demoindex").Id(news.Id));
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            var newsList = this.GetNewsList<News>();

            var bulkRequest = new BulkRequest("demoindex", "news")
                                  {
                                      Operations =
                                          newsList.Select(
                                              x => new BulkIndexOperation<News>(x) { Id = x.Id } as IBulkOperation).ToList()
                                  };

            this.ESClient.Bulk(bulkRequest);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.ESClient.CreateIndex("demoindex", idx => idx.Mappings(ms => ms.Map<News>(m => m.AutoMap())));
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            var searchResult = this.ESClient.Search<dynamic>(s => s.Query(q => q.QueryString(qs => qs.Query("八軍團"))));

            this.textBox1.Text =
                JsonConvert.SerializeObject(
                    new { Hits = searchResult.Hits.Count(), Results = searchResult.Hits.Select(x => x.Source) },
                    Formatting.Indented);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            var searchResult =
                this.ESClient.Search<News>(
                    s => s.Query(q => q.QueryString(qs => qs.Fields(f => f.Field(p => p.Title)).Query("八軍團"))));

            this.textBox1.Text =
                JsonConvert.SerializeObject(
                    new { Hits = searchResult.Hits.Count(), Results = searchResult.Hits.Select(x => x.Source) },
                    Formatting.Indented);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            var updatedNews = new News { Id = Guid.Parse("2fd41d47-1637-477a-9fb7-0f3964667bec"), Content = "（過時了）" };

            this.ESClient.Update<News, object>(
                new DocumentPath<News>(updatedNews.Id).Index("demoindex").Type("news"),
                u => u.Doc(new { updatedNews.Content }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.logShipper.Connected)
            {
                this.logShipper.Close();
            }
        }

        private IEnumerable<T> GetNewsList<T>()
        {
            IEnumerable<T> newsList;
            using (var sql = new SqlConnection(this.connectionString))
            {
                newsList = sql.Query<T>(@"SELECT * FROM News WITH (NOLOCK)");
            }

            return newsList;
        }
    }
}