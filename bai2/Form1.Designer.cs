namespace bai2
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
            this.hoten = new System.Windows.Forms.Label();
            this.toan = new System.Windows.Forms.Label();
            this.ly = new System.Windows.Forms.Label();
            this.hoa = new System.Windows.Forms.Label();
            this.numpoint = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.math = new System.Windows.Forms.TextBox();
            this.physics = new System.Windows.Forms.TextBox();
            this.chemistry = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.TextBox();
            this.perform = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.richresult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // hoten
            // 
            this.hoten.AutoSize = true;
            this.hoten.Location = new System.Drawing.Point(46, 40);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(64, 16);
            this.hoten.TabIndex = 0;
            this.hoten.Text = "Họ và tên";
            // 
            // toan
            // 
            this.toan.AutoSize = true;
            this.toan.Location = new System.Drawing.Point(46, 87);
            this.toan.Name = "toan";
            this.toan.Size = new System.Drawing.Size(73, 16);
            this.toan.TabIndex = 1;
            this.toan.Text = "Điểm Toán";
            // 
            // ly
            // 
            this.ly.AutoSize = true;
            this.ly.Location = new System.Drawing.Point(46, 135);
            this.ly.Name = "ly";
            this.ly.Size = new System.Drawing.Size(55, 16);
            this.ly.TabIndex = 2;
            this.ly.Text = "Điểm Lý";
            // 
            // hoa
            // 
            this.hoa.AutoSize = true;
            this.hoa.Location = new System.Drawing.Point(46, 186);
            this.hoa.Name = "hoa";
            this.hoa.Size = new System.Drawing.Size(67, 16);
            this.hoa.TabIndex = 3;
            this.hoa.Text = "Điểm Hóa";
            // 
            // numpoint
            // 
            this.numpoint.AutoSize = true;
            this.numpoint.Location = new System.Drawing.Point(558, 170);
            this.numpoint.Name = "numpoint";
            this.numpoint.Size = new System.Drawing.Size(72, 16);
            this.numpoint.TabIndex = 4;
            this.numpoint.Text = "Tổng điểm";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(46, 286);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(52, 16);
            this.result.TabIndex = 5;
            this.result.Text = "Kết quả";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(164, 40);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(237, 22);
            this.name.TabIndex = 6;
            // 
            // math
            // 
            this.math.Location = new System.Drawing.Point(164, 84);
            this.math.Name = "math";
            this.math.Size = new System.Drawing.Size(100, 22);
            this.math.TabIndex = 7;
            // 
            // physics
            // 
            this.physics.Location = new System.Drawing.Point(164, 135);
            this.physics.Name = "physics";
            this.physics.Size = new System.Drawing.Size(100, 22);
            this.physics.TabIndex = 8;
            // 
            // chemistry
            // 
            this.chemistry.Location = new System.Drawing.Point(164, 186);
            this.chemistry.Name = "chemistry";
            this.chemistry.Size = new System.Drawing.Size(100, 22);
            this.chemistry.TabIndex = 9;
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(561, 212);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(119, 22);
            this.num.TabIndex = 10;
            // 
            // perform
            // 
            this.perform.Location = new System.Drawing.Point(561, 56);
            this.perform.Name = "perform";
            this.perform.Size = new System.Drawing.Size(119, 23);
            this.perform.TabIndex = 12;
            this.perform.Text = "Tính điểm";
            this.perform.UseVisualStyleBackColor = true;
            this.perform.Click += new System.EventHandler(this.perform_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(561, 111);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(119, 23);
            this.exit.TabIndex = 13;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // richresult
            // 
            this.richresult.Location = new System.Drawing.Point(164, 286);
            this.richresult.Name = "richresult";
            this.richresult.Size = new System.Drawing.Size(271, 96);
            this.richresult.TabIndex = 14;
            this.richresult.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richresult);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.perform);
            this.Controls.Add(this.num);
            this.Controls.Add(this.chemistry);
            this.Controls.Add(this.physics);
            this.Controls.Add(this.math);
            this.Controls.Add(this.name);
            this.Controls.Add(this.result);
            this.Controls.Add(this.numpoint);
            this.Controls.Add(this.hoa);
            this.Controls.Add(this.ly);
            this.Controls.Add(this.toan);
            this.Controls.Add(this.hoten);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hoten;
        private System.Windows.Forms.Label toan;
        private System.Windows.Forms.Label ly;
        private System.Windows.Forms.Label hoa;
        private System.Windows.Forms.Label numpoint;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox math;
        private System.Windows.Forms.TextBox physics;
        private System.Windows.Forms.TextBox chemistry;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Button perform;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.RichTextBox richresult;
    }
}

