namespace Baitaptrenlop
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
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.perform = new System.Windows.Forms.Button();
            this.continu = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số C";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(168, 41);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 22);
            this.a.TabIndex = 3;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(168, 89);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 22);
            this.b.TabIndex = 4;
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(168, 144);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 22);
            this.c.TabIndex = 5;
            // 
            // perform
            // 
            this.perform.Location = new System.Drawing.Point(428, 57);
            this.perform.Name = "perform";
            this.perform.Size = new System.Drawing.Size(121, 23);
            this.perform.TabIndex = 6;
            this.perform.Text = "Thực hiện";
            this.perform.UseVisualStyleBackColor = true;
            this.perform.Click += new System.EventHandler(this.perform_Click);
            // 
            // continu
            // 
            this.continu.Location = new System.Drawing.Point(428, 114);
            this.continu.Name = "continu";
            this.continu.Size = new System.Drawing.Size(121, 23);
            this.continu.TabIndex = 7;
            this.continu.Text = "Tiếp tục";
            this.continu.UseVisualStyleBackColor = true;
            this.continu.Click += new System.EventHandler(this.continu_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(428, 169);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(121, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Thoát";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kêt quả";
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(168, 270);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(250, 22);
            this.result.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.continu);
            this.Controls.Add(this.perform);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
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
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox c;
        private System.Windows.Forms.Button perform;
        private System.Windows.Forms.Button continu;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox result;
    }
}

