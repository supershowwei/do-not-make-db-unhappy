using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;

namespace ElasticsearchLab
{
    internal class News
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string Author { get; set; }

        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string Press { get; set; }

        public DateTime Date { get; set; }
    }
}