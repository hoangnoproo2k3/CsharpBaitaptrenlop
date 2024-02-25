namespace bai2._2
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
            this.xa = new System.Windows.Forms.TextBox();
            this.ya = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yaa = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.yb = new System.Windows.Forms.TextBox();
            this.xb = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // xa
            // 
            this.xa.Location = new System.Drawing.Point(265, 121);
            this.xa.Name = "xa";
            this.xa.Size = new System.Drawing.Size(100, 22);
            this.xa.TabIndex = 0;
            // 
            // ya
            // 
            this.ya.Location = new System.Drawing.Point(448, 124);
            this.ya.Name = "ya";
            this.ya.Size = new System.Drawing.Size(100, 22);
            this.ya.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(237, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "xA";
            // 
            // yaa
            // 
            this.yaa.AutoSize = true;
            this.yaa.Location = new System.Drawing.Point(406, 127);
            this.yaa.Name = "yaa";
            this.yaa.Size = new System.Drawing.Size(23, 16);
            this.yaa.TabIndex = 3;
            this.yaa.Text = "yA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "yB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(245, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "xB";
            // 
            // yb
            // 
            this.yb.Location = new System.Drawing.Point(456, 216);
            this.yb.Name = "yb";
            this.yb.Size = new System.Drawing.Size(100, 22);
            this.yb.TabIndex = 5;
            // 
            // xb
            // 
            this.xb.Location = new System.Drawing.Point(273, 213);
            this.xb.Name = "xb";
            this.xb.Size = new System.Drawing.Size(100, 22);
            this.xb.TabIndex = 4;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(298, 310);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(110, 23);
            this.calculate.TabIndex = 8;
            this.calculate.Text = "Tính độ dài";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.yb);
            this.Controls.Add(this.xb);
            this.Controls.Add(this.yaa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ya);
            this.Controls.Add(this.xa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xa;
        private System.Windows.Forms.TextBox ya;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label yaa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox yb;
        private System.Windows.Forms.TextBox xb;
        private System.Windows.Forms.Button calculate;
    }
}

