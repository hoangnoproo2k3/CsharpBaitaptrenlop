using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            // Lấy tọa độ của điểm A
            double xA, yA;
            if (!double.TryParse(xa.Text, out xA) || !double.TryParse(ya.Text, out yA))
            {
                MessageBox.Show("Vui lòng nhập tọa độ của điểm A.");
                return;
            }

            // Lấy tọa độ của điểm B
            double xB, yB;
            if (!double.TryParse(xb.Text, out xB) || !double.TryParse(yb.Text, out yB))
            {
                MessageBox.Show("Vui lòng nhập tọa độ của điểm B.");
                return;
            }

            // Tính độ dài đoạn thẳng AB
            double doDaiDoanThang = Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2));

            // Hiển thị kết quả
            MessageBox.Show($"Độ dài đoạn thẳng AB là: {doDaiDoanThang}");
        }
    }
}
