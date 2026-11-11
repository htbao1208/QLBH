using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace QLBH.GUI
{
    public partial class frmMain : Form
    {
        public frmMain(string taiKhoan)
        {
            InitializeComponent();
            lblNguoiDung.Text = "Xin chào: " + taiKhoan;

            btnSanPham.Click += btnSanPham_Click;
        }

        private Form? formDangMo;
        private void MoFormCon(Form formCon)
        {
            if (formDangMo != null)
            {
                formDangMo.Close();
                formDangMo.Dispose();
            }
            formDangMo = formCon;

            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(formCon);

            formCon.Show();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            MoFormCon(new frmSanPham());
        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            //Tạm ẩn vì chưa có form frmLoaiSanPham
            /*MoFormCon(new frmLoaiSanPham());*/
        }
        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            //Tạm ẩn vì chưa có form frmKhachHang
            /*MoFormCon(new frmKhachHang());*/
        }
        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            //Tạm ẩn vì chưa có form frmHoaDon
            /*MoFormCon(new frmHoaDon());*/
        }

        private void btnHoaDon_Click_1(object sender, EventArgs e)
        {

        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất không?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ketQua == DialogResult.No)
            {
                return;
            }
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
