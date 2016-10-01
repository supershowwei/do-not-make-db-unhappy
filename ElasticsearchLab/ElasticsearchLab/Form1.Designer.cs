namespace ElasticsearchLab
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.Button8 = new System.Windows.Forms.Button();
            this.Button9 = new System.Windows.Forms.Button();
            this.Button10 = new System.Windows.Forms.Button();
            this.Button11 = new System.Windows.Forms.Button();
            this.Button12 = new System.Windows.Forms.Button();
            this.Button13 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(12, 12);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(150, 37);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Transfer IISLog";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(12, 55);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(150, 51);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "Transfer IISLogs\r\nfrom Files";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(12, 160);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(150, 51);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "Index One by One\r\n（dynamic）";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(168, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(537, 612);
            this.textBox1.TabIndex = 3;
            // 
            // Button4
            // 
            this.Button4.Location = new System.Drawing.Point(12, 217);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(150, 51);
            this.Button4.TabIndex = 4;
            this.Button4.Text = "Index One by One\r\n（strongly typed）";
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.Location = new System.Drawing.Point(12, 274);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(150, 35);
            this.Button5.TabIndex = 5;
            this.Button5.Text = "Bulk Index";
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.Location = new System.Drawing.Point(12, 112);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(150, 42);
            this.Button6.TabIndex = 6;
            this.Button6.Text = "Create Index\r\nwith Mappings";
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button7
            // 
            this.Button7.Location = new System.Drawing.Point(12, 315);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(150, 28);
            this.Button7.TabIndex = 7;
            this.Button7.Text = "Search";
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // Button8
            // 
            this.Button8.Location = new System.Drawing.Point(12, 349);
            this.Button8.Name = "Button8";
            this.Button8.Size = new System.Drawing.Size(150, 46);
            this.Button8.TabIndex = 8;
            this.Button8.Text = "Search\r\n（specified fields）";
            this.Button8.UseVisualStyleBackColor = true;
            this.Button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // Button9
            // 
            this.Button9.Location = new System.Drawing.Point(12, 437);
            this.Button9.Name = "Button9";
            this.Button9.Size = new System.Drawing.Size(150, 30);
            this.Button9.TabIndex = 9;
            this.Button9.Text = "Partial Update";
            this.Button9.UseVisualStyleBackColor = true;
            this.Button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // Button10
            // 
            this.Button10.Location = new System.Drawing.Point(12, 401);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(150, 30);
            this.Button10.TabIndex = 10;
            this.Button10.Text = "Update";
            this.Button10.UseVisualStyleBackColor = true;
            this.Button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // Button11
            // 
            this.Button11.Location = new System.Drawing.Point(12, 473);
            this.Button11.Name = "Button11";
            this.Button11.Size = new System.Drawing.Size(150, 30);
            this.Button11.TabIndex = 11;
            this.Button11.Text = "Delete";
            this.Button11.UseVisualStyleBackColor = true;
            this.Button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // Button12
            // 
            this.Button12.Location = new System.Drawing.Point(12, 509);
            this.Button12.Name = "Button12";
            this.Button12.Size = new System.Drawing.Size(150, 30);
            this.Button12.TabIndex = 12;
            this.Button12.Text = "Delete by Query";
            this.Button12.UseVisualStyleBackColor = true;
            this.Button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // Button13
            // 
            this.Button13.Location = new System.Drawing.Point(12, 545);
            this.Button13.Name = "Button13";
            this.Button13.Size = new System.Drawing.Size(150, 30);
            this.Button13.TabIndex = 13;
            this.Button13.Text = "Continuous Search";
            this.Button13.UseVisualStyleBackColor = true;
            this.Button13.Click += new System.EventHandler(this.Button13_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 636);
            this.Controls.Add(this.Button13);
            this.Controls.Add(this.Button12);
            this.Controls.Add(this.Button11);
            this.Controls.Add(this.Button10);
            this.Controls.Add(this.Button9);
            this.Controls.Add(this.Button8);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Button4;
        private System.Windows.Forms.Button Button5;
        private System.Windows.Forms.Button Button6;
        private System.Windows.Forms.Button Button7;
        private System.Windows.Forms.Button Button8;
        private System.Windows.Forms.Button Button9;
        private System.Windows.Forms.Button Button10;
        private System.Windows.Forms.Button Button11;
        private System.Windows.Forms.Button Button12;
        private System.Windows.Forms.Button Button13;
    }
}

