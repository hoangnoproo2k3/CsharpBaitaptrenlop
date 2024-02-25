namespace bai2._1
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
            this.bill = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.num = new System.Windows.Forms.TextBox();
            this.sum = new System.Windows.Forms.TextBox();
            this.vat = new System.Windows.Forms.TextBox();
            this.listNXB = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhà xuất bản";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Thuế VAT";
            // 
            // bill
            // 
            this.bill.Location = new System.Drawing.Point(394, 260);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(75, 23);
            this.bill.TabIndex = 5;
            this.bill.Text = "Tính tiền";
            this.bill.UseVisualStyleBackColor = true;
            this.bill.Click += new System.EventHandler(this.bill_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(156, 49);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(229, 22);
            this.name.TabIndex = 6;
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(156, 117);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(84, 22);
            this.num.TabIndex = 8;
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(591, 49);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(84, 22);
            this.sum.TabIndex = 9;
            // 
            // vat
            // 
            this.vat.Location = new System.Drawing.Point(591, 111);
            this.vat.Name = "vat";
            this.vat.Size = new System.Drawing.Size(84, 22);
            this.vat.TabIndex = 10;
            // 
            // listNXB
            // 
            this.listNXB.FormattingEnabled = true;
            this.listNXB.ItemHeight = 16;
            this.listNXB.Location = new System.Drawing.Point(156, 260);
            this.listNXB.Name = "listNXB";
            this.listNXB.Size = new System.Drawing.Size(120, 84);
            this.listNXB.TabIndex = 11;
            this.listNXB.SelectedIndexChanged += new System.EventHandler(this.listNXB_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Đơn giá";
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(165, 179);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(84, 22);
            this.price.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listNXB);
            this.Controls.Add(this.vat);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.num);
            this.Controls.Add(this.name);
            this.Controls.Add(this.bill);
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
        private System.Windows.Forms.Button bill;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.TextBox sum;
        private System.Windows.Forms.TextBox vat;
        private System.Windows.Forms.ListBox listNXB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox price;
    }
}

