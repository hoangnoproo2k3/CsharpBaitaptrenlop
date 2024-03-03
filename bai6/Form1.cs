using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace bai6
{
    public partial class Form1 : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["bai6"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
            LoadEmployeeData();
            LoadDepartmentsIntoComboBox();
            txtMaNV.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        private void LoadEmployeeData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT NV.PK_sMaNV, NV.sHoten, NV.dNgaysinh, NV.sGioitinh, NV.sDiachi, NV.fLuong, P.sTenP AS TenPhongBan " +
                                   "FROM NHANVIEN NV " +
                                   "JOIN PHONG P ON NV.FK_sMaP = P.PK_sMaP"; // Join between NHANVIEN and PHONG tables

                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadDepartmentsIntoComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT sTenP FROM PHONG";
                    SqlCommand command = new SqlCommand(query, connection);

                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBoxDepartment.Items.Add(reader["sTenP"].ToString());
                    }
                    // Thêm giá trị mặc định vào ComboBox
                    comboBoxDepartment.Items.Insert(0, "Chọn phòng ban"); // Thay "Chọn phòng ban" bằng giá trị mặc định mong muốn

                    // Chọn giá trị mặc định
                    comboBoxDepartment.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Lấy thông tin của nhân viên từ dòng được chọn
                string maNV = selectedRow.Cells["PK_sMaNV"].Value.ToString();
                string hoTen = selectedRow.Cells["sHoten"].Value.ToString();
                string ngaySinh =selectedRow.Cells["dNgaysinh"].Value.ToString();
                string gioiTinh = selectedRow.Cells["sGioitinh"].Value.ToString();
                string diaChi = selectedRow.Cells["sDiachi"].Value.ToString();
                string luong = selectedRow.Cells["fLuong"].Value.ToString();
                string tenPhongBan = selectedRow.Cells["TenPhongBan"].Value.ToString(); // Nếu tên phòng ban đã được thêm vào DataGridView

                // Hiển thị thông tin lên các điều khiển
                txtMaNV.Text = maNV;
                txtHoTen.Text = hoTen;
                dateTimePickerNgaySinh.Text = ngaySinh;
                if (gioiTinh == "Nam")
                {
                    radioButtonNam.Checked = true;
                }
                else
                {
                    radioButtonNu.Checked = true;
                }
                txtDiaChi.Text = diaChi;
                txtLuong.Text = luong.ToString();
                comboBoxDepartment.SelectedItem = tenPhongBan; // ComboBox chứa danh sách phòng ban

                // Kích hoạt nút Sửa
                txtMaNV.Enabled = false;
                btnThem.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
        }
        
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển
            string maNV = txtMaNV.Text;
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh;
            if (DateTime.TryParse(dateTimePickerNgaySinh.Text, out ngaySinh))
            {
                // Chuyển đổi thành công, ngaySinh giờ là kiểu DateTime
                // Bạn có thể sử dụng giá trị ngày sinh (ngaySinh) ở đây
            }
            else
            {
                // Không thể chuyển đổi, xử lý trường hợp lỗi tại đây
                MessageBox.Show("Ngày sinh không hợp lệ!");
            }
            string gioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";
            string diaChi = txtDiaChi.Text;
            float luong = float.Parse(txtLuong.Text);
            string tenPhongBan = comboBoxDepartment.SelectedItem.ToString();

            // Cập nhật thông tin vào cơ sở dữ liệu
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE NHANVIEN SET sHoten = @HoTen, dNgaysinh = @NgaySinh, " +
                                   "sGioitinh = @GioiTinh, sDiachi = @DiaChi, fLuong = @Luong, " +
                                   "FK_sMaP = (SELECT PK_sMaP FROM PHONG WHERE sTenP = @TenPhongBan) " +
                                   "WHERE PK_sMaNV = @MaNV";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@HoTen", hoTen);
                    command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    command.Parameters.AddWithValue("@DiaChi", diaChi);
                    command.Parameters.AddWithValue("@Luong", luong);
                    command.Parameters.AddWithValue("@TenPhongBan", tenPhongBan);
                    command.Parameters.AddWithValue("@MaNV", maNV);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thông tin nhân viên đã được cập nhật thành công!");
                        ResetForm();
                        LoadEmployeeData();
                        txtMaNV.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin nhân viên không thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ResetForm()
        {
            txtMaNV.Text = "";
            txtHoTen.Text = "";
            dateTimePickerNgaySinh.Text="";
            radioButtonNam.Checked = true;
            txtDiaChi.Text = "";
            txtLuong.Text = "";
            comboBoxDepartment.SelectedIndex = 0; // Chọn giá trị mặc định của ComboBox
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các điều khiển
            string maNV = txtMaNV.Text; // Lấy mã nhân viên từ TextBox
            string hoTen = txtHoTen.Text;
            DateTime ngaySinh;
            if (!DateTime.TryParse(dateTimePickerNgaySinh.Text, out ngaySinh))
            {
                MessageBox.Show("Ngày sinh không hợp lệ!");
                return;
            }
            string gioiTinh = radioButtonNam.Checked ? "Nam" : "Nữ";
            string diaChi = txtDiaChi.Text;
            float luong;
            if (!float.TryParse(txtLuong.Text, out luong))
            {
                MessageBox.Show("Lương không hợp lệ!");
                return;
            }
            string tenPhongBan = comboBoxDepartment.SelectedItem.ToString();

            // Thêm nhân viên vào cơ sở dữ liệu
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO NHANVIEN (PK_sMaNV, sHoten, dNgaysinh, sGioitinh, sDiachi, fLuong, FK_sMaP) " +
                                   "VALUES (@MaNV, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @Luong, (SELECT PK_sMaP FROM PHONG WHERE sTenP = @TenPhongBan))";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaNV", maNV);
                    command.Parameters.AddWithValue("@HoTen", hoTen);
                    command.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                    command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    command.Parameters.AddWithValue("@DiaChi", diaChi);
                    command.Parameters.AddWithValue("@Luong", luong);
                    command.Parameters.AddWithValue("@TenPhongBan", tenPhongBan);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Thêm nhân viên thành công!");

                        // Load lại danh sách nhân viên sau khi thêm
                        LoadEmployeeData();

                        // Reset form
                        ResetForm();
                    }
                    else
                    {
                        MessageBox.Show("Thêm nhân viên không thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Lấy mã nhân viên từ dòng được chọn
                string maNV = dataGridView.SelectedRows[0].Cells["PK_sMaNV"].Value.ToString();

                // Xác nhận xóa
                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa nhân viên này không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Xóa nhân viên khỏi cơ sở dữ liệu
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string query = "DELETE FROM NHANVIEN WHERE PK_sMaNV = @MaNV";
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@MaNV", maNV);

                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Xóa nhân viên thành công!");

                                // Load lại danh sách nhân viên sau khi xóa
                                LoadEmployeeData();
                            }
                            else
                            {
                                MessageBox.Show("Xóa nhân viên không thành công!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xóa!");
            }
        }
    }

}
