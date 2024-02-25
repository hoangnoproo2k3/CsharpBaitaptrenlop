namespace bai3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.service = new System.Windows.Forms.ListBox();
            this.selected = new System.Windows.Forms.ListBox();
            this.choose = new System.Windows.Forms.Button();
            this.continu = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.richResult = new System.Windows.Forms.RichTextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.day = new System.Windows.Forms.TextBox();
            this.month = new System.Windows.Forms.TextBox();
            this.year = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên bệnh nhân";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tháng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Năm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chọn dịch vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Danh sách đã chọn";
            // 
            // service
            // 
            this.service.FormattingEnabled = true;
            this.service.ItemHeight = 16;
            this.service.Location = new System.Drawing.Point(82, 147);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(216, 84);
            this.service.TabIndex = 6;
            this.service.SelectedIndexChanged += new System.EventHandler(this.service_SelectedIndexChanged);
            // 
            // selected
            // 
            this.selected.FormattingEnabled = true;
            this.selected.ItemHeight = 16;
            this.selected.Location = new System.Drawing.Point(440, 147);
            this.selected.Name = "selected";
            this.selected.Size = new System.Drawing.Size(181, 84);
            this.selected.TabIndex = 7;
            // 
            // choose
            // 
            this.choose.Location = new System.Drawing.Point(127, 256);
            this.choose.Name = "choose";
            this.choose.Size = new System.Drawing.Size(75, 23);
            this.choose.TabIndex = 8;
            this.choose.Text = "Chọn";
            this.choose.UseVisualStyleBackColor = true;
            this.choose.Click += new System.EventHandler(this.choose_Click);
            // 
            // continu
            // 
            this.continu.Location = new System.Drawing.Point(286, 256);
            this.continu.Name = "continu";
            this.continu.Size = new System.Drawing.Size(75, 23);
            this.continu.TabIndex = 9;
            this.continu.Text = "Tiếp tục";
            this.continu.UseVisualStyleBackColor = true;
            this.continu.Click += new System.EventHandler(this.continu_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(462, 256);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 10;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Kết quả";
            // 
            // richResult
            // 
            this.richResult.Location = new System.Drawing.Point(127, 314);
            this.richResult.Name = "richResult";
            this.richResult.Size = new System.Drawing.Size(432, 96);
            this.richResult.TabIndex = 12;
            this.richResult.Text = "";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(255, 24);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(360, 22);
            this.name.TabIndex = 13;
            // 
            // day
            // 
            this.day.Location = new System.Drawing.Point(116, 70);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(100, 22);
            this.day.TabIndex = 14;
            // 
            // month
            // 
            this.month.Location = new System.Drawing.Point(313, 70);
            this.month.Name = "month";
            this.month.Size = new System.Drawing.Size(100, 22);
            this.month.TabIndex = 15;
            // 
            // year
            // 
            this.year.Location = new System.Drawing.Point(515, 70);
            this.year.Name = "year";
            this.year.Size = new System.Drawing.Size(100, 22);
            this.year.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.year);
            this.Controls.Add(this.month);
            this.Controls.Add(this.day);
            this.Controls.Add(this.name);
            this.Controls.Add(this.richResult);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.continu);
            this.Controls.Add(this.choose);
            this.Controls.Add(this.selected);
            this.Controls.Add(this.service);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox service;
        private System.Windows.Forms.ListBox selected;
        private System.Windows.Forms.Button choose;
        private System.Windows.Forms.Button continu;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richResult;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.TextBox month;
        private System.Windows.Forms.TextBox year;
    }
}

