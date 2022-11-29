using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace thuchanh2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //SU KIEN CLOSE VA MINIMIZE
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //SU KIEN CUA 3 BUTTON RULER
        private void pictureBox_ruler_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Nam.Visible = false;
            panel_Nu.Visible = false;
        }
        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Nam.Visible = true;
            panel_Nu.Visible = false;
        }

        private void panelNam_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Nam.Visible = true;
            panel_Nu.Visible = false;
        }

        private void label_Nu_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Nu.Visible = true;
            panel_Nam.Visible = false;
        }
        private void panel_Nu_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Nu.Visible = true;
            panel_Nam.Visible = false;
        }

        private void label_phukien_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Nam.Visible = false;
            panel_Nu.Visible = false;
        }


        private void panel_main_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Nam.Visible = false;
            panel_Nu.Visible = false;
        }
        private void pictureBox_salemain_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Nam.Visible = false;
            panel_Nu.Visible = false;
        }
        //SU KIEN NUT BAM TRONG 3 PANEL
        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
            label_1_nam.ForeColor = Color.Blue;
        }
        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label_1_nam.ForeColor = Color.Black;
        }

        private void label_2_nam_MouseMove(object sender, MouseEventArgs e)
        {
            label_2_nam.ForeColor = Color.Blue;
        }

        private void label_2_nam_MouseLeave(object sender, EventArgs e)
        {
            label_2_nam.ForeColor = Color.Black;
        }

        private void label_3_nam_MouseMove(object sender, MouseEventArgs e)
        {
            label_3_nam.ForeColor = Color.Blue;
        }

        private void label_3_nam_MouseLeave(object sender, EventArgs e)
        {
            label_3_nam.ForeColor = Color.Black;
        }

        private void label_4_nam_MouseMove(object sender, MouseEventArgs e)
        {
            label_4_nam.ForeColor = Color.Blue;
        }

        private void label_4_nam_MouseLeave(object sender, EventArgs e)
        {
            label_4_nam.ForeColor = Color.Black;
        }

        private void label_5_nam_MouseMove(object sender, MouseEventArgs e)
        {
            label_5_nam.ForeColor = Color.Blue;
        }

        private void label_5_nam_MouseLeave(object sender, EventArgs e)
        {
            label_5_nam.ForeColor = Color.Black;
        }

        private void label_1_nu_MouseMove(object sender, MouseEventArgs e)
        {
            label_1_nu.ForeColor = Color.Blue;
        }

        private void label_1_nu_MouseLeave(object sender, EventArgs e)
        {
            label_1_nu.ForeColor = Color.Black;
        }

        private void label_2_nu_MouseMove(object sender, MouseEventArgs e)
        {
            label_2_nu.ForeColor = Color.Blue;
        }

        private void label_2_nu_MouseLeave(object sender, EventArgs e)
        {
            label_2_nu.ForeColor = Color.Black;
        }

        private void label_3_nu_MouseMove(object sender, MouseEventArgs e)
        {
            label_3_nu.ForeColor = Color.Blue;
        }

        private void label_3_nu_MouseLeave(object sender, EventArgs e)
        {
            label_3_nu.ForeColor = Color.Black;
        }

        private void label_4_nu_MouseMove(object sender, MouseEventArgs e)
        {
            label_4_nu.ForeColor = Color.Blue;
        }

        private void label_4_nu_MouseLeave(object sender, EventArgs e)
        {
            label_4_nu.ForeColor = Color.Black;
        }

        private void label_5_nu_MouseMove(object sender, MouseEventArgs e)
        {
            label_5_nu.ForeColor = Color.Blue;
        }

        private void label_5_nu_MouseLeave(object sender, EventArgs e)
        {
            label_5_nu.ForeColor = Color.Black;
        }

        private void label_6_nu_MouseMove(object sender, MouseEventArgs e)
        {
            label_6_nu.ForeColor = Color.Blue;
        }

        private void label_6_nu_MouseLeave(object sender, EventArgs e)
        {
            label_6_nu.ForeColor = Color.Black;
        }

        private void label_7_nu_MouseMove(object sender, MouseEventArgs e)
        {
            label_7_nu.ForeColor = Color.Blue;
        }

        private void label_7_nu_MouseLeave(object sender, EventArgs e)
        {
            label_7_nu.ForeColor = Color.Black;
        }


        int check_nam = 0;
        int check_nu = 0;
        int check_pk = 0;
        //panel san pham Nam
        private void pictureBox_Label_Click(object sender, EventArgs e)
        {
            size_check_1 = 0;
            size_check_2 = 0;
            size_check_3 = 0;
            size_check_4 = 0;
            size_check_5 = 0;
            ten_size = "";
            button_size1.BackColor = Color.SpringGreen;
            button_size2.BackColor = Color.SpringGreen;
            button_size3.BackColor = Color.SpringGreen;
            button_size4.BackColor = Color.SpringGreen;
            button_size5.BackColor = Color.SpringGreen;

            button_size1.Visible = true;
            button_size2.Visible = true;
            button_size3.Visible = true;
            button_size4.Visible = true;
            button_size5.Visible = false;

            check_nam = 0;
            check_nu = 0;
            check_pk = 0;

            panel_sanpham_nam.Visible = false;
            panel_sanpham_nu.Visible = false;
            panel_sanphamphukien.Visible = false;
            panel_sanphamchinh.Visible = false;
            panel_review.Visible = false;
            panel_giohang.Visible = false;
            panel_lichsu.Visible = false;
        }

        private void label_Nam_Click(object sender, EventArgs e)
        {
            check_nam = 1;
            check_nu = 0;
            check_pk = 0;

            label_sanphamchinh_huongdansudung.Visible = false;
            label_sanphamchinh_huongdansudung2.Visible = false;

            button_size1.Visible = true;
            button_size2.Visible = true;
            button_size3.Visible = true;
            button_size4.Visible = true;
            button_size5.Visible = false;

            panel_sanphamchinh.Visible = false;
            panel_sanpham_nam.Visible = true;
            panel_sanpham_nu.Visible = false;
            panel_sanphamphukien.Visible = false;
            panel_giohang.Visible = false;
            panel_review.Visible = false;
            panel_lichsu.Visible = false;
            

            pictureBox_pin_1.Visible = true;
            pictureBox_pin_2.Visible = true;
            pictureBox_pin_3.Visible = true;
            pictureBox_pin_4.Visible = true;
            pictureBox_pin_5.Visible = true;
            pictureBox_pin_6.Visible = true;


            button_nam_1.Visible = true;
            button_nam_2.Visible = true;
            button_nam_3.Visible = true;
            button_nam_4.Visible = true;
            button_nam_5.Visible = true;
            button_nam_6.Visible = true;
            button_nam_7.Visible = true;
            button_nam_8.Visible = true;
            button_nam_9.Visible = true;
            button_nam_10.Visible = true;

            button_nam_1.BackgroundImage = Properties.Resources.nam_clogs_1_1;
            button_nam_1.Text = "Giày Clog Unisex Crocs Crush\r\nSpray Dye Classic";
            label_gia_1.Text = "2.000.000 VNĐ";

            button_nam_2.BackgroundImage = Properties.Resources.nam_clogs_2_1;
            button_nam_2.Text = "Giày Clog Unisex Crocs \r\nPokemon Classic";
            label_gia_2.Text = "2.000.000 VNĐ";

            label_soluong.Text = "10 SẢN PHẨM";

        }


        private void panel_sanpham_nam_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Nam.Visible = false;
            panel_Nu.Visible = false;
        }

        private void label_1_nam_Click(object sender, EventArgs e)
        {
            check_nam = 1;
            check_nu = 0;
            check_pk = 0;

            label_sanphamchinh_huongdansudung.Visible = false;
            label_sanphamchinh_huongdansudung2.Visible = false;

            button_size1.Visible = true;
            button_size2.Visible = true;
            button_size3.Visible = true;
            button_size4.Visible = true;
            button_size5.Visible = false;

            panel_sanphamchinh.Visible = false;
            panel_sanpham_nam.Visible = true;
            panel_sanpham_nu.Visible = false;
            panel_sanphamphukien.Visible = false;
            panel_giohang.Visible = false;
            panel_review.Visible = false;
            panel_lichsu.Visible = false;

            pictureBox_pin_1.Visible = true;
            pictureBox_pin_2.Visible = false;
            pictureBox_pin_3.Visible = false;
            pictureBox_pin_4.Visible = false;
            pictureBox_pin_5.Visible = false;
            pictureBox_pin_6.Visible = false;


            button_nam_3.Visible = false;
            button_nam_4.Visible = false;
            button_nam_5.Visible = false;
            button_nam_6.Visible = false;
            button_nam_7.Visible = false;
            button_nam_8.Visible = false;
            button_nam_9.Visible = false;
            button_nam_10.Visible = false;

            label_point_2.Visible = false;

            button_nam_1.Visible = true;
            button_nam_2.Visible = true;

            button_nam_1.BackgroundImage = Properties.Resources.nam_clogs_1_1;
            button_nam_1.Text = "Giày Clog Unisex Crocs Crush\r\nSpray Dye Classic";
            label_gia_1.Text = "2.000.000 VNĐ";

            button_nam_2.BackgroundImage = Properties.Resources.nam_clogs_2_1;
            button_nam_2.Text = "Giày Clog Unisex Crocs \r\nPokemon Classic";
            label_gia_2.Text = "2.000.000 VNĐ";

            label_soluong.Text = "2 SẢN PHẨM";
        }

        private void button_sanphamnam_clogs_Click(object sender, EventArgs e)
        {
            check_nam = 1;
            check_nu = 0;
            check_pk = 0;

            pictureBox_pin_1.Visible = true;
            pictureBox_pin_2.Visible = false;
            pictureBox_pin_3.Visible = false;
            pictureBox_pin_4.Visible = false;
            pictureBox_pin_5.Visible = false;
            pictureBox_pin_6.Visible = false;


            button_nam_3.Visible = false;
            button_nam_4.Visible = false;
            button_nam_5.Visible = false;
            button_nam_6.Visible = false;
            button_nam_7.Visible = false;
            button_nam_8.Visible = false;
            button_nam_9.Visible = false;
            button_nam_10.Visible = false;

            label_point_2.Visible = false;

            button_nam_1.Visible = true; 
            button_nam_2.Visible = true;

            button_nam_1.BackgroundImage = Properties.Resources.nam_clogs_1_1;
            button_nam_1.Text = "Giày Clog Unisex Crocs Crush\r\nSpray Dye Classic";
            label_gia_1.Text = "2.000.000 VNĐ";

            button_nam_2.BackgroundImage = Properties.Resources.nam_clogs_2_1;
            button_nam_2.Text = "Giày Clog Unisex Crocs \r\nPokemon Classic";
            label_gia_2.Text = "2.000.000 VNĐ";

            label_soluong.Text = "2 SẢN PHẨM";

        }

        private void label_2_nam_Click(object sender, EventArgs e)
        {
            check_nam = 1;
            check_nu = 0;
            check_pk = 0;

            label_sanphamchinh_huongdansudung.Visible = false;
            label_sanphamchinh_huongdansudung2.Visible = false;

            button_size1.Visible = true;
            button_size2.Visible = true;
            button_size3.Visible = true;
            button_size4.Visible = true;
            button_size5.Visible = false;

            panel_sanphamchinh.Visible = false;
            panel_sanpham_nam.Visible = true;
            panel_sanpham_nu.Visible = false;
            panel_sanphamphukien.Visible = false;
            panel_giohang.Visible = false;
            panel_review.Visible = false;
            panel_lichsu.Visible = false;

            pictureBox_pin_1.Visible = false;
            pictureBox_pin_2.Visible = true;
            pictureBox_pin_3.Visible = false;
            pictureBox_pin_4.Visible = false;
            pictureBox_pin_5.Visible = false;
            pictureBox_pin_6.Visible = false;

            button_nam_3.Visible = false;
            button_nam_4.Visible = false;
            button_nam_5.Visible = false;
            button_nam_6.Visible = false;
            button_nam_7.Visible = false;
            button_nam_8.Visible = false;
            button_nam_9.Visible = false;
            button_nam_10.Visible = false;

            label_point_2.Visible = false;

            button_nam_1.Visible = true;
            button_nam_2.Visible = true;

            button_nam_1.BackgroundImage = Properties.Resources.nam_xongon_1_1;
            button_nam_1.Text = "Dép Xỏ Ngón Unisex Crocs \r\nSpray Dye Classic";
            label_gia_1.Text = "1.000.000 VNĐ";

            button_nam_2.BackgroundImage = Properties.Resources.nam_xongon_2_1;
            button_nam_2.Text = "Dép Xỏ Ngón Unisex Crocs \r\nBayaband";
            label_gia_2.Text = "1.000.000 VNĐ";

            label_soluong.Text = "2 SẢN PHẨM";
        }

        private void button_sanphamnam_flipflops_Click(object sender, EventArgs e)
        {
            check_nam = 1;
            check_nu = 0;
            check_pk = 0;

            pictureBox_pin_1.Visible = false;
            pictureBox_pin_2.Visible = true;
            pictureBox_pin_3.Visible = false;
            pictureBox_pin_4.Visible = false;
            pictureBox_pin_5.Visible = false;
            pictureBox_pin_6.Visible = false;

            button_nam_3.Visible = false;
            button_nam_4.Visible = false;
            button_nam_5.Visible = false;
            button_nam_6.Visible = false;
            button_nam_7.Visible = false;
            button_nam_8.Visible = false;
            button_nam_9.Visible = false;
            button_nam_10.Visible = false;

            label_point_2.Visible = false;

            button_nam_1.Visible = true;
            button_nam_2.Visible = true;

            button_nam_1.BackgroundImage = Properties.Resources.nam_xongon_1_1;
            button_nam_1.Text = "Dép Xỏ Ngón Unisex Crocs \r\nSpray Dye Classic";
            label_gia_1.Text = "1.000.000 VNĐ";

            button_nam_2.BackgroundImage = Properties.Resources.nam_xongon_2_1;
            button_nam_2.Text = "Dép Xỏ Ngón Unisex Crocs \r\nBayaband";
            label_gia_2.Text = "1.000.000 VNĐ";

            label_soluong.Text = "2 SẢN PHẨM";
        }


        private void label_3_nam_Click(object sender, EventArgs e)
        {
            check_nam = 1;
            check_nu = 0;
            check_pk = 0;

            label_sanphamchinh_huongdansudung.Visible = false;
            label_sanphamchinh_huongdansudung2.Visible = false;

            button_size1.Visible = true;
            button_size2.Visible = true;
            button_size3.Visible = true;
            button_size4.Visible = true;
            button_size5.Visible = false;

            panel_sanphamchinh.Visible = false;
            panel_sanpham_nam.Visible = true;
            panel_sanpham_nu.Visible = false;
            panel_sanphamphukien.Visible = false;
            panel_giohang.Visible = false;
            panel_review.Visible = false;
            panel_lichsu.Visible = false;

            pictureBox_pin_1.Visible = false;
            pictureBox_pin_2.Visible = false;
            pictureBox_pin_3.Visible = true;
            pictureBox_pin_4.Visible = false;
            pictureBox_pin_5.Visible = false;
            pictureBox_pin_6.Visible = false;

            button_nam_3.Visible = false;
            button_nam_4.Visible = false;
            button_nam_5.Visible = false;
            button_nam_6.Visible = false;
            button_nam_7.Visible = false;
            button_nam_8.Visible = false;
            button_nam_9.Visible = false;
            button_nam_10.Visible = false;

            label_point_2.Visible = false;

            button_nam_1.Visible = true;
            button_nam_2.Visible = true;

            button_nam_1.BackgroundImage = Properties.Resources.nam_xangdan_1_1;
            button_nam_1.Text = "Dép Unisex Crocs \r\nSpray Dye Classic";
            label_gia_1.Text = "1.000.000 VNĐ";

            button_nam_2.BackgroundImage = Properties.Resources.nam_xangdan_2_1;
            button_nam_2.Text = "Dép Unisex Crocs \r\nAll Terrain Classic";
            label_gia_2.Text = "2.000.000 VNĐ";

            label_soluong.Text = "2 SẢN PHẨM";
        }

        private void button_sanphamnam_sandals_Click(object sender, EventArgs e)
        {
            check_nam = 1;
            check_nu = 0;
            check_pk = 0;

            pictureBox_pin_1.Visible = false;
            pictureBox_pin_2.Visible = false;
            pictureBox_pin_3.Visible = true;
            pictureBox_pin_4.Visible = false;
            pictureBox_pin_5.Visible = false;
            pictureBox_pin_6.Visible = false;

            button_nam_3.Visible = false;
            button_nam_4.Visible = false;
            button_nam_5.Visible = false;
            button_nam_6.Visible = false;
            button_nam_7.Visible = false;
            button_nam_8.Visible = false;
            button_nam_9.Visible = false;
            button_nam_10.Visible = false;

            label_point_2.Visible = false;

            button_nam_1.Visible = true;
            button_nam_2.Visible = true;

            button_nam_1.BackgroundImage = Properties.Resources.nam_xangdan_1_1;
            button_nam_1.Text = "Dép Unisex Crocs \r\nSpray Dye Classic";
            label_gia_1.Text = "1.000.000 VNĐ";

            button_nam_2.BackgroundImage = Properties.Resources.nam_xangdan_2_1;
            button_nam_2.Text = "Dép Unisex Crocs \r\nAll Terrain Classic";
            label_gia_2.Text = "2.000.000 VNĐ";

            label_soluong.Text = "2 SẢN PHẨM";
        }

        private void label_4_nam_Click(object sender, EventArgs e)
        {
            check_nam = 1;
            check_nu = 0;
            check_pk = 0;

            label_sanphamchinh_huongdansudung.Visible = false;
            label_sanphamchinh_huongdansudung2.Visible = false;

            button_size1.Visible = true;
            button_size2.Visible = true;
            button_size3.Visible = true;
            button_size4.Visible = true;
            button_size5.Visible = false;

            panel_sanphamchinh.Visible = false;
            panel_sanpham_nam.Visible = true;
            panel_sanpham_nu.Visible = false;
            panel_sanphamphukien.Visible = false;
            panel_giohang.Visible = false;
            panel_review.Visible = false;
            panel_lichsu.Visible = false;

            pictureBox_pin_1.Visible = false;
            pictureBox_pin_2.Visible = false;
            pictureBox_pin_3.Visible = false;
            pictureBox_pin_4.Visible = true;
            pictureBox_pin_5.Visible = false;
            pictureBox_pin_6.Visible = false;

            button_nam_3.Visible = false;
            button_nam_4.Visible = false;
            button_nam_5.Visible = false;
            button_nam_6.Visible = false;
            button_nam_7.Visible = false;
            button_nam_8.Visible = false;
            button_nam_9.Visible = false;
            button_nam_10.Visible = false;

            label_point_2.Visible = false;

            button_nam_1.Visible = true;
            button_nam_2.Visible = true;

            button_nam_1.BackgroundImage = Properties.Resources.nam_depquaingang_1_1;
            button_nam_1.Text = "Dép Quai Ngang Unisex Crocs \r\nCyber Nights Classic";
            label_gia_1.Text = "1.000.000 VNĐ";

            button_nam_2.BackgroundImage = Properties.Resources.nam_depquaingang_2_1;
            button_nam_2.Text = "Dép Quai Ngang Unisex Crocs \r\nClassic";
            label_gia_2.Text = "1.000.000 VNĐ";

            label_soluong.Text = "2 SẢN PHẨM";
        }

        private void button_sanphamnam_slides_Click(object sender, EventArgs e)
        {
            check_nam = 1;
            check_nu = 0;
            check_pk = 0;

            pictureBox_pin_1.Visible = false;
            pictureBox_pin_2.Visible = false;
            pictureBox_pin_3.Visible = false;
            pictureBox_pin_4.Visible = true;
            pictureBox_pin_5.Visible = false;
            pictureBox_pin_6.Visible = false;

            button_nam_3.Visible = false;
            button_nam_4.Visible = false;
            button_nam_5.Visible = false;
            button_nam_6.Visible = false;
            button_nam_7.Visible = false;
            button_nam_8.Visible = false;
            button_nam_9.Visible = false;
            button_nam_10.Visible = false;

            label_point_2.Visible = false;

            button_nam_1.Visible = true;
            button_nam_2.Visible = true;

            button_nam_1.BackgroundImage = Properties.Resources.nam_depquaingang_1_1;
            button_nam_1.Text = "Dép Quai Ngang Unisex Crocs \r\nCyber Nights Classic";
            label_gia_1.Text = "1.000.000 VNĐ";

            button_nam_2.BackgroundImage = Properties.Resources.nam_depquaingang_2_1;
            button_nam_2.Text = "Dép Quai Ngang Unisex Crocs \r\nClassic";
            label_gia_2.Text = "1.000.000 VNĐ";

            label_soluong.Text = "2 SẢN PHẨM";
        }


        private void label_5_nam_Click(object sender, EventArgs e)
        {
            check_nam = 1;
            check_nu = 0;
            check_pk = 0;

            label_sanphamchinh_huongdansudung.Visible = false;
            label_sanphamchinh_huongdansudung2.Visible = false;

            button_size1.Visible = true;
            button_size2.Visible = true;
            button_size3.Visible = true;
            button_size4.Visible = true;
            button_size5.Visible = false;

            panel_sanphamchinh.Visible = false;
            panel_sanpham_nam.Visible = true;
            panel_sanpham_nu.Visible = false;
            panel_sanphamphukien.Visible = false;
            panel_giohang.Visible = false;
            panel_review.Visible = false;
            panel_lichsu.Visible = false;

            pictureBox_pin_1.Visible = false;
            pictureBox_pin_2.Visible = false;
            pictureBox_pin_3.Visible = false;
            pictureBox_pin_4.Visible = false;
            pictureBox_pin_5.Visible = true;
            pictureBox_pin_6.Visible = false;

            button_nam_3.Visible = false;
            button_nam_4.Visible = false;
            button_nam_5.Visible = false;
            button_nam_6.Visible = false;
            button_nam_7.Visible = false;
            button_nam_8.Visible = false;
            button_nam_9.Visible = false;
            button_nam_10.Visible = false;

            label_point_2.Visible = false;

            button_nam_1.Visible = true;
            button_nam_2.Visible = true;

            button_nam_1.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_1;
            button_nam_1.Text = "Giày Thời Trang Nam Crocs \r\nPacer Literide 1";
            label_gia_1.Text = "2.000.000 VNĐ";

            button_nam_2.BackgroundImage = Properties.Resources.nam_giaythoitrang_2_1;
            button_nam_2.Text = "Giày Thời Trang Nam Crocs \r\nPacer Literide 2";
            label_gia_2.Text = "2.000.000 VNĐ";

            label_soluong.Text = "2 SẢN PHẨM";
        }

        private void button_sanphamnam_sneakers_Click(object sender, EventArgs e)
        {
            check_nam = 1;
            check_nu = 0;
            check_pk = 0;

            pictureBox_pin_1.Visible = false;
            pictureBox_pin_2.Visible = false;
            pictureBox_pin_3.Visible = false;
            pictureBox_pin_4.Visible = false;
            pictureBox_pin_5.Visible = true;
            pictureBox_pin_6.Visible = false;

            button_nam_3.Visible = false;
            button_nam_4.Visible = false;
            button_nam_5.Visible = false;
            button_nam_6.Visible = false;
            button_nam_7.Visible = false;
            button_nam_8.Visible = false;
            button_nam_9.Visible = false;
            button_nam_10.Visible = false;

            label_point_2.Visible = false;

            button_nam_1.Visible = true;
            button_nam_2.Visible = true;

            button_nam_1.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_1;
            button_nam_1.Text = "Giày Thời Trang Nam Crocs \r\nPacer Literide 1";
            label_gia_1.Text = "2.000.000 VNĐ";

            button_nam_2.BackgroundImage = Properties.Resources.nam_giaythoitrang_2_1;
            button_nam_2.Text = "Giày Thời Trang Nam Crocs \r\nPacer Literide 2";
            label_gia_2.Text = "2.000.000 VNĐ";

            label_soluong.Text = "2 SẢN PHẨM";
        }

        private void button_sanphamnam_all_Click(object sender, EventArgs e)
        {
            check_nam = 1;
            check_nu = 0;
            check_pk = 0;

            panel_sanpham_nam.Visible = true;
            pictureBox_pin_1.Visible = true;
            pictureBox_pin_2.Visible = true;
            pictureBox_pin_3.Visible = true;
            pictureBox_pin_4.Visible = true;
            pictureBox_pin_5.Visible = true;
            pictureBox_pin_6.Visible = true;

            label_point_2.Visible = true;

            button_nam_1.Visible = true;
            button_nam_2.Visible = true;
            button_nam_3.Visible = true;
            button_nam_4.Visible = true;
            button_nam_5.Visible = true;
            button_nam_6.Visible = true;
            button_nam_7.Visible = true;
            button_nam_8.Visible = true;
            button_nam_9.Visible = true;
            button_nam_10.Visible = true;

            button_nam_1.BackgroundImage = Properties.Resources.nam_clogs_1_1;
            button_nam_1.Text = "Giày Clog Unisex Crocs Crush\r\nSpray Dye Classic";
            label_gia_1.Text = "2.000.000 VNĐ";

            button_nam_2.BackgroundImage = Properties.Resources.nam_clogs_2_1;
            button_nam_2.Text = "Giày Clog Unisex Crocs \r\nPokemon Classic";
            label_gia_2.Text = "2.000.000 VNĐ";

            label_soluong.Text = "10 SẢN PHẨM";
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_1.Visible = true;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            label_gia_1.Visible = false;
        }

        private void button_nam_2_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_2.Visible = true;
        }

        private void button_nam_2_MouseLeave(object sender, EventArgs e)
        {
            label_gia_2.Visible = false;
        }

        private void button_nam_3_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_3.Visible = true;
        }

        private void button_nam_3_MouseLeave(object sender, EventArgs e)
        {
            label_gia_3.Visible = false;
        }

        private void button_nam_4_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_4.Visible = true;
        }

        private void button_nam_4_MouseLeave(object sender, EventArgs e)
        {
            label_gia_4.Visible = false;
        }

        private void button_nam_5_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_5.Visible = true;
        }

        private void button_nam_5_MouseLeave(object sender, EventArgs e)
        {
            label_gia_5.Visible = false;
        }

        private void button_nam_6_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_6.Visible = true;
        }

        private void button_nam_6_MouseLeave(object sender, EventArgs e)
        {
            label_gia_6.Visible = false;
        }

        private void button_nam_7_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_7.Visible = true;
        }

        private void button_nam_7_MouseLeave(object sender, EventArgs e)
        {
            label_gia_7.Visible = false;
        }

        private void button_nam_8_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_8.Visible = true;
        }

        private void button_nam_8_MouseLeave(object sender, EventArgs e)
        {
            label_gia_8.Visible = false;
        }

        private void button_nam_9_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_9.Visible = true;
        }

        private void button_nam_9_MouseLeave(object sender, EventArgs e)
        {
            label_gia_9.Visible = false;
        }

        private void button_nam_10_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_10.Visible = true;
        }

        private void button_nam_10_MouseLeave(object sender, EventArgs e)
        {
            label_gia_10.Visible = false;
        }
        //panel san pham nu

        private void button_nu_1_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_11.Visible = true;
        }

        private void button_nu_1_MouseLeave(object sender, EventArgs e)
        {
            label_gia_11.Visible = false;
        }

        private void button_nu_2_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_12.Visible = true;
        }

        private void button_nu_2_MouseLeave(object sender, EventArgs e)
        {
            label_gia_12.Visible = false;
        }

        private void button_nu_3_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_13.Visible = true;
        }

        private void button_nu_3_MouseLeave(object sender, EventArgs e)
        {
            label_gia_13.Visible = false;
        }

        private void button_nu_4_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_14.Visible = true;
        }

        private void button_nu_4_MouseLeave(object sender, EventArgs e)
        {
            label_gia_14.Visible = false;
        }

        private void button_nu_5_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_15.Visible = true;
        }

        private void button_nu_5_MouseLeave(object sender, EventArgs e)
        {
            label_gia_15.Visible = false;
        }

        private void button_nu_6_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_16.Visible = true;
        }

        private void button_nu_6_MouseLeave(object sender, EventArgs e)
        {
            label_gia_16.Visible = false;
        }

        private void button_nu_7_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_17.Visible = true;
        }

        private void button_nu_7_MouseLeave(object sender, EventArgs e)
        {
            label_gia_17.Visible = false;
        }

        private void button_nu_8_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_18.Visible = true;
        }

        private void button_nu_8_MouseLeave(object sender, EventArgs e)
        {
            label_gia_18.Visible = false;
        }

        private void button_nu_9_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_19.Visible = true;
        }

        private void button_nu_9_MouseLeave(object sender, EventArgs e)
        {
            label_gia_19.Visible = false;
        }

        private void button_nu_10_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_20.Visible = true;
        }

        private void button_nu_10_MouseLeave(object sender, EventArgs e)
        {
            label_gia_20.Visible = false;
        }

        private void panel_sanpham_nu_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Nam.Visible = false;
            panel_Nu.Visible = false;
        }
        private void label_Nu_Click(object sender, EventArgs e)
        {
            check_nam = 0;
            check_nu = 1;
            check_pk = 0;

            label_sanphamchinh_huongdansudung.Visible = false;
            label_sanphamchinh_huongdansudung2.Visible = false;

            button_size1.Visible = true;
            button_size2.Visible = true;
            button_size3.Visible = true;
            button_size4.Visible = true;
            button_size5.Visible = false;

            panel_sanphamchinh.Visible = false;
            panel_sanpham_nam.Visible = false;
            panel_sanpham_nu.Visible = true;
            panel_sanphamphukien.Visible = false;
            panel_giohang.Visible = false;
            panel_review.Visible = false;
            panel_lichsu.Visible = false;

            pictureBox_pin_9.Visible = true;
            pictureBox_pin_10.Visible = true;
            pictureBox_pin_11.Visible = true;
            pictureBox_pin_12.Visible = true;
            pictureBox_pin_13.Visible = true;
            pictureBox_pin_14.Visible = true;
            pictureBox_pin_15.Visible = true;
            pictureBox_pin_16.Visible = true;

            label_point_3.Visible = true;

            button_nu_3.Visible = true;
            button_nu_4.Visible = true;
            button_nu_5.Visible = true;
            button_nu_6.Visible = true;
            button_nu_7.Visible = true;
            button_nu_8.Visible = true;
            button_nu_9.Visible = true;
            button_nu_10.Visible = true;



            button_nu_1.Visible = true;
            button_nu_2.Visible = true;

            button_nu_1.BackgroundImage = Properties.Resources.nu_clogs_1_1;
            button_nu_1.Text = "Giày Clog Unisex Crocs \r\nLiteride 360";
            label_gia_11.Text = "2.000.000 VNĐ";

            button_nu_2.BackgroundImage = Properties.Resources.nu_clogs_2_1;
            button_nu_2.Text = "Giày Clog Unisex Crocs \r\nStreetx Classic";
            label_gia_12.Text = "2.000.000 VNĐ";

            label_soluong_2.Text = "10 SẢN PHẨM";
        }

        private void button_sanphamnu_clogs_Click(object sender, EventArgs e)
        {
            check_nam = 0;
            check_nu = 1;
            check_pk = 0;

            pictureBox_pin_9.Visible = true;
            pictureBox_pin_10.Visible = false;
            pictureBox_pin_11.Visible = false;
            pictureBox_pin_12.Visible = false;
            pictureBox_pin_13.Visible = false;
            pictureBox_pin_14.Visible = false;
            pictureBox_pin_15.Visible = false;
            pictureBox_pin_16.Visible = false;


            button_nu_3.Visible = false;
            button_nu_4.Visible = false;
            button_nu_5.Visible = false;
            button_nu_6.Visible = false;
            button_nu_7.Visible = false;
            button_nu_8.Visible = false;
            button_nu_9.Visible = false;
            button_nu_10.Visible = false;

            label_point_3.Visible = false;

            button_nu_1.Visible = true;
            button_nu_2.Visible = true;

            button_nu_1.BackgroundImage = Properties.Resources.nu_clogs_1_1;
            button_nu_1.Text = "Giày Clog Unisex Crocs \r\nLiteride 360";
            label_gia_11.Text = "2.000.000 VNĐ";

            button_nu_2.BackgroundImage = Properties.Resources.nu_clogs_2_1;
            button_nu_2.Text = "Giày Clog Unisex Crocs \r\nStreetx Classic";
            label_gia_12.Text = "2.000.000 VNĐ";

            label_soluong_2.Text = "2 SẢN PHẨM";
        }

        private void button_sanphamnu_flipflops_Click(object sender, EventArgs e)
        {
            check_nam = 0;
            check_nu = 1;
            check_pk = 0;

            pictureBox_pin_9.Visible = false;
            pictureBox_pin_10.Visible = true;
            pictureBox_pin_11.Visible = false;
            pictureBox_pin_12.Visible = false;
            pictureBox_pin_13.Visible = false;
            pictureBox_pin_14.Visible = false;
            pictureBox_pin_15.Visible = false;
            pictureBox_pin_16.Visible = false;

            button_nu_2.Visible = false;
            button_nu_3.Visible = false;
            button_nu_4.Visible = false;
            button_nu_5.Visible = false;
            button_nu_6.Visible = false;
            button_nu_7.Visible = false;
            button_nu_8.Visible = false;
            button_nu_9.Visible = false;
            button_nu_10.Visible = false;

            label_point_3.Visible = false;

            button_nu_1.Visible = true;
            
            button_nu_1.BackgroundImage = Properties.Resources.nu_depxongon_1_1;
            button_nu_1.Text = "Dép Xỏ Ngón Nữ Crocs \r\nTulum";
            label_gia_11.Text = "2.000.000 VNĐ";
            

            label_soluong_2.Text = "1 SẢN PHẨM";
        }

        private void button_sanphamnu_sandals_Click(object sender, EventArgs e)
        {
            check_nam = 0;
            check_nu = 1;
            check_pk = 0;

            pictureBox_pin_9.Visible = false;
            pictureBox_pin_10.Visible = false;
            pictureBox_pin_11.Visible = true;
            pictureBox_pin_12.Visible = false;
            pictureBox_pin_13.Visible = false;
            pictureBox_pin_14.Visible = false;
            pictureBox_pin_15.Visible = false;
            pictureBox_pin_16.Visible = false;


            button_nu_3.Visible = false;
            button_nu_4.Visible = false;
            button_nu_5.Visible = false;
            button_nu_6.Visible = false;
            button_nu_7.Visible = false;
            button_nu_8.Visible = false;
            button_nu_9.Visible = false;
            button_nu_10.Visible = false;

            label_point_3.Visible = false;

            button_nu_1.Visible = true;
            button_nu_2.Visible = true;

            button_nu_1.BackgroundImage = Properties.Resources.nu_xangdan_1_1;
            button_nu_1.Text = "Dép Unisex Crocs \r\nCozzzy Classic";
            label_gia_11.Text = "2.000.000 VNĐ";

            button_nu_2.BackgroundImage = Properties.Resources.nu_xangdan_2_1;
            button_nu_2.Text = "Dép Unisex Crocs \r\nMarbled Classic";
            label_gia_12.Text = "1.000.000 VNĐ";

            label_soluong_2.Text = "2 SẢN PHẨM";
        }

        private void button_sanphamnu_slides_Click(object sender, EventArgs e)
        {
            check_nam = 0;
            check_nu = 1;
            check_pk = 0;

            pictureBox_pin_9.Visible = false;
            pictureBox_pin_10.Visible = false;
            pictureBox_pin_11.Visible = false;
            pictureBox_pin_12.Visible = true;
            pictureBox_pin_13.Visible = false;
            pictureBox_pin_14.Visible = false;
            pictureBox_pin_15.Visible = false;
            pictureBox_pin_16.Visible = false;

            button_nu_2.Visible = false;
            button_nu_3.Visible = false;
            button_nu_4.Visible = false;
            button_nu_5.Visible = false;
            button_nu_6.Visible = false;
            button_nu_7.Visible = false;
            button_nu_8.Visible = false;
            button_nu_9.Visible = false;
            button_nu_10.Visible = false;

            label_point_3.Visible = false;

            button_nu_1.Visible = true;
            
            button_nu_1.BackgroundImage = Properties.Resources.nu_depquaingang_1_1;
            button_nu_1.Text = "Dép Quai Ngang Unisex Crocs \r\nTie-dye Classic";
            label_gia_11.Text = "1.000.000 VNĐ";

            label_soluong_2.Text = "1 SẢN PHẨM";
        }

        private void button_sanphamnu_sneakers_Click(object sender, EventArgs e)
        {
            check_nam = 0;
            check_nu = 1;
            check_pk = 0;

            pictureBox_pin_9.Visible = false;
            pictureBox_pin_10.Visible = false;
            pictureBox_pin_11.Visible = false;
            pictureBox_pin_12.Visible = false;
            pictureBox_pin_13.Visible = true;
            pictureBox_pin_14.Visible = false;
            pictureBox_pin_15.Visible = false;
            pictureBox_pin_16.Visible = false;

            button_nu_2.Visible = false;
            button_nu_3.Visible = false;
            button_nu_4.Visible = false;
            button_nu_5.Visible = false;
            button_nu_6.Visible = false;
            button_nu_7.Visible = false;
            button_nu_8.Visible = false;
            button_nu_9.Visible = false;
            button_nu_10.Visible = false;

            label_point_3.Visible = false;

            button_nu_1.Visible = true;

            button_nu_1.BackgroundImage = Properties.Resources.nu_giaythoitrang_1_1;
            button_nu_1.Text = "Giày Thời Trang Nữ Crocs \r\nPacer Literide 360";
            label_gia_11.Text = "2.000.000 VNĐ";

            label_soluong_2.Text = "1 SẢN PHẨM";
        }

        private void button_sanphamnu_flats_Click(object sender, EventArgs e)
        {
            check_nam = 0;
            check_nu = 1;
            check_pk = 0;

            pictureBox_pin_9.Visible = false;
            pictureBox_pin_10.Visible = false;
            pictureBox_pin_11.Visible = false;
            pictureBox_pin_12.Visible = false;
            pictureBox_pin_13.Visible = false;
            pictureBox_pin_14.Visible = true;
            pictureBox_pin_15.Visible = false;
            pictureBox_pin_16.Visible = false;

            button_nu_2.Visible = false;
            button_nu_3.Visible = false;
            button_nu_4.Visible = false;
            button_nu_5.Visible = false;
            button_nu_6.Visible = false;
            button_nu_7.Visible = false;
            button_nu_8.Visible = false;
            button_nu_9.Visible = false;
            button_nu_10.Visible = false;

            label_point_3.Visible = false;

            button_nu_1.Visible = true;

            button_nu_1.BackgroundImage = Properties.Resources.nu_giaythoitrang_1_1;
            button_nu_1.Text = "Giày Bệt Nữ Crocs \r\nTulum";
            label_gia_11.Text = "2.000.000 VNĐ";

            label_soluong_2.Text = "1 SẢN PHẨM";
        }

        private void button_sanphamnu_wedges_Click(object sender, EventArgs e)
        {
            check_nam = 0;
            check_nu = 1;
            check_pk = 0;

            pictureBox_pin_9.Visible = false;
            pictureBox_pin_10.Visible = false;
            pictureBox_pin_11.Visible = false;
            pictureBox_pin_12.Visible = false;
            pictureBox_pin_13.Visible = false;
            pictureBox_pin_14.Visible = false;
            pictureBox_pin_15.Visible = true;
            pictureBox_pin_16.Visible = false;


            button_nu_3.Visible = false;
            button_nu_4.Visible = false;
            button_nu_5.Visible = false;
            button_nu_6.Visible = false;
            button_nu_7.Visible = false;
            button_nu_8.Visible = false;
            button_nu_9.Visible = false;
            button_nu_10.Visible = false;

            label_point_3.Visible = false;

            button_nu_1.Visible = true;
            button_nu_2.Visible = true;

            button_nu_1.BackgroundImage = Properties.Resources.nu_giaydexuong_1_1;
            button_nu_1.Text = "Giày Đế Xuồng Nữ Crocs \r\nBrooklyn";
            label_gia_11.Text = "2.000.000 VNĐ";

            button_nu_2.BackgroundImage = Properties.Resources.nu_giaydexuong_2_1;
            button_nu_2.Text = "Balenciaga X Crocs \r\nLogo Debossed Pumps";
            label_gia_12.Text = "14.000.000 VNĐ";

            label_soluong_2.Text = "2 SẢN PHẨM";
        }

        private void label_1_nu_Click(object sender, EventArgs e)
        {
            check_nam = 0;
            check_nu = 1;
            check_pk = 0;

            label_sanphamchinh_huongdansudung.Visible = false;
            label_sanphamchinh_huongdansudung2.Visible = false;

            button_size1.Visible = true;
            button_size2.Visible = true;
            button_size3.Visible = true;
            button_size4.Visible = true;
            button_size5.Visible = false;

            panel_sanphamchinh.Visible = false;
            panel_sanpham_nam.Visible = false;
            panel_sanpham_nu.Visible = true;
            panel_sanphamphukien.Visible = false;
            panel_giohang.Visible = false;
            panel_review.Visible = false;
            panel_lichsu.Visible = false;

            pictureBox_pin_9.Visible = true;
            pictureBox_pin_10.Visible = false;
            pictureBox_pin_11.Visible = false;
            pictureBox_pin_12.Visible = false;
            pictureBox_pin_13.Visible = false;
            pictureBox_pin_14.Visible = false;
            pictureBox_pin_15.Visible = false;
            pictureBox_pin_16.Visible = false;


            button_nu_3.Visible = false;
            button_nu_4.Visible = false;
            button_nu_5.Visible = false;
            button_nu_6.Visible = false;
            button_nu_7.Visible = false;
            button_nu_8.Visible = false;
            button_nu_9.Visible = false;
            button_nu_10.Visible = false;

            label_point_3.Visible = false;

            button_nu_1.Visible = true;
            button_nu_2.Visible = true;

            button_nu_1.BackgroundImage = Properties.Resources.nu_clogs_1_1;
            button_nu_1.Text = "Giày Clog Unisex Crocs \r\nLiteride 360";
            label_gia_11.Text = "2.000.000 VNĐ";

            button_nu_2.BackgroundImage = Properties.Resources.nu_clogs_2_1;
            button_nu_2.Text = "Giày Clog Unisex Crocs \r\nStreetx Classic";
            label_gia_12.Text = "2.000.000 VNĐ";

            label_soluong_2.Text = "2 SẢN PHẨM";
        }

        private void label_2_nu_Click(object sender, EventArgs e)
        {
            check_nam = 0;
            check_nu = 1;
            check_pk = 0;

            label_sanphamchinh_huongdansudung.Visible = false;
            label_sanphamchinh_huongdansudung2.Visible = false;

            button_size1.Visible = true;
            button_size2.Visible = true;
            button_size3.Visible = true;
            button_size4.Visible = true;
            button_size5.Visible = false;

            panel_sanphamchinh.Visible = false;
            panel_sanpham_nam.Visible = false;
            panel_sanpham_nu.Visible = true;
            panel_sanphamphukien.Visible = false;
            panel_giohang.Visible = false;
            panel_review.Visible = false;
            panel_lichsu.Visible = false;

            pictureBox_pin_9.Visible = false;
            pictureBox_pin_10.Visible = true;
            pictureBox_pin_11.Visible = false;
            pictureBox_pin_12.Visible = false;
            pictureBox_pin_13.Visible = false;
            pictureBox_pin_14.Visible = false;
            pictureBox_pin_15.Visible = false;
            pictureBox_pin_16.Visible = false;

            button_nu_2.Visible = false;
            button_nu_3.Visible = false;
            button_nu_4.Visible = false;
            button_nu_5.Visible = false;
            button_nu_6.Visible = false;
            button_nu_7.Visible = false;
            button_nu_8.Visible = false;
            button_nu_9.Visible = false;
            button_nu_10.Visible = false;

            label_point_3.Visible = false;

            button_nu_1.Visible = true;

            button_nu_1.BackgroundImage = Properties.Resources.nu_depxongon_1_1;
            button_nu_1.Text = "Dép Xỏ Ngón Nữ Crocs \r\nTulum";
            label_gia_11.Text = "1.000.000 VNĐ";


            label_soluong_2.Text = "1 SẢN PHẨM";
        }

        private void label_3_nu_Click(object sender, EventArgs e)
        {
            check_nam = 0;
            check_nu = 1;
            check_pk = 0;

            label_sanphamchinh_huongdansudung.Visible = false;
            label_sanphamchinh_huongdansudung2.Visible = false;

            button_size1.Visible = true;
            button_size2.Visible = true;
            button_size3.Visible = true;
            button_size4.Visible = true;
            button_size5.Visible = false;

            panel_sanphamchinh.Visible = false;
            panel_sanpham_nam.Visible = false;
            panel_sanpham_nu.Visible = true;
            panel_sanphamphukien.Visible = false;
            panel_giohang.Visible = false;
            panel_review.Visible = false;
            panel_lichsu.Visible = false;

            pictureBox_pin_9.Visible = false;
            pictureBox_pin_10.Visible = false;
            pictureBox_pin_11.Visible = true;
            pictureBox_pin_12.Visible = false;
            pictureBox_pin_13.Visible = false;
            pictureBox_pin_14.Visible = false;
            pictureBox_pin_15.Visible = false;
            pictureBox_pin_16.Visible = false;


            button_nu_3.Visible = false;
            button_nu_4.Visible = false;
            button_nu_5.Visible = false;
            button_nu_6.Visible = false;
            button_nu_7.Visible = false;
            button_nu_8.Visible = false;
            button_nu_9.Visible = false;
            button_nu_10.Visible = false;

            label_point_3.Visible = false;

            button_nu_1.Visible = true;
            button_nu_2.Visible = true;

            button_nu_1.BackgroundImage = Properties.Resources.nu_xangdan_1_1;
            button_nu_1.Text = "Dép Unisex Crocs \r\nCozzzy Classic";
            label_gia_11.Text = "2.000.000 VNĐ";

            button_nu_2.BackgroundImage = Properties.Resources.nu_xangdan_2_1;
            button_nu_2.Text = "Dép Unisex Crocs \r\nMarbled Classic";
            label_gia_12.Text = "1.000.000 VNĐ";

            label_soluong_2.Text = "2 SẢN PHẨM";
        }

        private void label_4_nu_Click(object sender, EventArgs e)
        {
            check_nam = 0;
            check_nu = 1;
            check_pk = 0;

            label_sanphamchinh_huongdansudung.Visible = false;
            label_sanphamchinh_huongdansudung2.Visible = false;

            button_size1.Visible = true;
            button_size2.Visible = true;
            button_size3.Visible = true;
            button_size4.Visible = true;
            button_size5.Visible = false;

            panel_sanphamchinh.Visible = false;
            panel_sanpham_nam.Visible = false;
            panel_sanpham_nu.Visible = true;
            panel_sanphamphukien.Visible = false;
            panel_giohang.Visible = false;
            panel_review.Visible = false;
            panel_lichsu.Visible = false;

            pictureBox_pin_9.Visible = false;
            pictureBox_pin_10.Visible = false;
            pictureBox_pin_11.Visible = false;
            pictureBox_pin_12.Visible = false;
            pictureBox_pin_13.Visible = false;
            pictureBox_pin_14.Visible = false;
            pictureBox_pin_15.Visible = true;
            pictureBox_pin_16.Visible = false;


            button_nu_3.Visible = false;
            button_nu_4.Visible = false;
            button_nu_5.Visible = false;
            button_nu_6.Visible = false;
            button_nu_7.Visible = false;
            button_nu_8.Visible = false;
            button_nu_9.Visible = false;
            button_nu_10.Visible = false;

            label_point_3.Visible = false;

            button_nu_1.Visible = true;
            button_nu_2.Visible = true;

            button_nu_1.BackgroundImage = Properties.Resources.nu_giaydexuong_1_1;
            button_nu_1.Text = "Giày Đế Xuồng Nữ Crocs \r\nBrooklyn";
            label_gia_11.Text = "2.000.000 VNĐ";

            button_nu_2.BackgroundImage = Properties.Resources.nu_giaydexuong_2_1;
            button_nu_2.Text = "Balenciaga X Crocs \r\nLogo Debossed Pumps";
            label_gia_12.Text = "14.000.000 VNĐ";

            label_soluong_2.Text = "2 SẢN PHẨM";
        }

        private void label_5_nu_Click(object sender, EventArgs e)
        {
            check_nam = 0;
            check_nu = 1;
            check_pk = 0;

            label_sanphamchinh_huongdansudung.Visible = false;
            label_sanphamchinh_huongdansudung2.Visible = false;

            button_size1.Visible = true;
            button_size2.Visible = true;
            button_size3.Visible = true;
            button_size4.Visible = true;
            button_size5.Visible = false;

            panel_sanphamchinh.Visible = false;
            panel_sanpham_nam.Visible = false;
            panel_sanpham_nu.Visible = true;
            panel_sanphamphukien.Visible = false;
            panel_giohang.Visible = false;
            panel_review.Visible = false;
            panel_lichsu.Visible = false;

            pictureBox_pin_9.Visible = false;
            pictureBox_pin_10.Visible = false;
            pictureBox_pin_11.Visible = false;
            pictureBox_pin_12.Visible = true;
            pictureBox_pin_13.Visible = false;
            pictureBox_pin_14.Visible = false;
            pictureBox_pin_15.Visible = false;
            pictureBox_pin_16.Visible = false;

            button_nu_2.Visible = false;
            button_nu_3.Visible = false;
            button_nu_4.Visible = false;
            button_nu_5.Visible = false;
            button_nu_6.Visible = false;
            button_nu_7.Visible = false;
            button_nu_8.Visible = false;
            button_nu_9.Visible = false;
            button_nu_10.Visible = false;

            label_point_3.Visible = false;

            button_nu_1.Visible = true;

            button_nu_1.BackgroundImage = Properties.Resources.nu_depquaingang_1_1;
            button_nu_1.Text = "Dép Quai Ngang Unisex Crocs \r\nTie-dye Classic";
            label_gia_11.Text = "1.000.000 VNĐ";

            label_soluong_2.Text = "1 SẢN PHẨM";
        }

        private void label_6_nu_Click(object sender, EventArgs e)
        {
            check_nam = 0;
            check_nu = 1;
            check_pk = 0;

            label_sanphamchinh_huongdansudung.Visible = false;
            label_sanphamchinh_huongdansudung2.Visible = false;

            button_size1.Visible = true;
            button_size2.Visible = true;
            button_size3.Visible = true;
            button_size4.Visible = true;
            button_size5.Visible = false;

            panel_sanphamchinh.Visible = false;
            panel_sanpham_nam.Visible = false;
            panel_sanpham_nu.Visible = true;
            panel_sanphamphukien.Visible = false;
            panel_giohang.Visible = false;
            panel_review.Visible = false;
            panel_lichsu.Visible = false;

            pictureBox_pin_9.Visible = false;
            pictureBox_pin_10.Visible = false;
            pictureBox_pin_11.Visible = false;
            pictureBox_pin_12.Visible = false;
            pictureBox_pin_13.Visible = true;
            pictureBox_pin_14.Visible = false;
            pictureBox_pin_15.Visible = false;
            pictureBox_pin_16.Visible = false;

            button_nu_2.Visible = false;
            button_nu_3.Visible = false;
            button_nu_4.Visible = false;
            button_nu_5.Visible = false;
            button_nu_6.Visible = false;
            button_nu_7.Visible = false;
            button_nu_8.Visible = false;
            button_nu_9.Visible = false;
            button_nu_10.Visible = false;

            label_point_3.Visible = false;

            button_nu_1.Visible = true;

            button_nu_1.BackgroundImage = Properties.Resources.nu_giaythoitrang_1_1;
            button_nu_1.Text = "Giày Thời Trang Nữ Crocs \r\nPacer Literide 360";
            label_gia_11.Text = "2.000.000 VNĐ";

            label_soluong_2.Text = "1 SẢN PHẨM";
        }

        private void label_7_nu_Click(object sender, EventArgs e)
        {
            check_nam = 0;
            check_nu = 1;
            check_pk = 0;

            label_sanphamchinh_huongdansudung.Visible = false;
            label_sanphamchinh_huongdansudung2.Visible = false;

            button_size1.Visible = true;
            button_size2.Visible = true;
            button_size3.Visible = true;
            button_size4.Visible = true;
            button_size5.Visible = false;

            panel_sanphamchinh.Visible = false;
            panel_sanpham_nam.Visible = false;
            panel_sanpham_nu.Visible = true;
            panel_sanphamphukien.Visible = false;
            panel_giohang.Visible = false;
            panel_review.Visible = false;
            panel_lichsu.Visible = false;

            pictureBox_pin_9.Visible = false;
            pictureBox_pin_10.Visible = false;
            pictureBox_pin_11.Visible = false;
            pictureBox_pin_12.Visible = false;
            pictureBox_pin_13.Visible = false;
            pictureBox_pin_14.Visible = true;
            pictureBox_pin_15.Visible = false;
            pictureBox_pin_16.Visible = false;

            button_nu_2.Visible = false;
            button_nu_3.Visible = false;
            button_nu_4.Visible = false;
            button_nu_5.Visible = false;
            button_nu_6.Visible = false;
            button_nu_7.Visible = false;
            button_nu_8.Visible = false;
            button_nu_9.Visible = false;
            button_nu_10.Visible = false;

            label_point_3.Visible = false;

            button_nu_1.Visible = true;

            button_nu_1.BackgroundImage = Properties.Resources.nu_giaythoitrang_1_1;
            button_nu_1.Text = "Giày Bệt Nữ Crocs \r\nTulum";
            label_gia_11.Text = "2.000.000 VNĐ";

            label_soluong_2.Text = "1 SẢN PHẨM";
        }

        private void button_sanphamnu_all_Click(object sender, EventArgs e)
        {
            check_nam = 0;
            check_nu = 1;
            check_pk = 0;

            pictureBox_pin_9.Visible = true;
            pictureBox_pin_10.Visible = true;
            pictureBox_pin_11.Visible = true;
            pictureBox_pin_12.Visible = true;
            pictureBox_pin_13.Visible = true;
            pictureBox_pin_14.Visible = true;
            pictureBox_pin_15.Visible = true;
            pictureBox_pin_16.Visible = true;


            button_nu_3.Visible = true;
            button_nu_4.Visible = true;
            button_nu_5.Visible = true;
            button_nu_6.Visible = true;
            button_nu_7.Visible = true;
            button_nu_8.Visible = true;
            button_nu_9.Visible = true;
            button_nu_10.Visible = true;

            label_point_3.Visible = true;

            button_nu_1.Visible = true;
            button_nu_2.Visible = true;

            button_nu_1.BackgroundImage = Properties.Resources.nu_clogs_1_1;
            button_nu_1.Text = "Giày Clog Unisex Crocs \r\nLiteride 360";
            label_gia_11.Text = "2.000.000 VNĐ";

            button_nu_2.BackgroundImage = Properties.Resources.nu_clogs_2_1;
            button_nu_2.Text = "Giày Clog Unisex Crocs \r\nStreetx Classic";
            label_gia_12.Text = "2.000.000 VNĐ";

            label_soluong_2.Text = "10 SẢN PHẨM";
        }

        //panel phu kien
        private void label_phukien_Click(object sender, EventArgs e)
        {
            check_nam = 0;
            check_nu = 0;
            check_pk = 1;

            panel_sanphamchinh.Visible = false;
            panel_sanpham_nam.Visible = false;
            panel_sanpham_nu.Visible = false;
            panel_sanphamphukien.Visible = true;
            panel_giohang.Visible = false;
            panel_review.Visible = false;
            panel_lichsu.Visible = false;
        }

        private void panel_sanphamphukien_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Nam.Visible = false;
            panel_Nu.Visible = false;
        }

        private void button_phukien_1_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_21.Visible = true;
        }

        private void button_phukien_1_MouseLeave(object sender, EventArgs e)
        {
            label_gia_21.Visible = false;
        }

        private void button_phukien_2_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_22.Visible = true;
        }

        private void button_phukien_2_MouseLeave(object sender, EventArgs e)
        {
            label_gia_22.Visible = false;
        }

        private void button_phukien_3_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_23.Visible = true;
        }

        private void button_phukien_3_MouseLeave(object sender, EventArgs e)
        {
            label_gia_23.Visible = false;
        }

        private void button_phukien_4_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_24.Visible = true;
        }

        private void button_phukien_4_MouseLeave(object sender, EventArgs e)
        {
            label_gia_24.Visible = false;
        }

        private void button_phukien_5_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_25.Visible = true;
        }

        private void button_phukien_5_MouseLeave(object sender, EventArgs e)
        {
            label_gia_25.Visible = false;
        }

        private void button_phukien_6_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_26.Visible = true;
        }

        private void button_phukien_6_MouseLeave(object sender, EventArgs e)
        {
            label_gia_26.Visible = false;
        }

        private void button_phukien_7_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_27.Visible = true;
        }

        private void button_phukien_7_MouseLeave(object sender, EventArgs e)
        {
            label_gia_27.Visible = false;
        }

        private void button_phukien_8_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_28.Visible = true;
        }

        private void button_phukien_8_MouseLeave(object sender, EventArgs e)
        {
            label_gia_28.Visible = false;
        }

        private void button_phukien_9_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_29.Visible = true;
        }

        private void button_phukien_9_MouseLeave(object sender, EventArgs e)
        {
            label_gia_29.Visible = false;
        }

        private void button_phukien_10_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_30.Visible = true;
        }

        private void button_phukien_10_MouseLeave(object sender, EventArgs e)
        {
            label_gia_30.Visible = false;
        }

        private void button_phukien_11_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_31.Visible = true;
        }

        private void button_phukien_11_MouseLeave(object sender, EventArgs e)
        {
            label_gia_31.Visible = false;
        }

        private void button_phukien_12_MouseMove(object sender, MouseEventArgs e)
        {
            label_gia_32.Visible = true;
        }

        private void button_phukien_12_MouseLeave(object sender, EventArgs e)
        {
            label_gia_32.Visible = false;
        }

        //san pham chinh
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            size_check_1 = 0;
            size_check_2 = 0;
            size_check_3 = 0;
            size_check_4 = 0;
            size_check_5 = 0;
            ten_size = "";
            button_size1.BackColor = Color.SpringGreen;
            button_size2.BackColor = Color.SpringGreen;
            button_size3.BackColor = Color.SpringGreen;
            button_size4.BackColor = Color.SpringGreen;
            button_size5.BackColor = Color.SpringGreen;

            label_sanphamchinh_huongdansudung.Visible = false;
            label_sanphamchinh_huongdansudung2.Visible = false;

            button_size1.Visible = true;
            button_size2.Visible = true;
            button_size3.Visible = true;
            button_size4.Visible = true;
            button_size5.Visible = false;

            if (check_nam==1)
            {
                panel_sanpham_nam.Visible = true;
                panel_sanphamchinh.Visible = false;
            }

            if (check_nu == 1)
            {
                panel_sanpham_nu.Visible = true;
                panel_sanphamchinh.Visible = false;
            }

            if (check_pk == 1)
            {
                panel_sanphamphukien.Visible = true;
                panel_sanphamchinh.Visible = false;
            }

            if(check_nam ==  0 && check_nu ==0 && check_pk == 0)
            {
                panel_sanpham_nam.Visible = false;
                panel_sanpham_nu.Visible = false;
                panel_sanphamphukien.Visible = false;
                panel_sanphamchinh.Visible = false;
            }

        }

        private void button_nam_1_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nam.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_1.Text;
            label_sanphamchinh_giatien.Text = label_gia_1.Text;

            switch (label_sanphamchinh_tensanpham.Text)
            {
                //clogs
                case "Giày Clog Unisex Crocs Crush\r\nSpray Dye Classic":
                    label_sanphamchinh_chitiet.Text =
                        "- Cực kỳ nhẹ và thoải mái\r\n" +
                        "- Chống nước\r\n" +
                        "- Thiết kế các lỗ giúp tăng độ thông thoáng,\r\n" +
                        "  chống đọng nước\r\n" +
                        "- Dễ dàng làm sạch và nhanh khô\r\n" +
                        "- Dây quai gót xoay, vừa vặn an toàn\r\n" +
                        "- Có thể kết hợp với phụ kiện Jibbitz™\r\n" +
                        "- Iconic Crocs Comfort ™: Nhẹ. Linh hoạt. Tiện nghi 360 độ.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_clogs_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_clogs_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_clogs_1_2;
                    Add_lichsu();
                    break;

                //quaingang
                case "Dép Quai Ngang Unisex Crocs \r\nCyber Nights Classic":
                    label_sanphamchinh_chitiet.Text =
                        "- Được chế tác từ Croslite™ – mang đến cảm giác êm ái,\r\n" +
                        "  siêu nhẹ và thoải mái.\r\n" +
                        "- Chất liệu dễ lau chùi và chống nước\r\n" +
                        "- Cực kỳ nhẹ và thú vị khi mang\r\n" +
                        "- Có thể trang trí sáng tạo cá tính riêng\r\n" +
                        "  với phụ kiện Jibbitz ™\r\n" +
                        "- Lớp lót sử dụng công nghệ độc quyền\r\n" +
                        "  Iconic Crocs Comfort ™: \r\n" +
                        "  Nhẹ. Linh hoạt. Tiện nghi 360";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_depquaingang_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_depquaingang_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_depquaingang_1_2;
                    Add_lichsu();
                    break;

                //thoitrang
                case "Giày Thời Trang Nam Crocs \r\nPacer Literide 1":
                    label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                        "  và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự thoải mái\r\n" +
                        "  và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động và đậm chất riêng\r\n" +
                        "  bằng các loại Jibbitz dành cho Dây giày thể thao.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_2;
                    Add_lichsu();
                    break;

                //xangdan
                case "Dép Unisex Crocs \r\nSpray Dye Classic":
                    label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                        "  và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự\r\n" +
                        "  thoải mái và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                        "  đậm chất riêng bằng\r\n" +
                        "  các loại Jibbitz dành cho Dây giày thể thao.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_xangdan_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_xangdan_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_xangdan_1_2;
                    Add_lichsu();
                    break;

                //xongon
                case "Dép Xỏ Ngón Unisex Crocs \r\nSpray Dye Classic":
                    label_sanphamchinh_chitiet.Text =
                       "- Kiểu dáng thể thao\r\n" +
                       "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                       "  và có độ đàn hồi cao\r\n" +
                       "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                       "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại\r\n" +
                       "  sự thoải mái và hỗ trợ cả ngày\r\n" +
                       "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                       "  đậm chất riêng bằng\r\n" +
                       "  các loại Jibbitz dành cho Dây giày thể thao.";


                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_xongon_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_xongon_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_xongon_1_2;
                    Add_lichsu();
                    break;
            }     
        }

        private void button_nam_2_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nam.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_2.Text;
            label_sanphamchinh_giatien.Text = label_gia_2.Text;

            switch (label_sanphamchinh_tensanpham.Text)
            {
                //clogs
                case "Giày Clog Unisex Crocs \r\nPokemon Classic":
                    label_sanphamchinh_chitiet.Text = 
                        "- Cực kỳ nhẹ và thoải mái\r\n" +
                        "- Chống nước\r\n" +
                        "- Thiết kế các lỗ giúp tăng độ thông thoáng,\r\n" +
                        "  chống đọng nước\r\n" +
                        "- Dễ dàng làm sạch và nhanh khô\r\n" +
                        "- Dây quai gót xoay, vừa vặn an toàn\r\n" +
                        "- Có thể kết hợp với phụ kiện Jibbitz™\r\n" +
                        "- Iconic Crocs Comfort ™: Nhẹ. Linh hoạt. Tiện nghi 360 độ.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_clogs_2_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_clogs_2_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_clogs_2_2;
                    Add_lichsu();
                    break;

                //quaingang
                case "Dép Quai Ngang Unisex Crocs \r\nClassic":
                    label_sanphamchinh_chitiet.Text = 
                        "- Được chế tác từ Croslite™ – mang đến cảm giác êm ái,\r\n" +
                        "  siêu nhẹ và thoải mái.\r\n" +
                        "- Chất liệu dễ lau chùi và chống nước\r\n" +
                        "- Cực kỳ nhẹ và thú vị khi mang\r\n" +
                        "- Có thể trang trí sáng tạo cá tính riêng\r\n" +
                        "  với phụ kiện Jibbitz ™\r\n" +
                        "- Lớp lót sử dụng công nghệ độc quyền\r\n" +
                        "  Iconic Crocs Comfort ™: \r\n" +
                        "  Nhẹ. Linh hoạt. Tiện nghi 360";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_depquaingang_2_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_depquaingang_2_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_depquaingang_2_2;
                    Add_lichsu();
                    break;

                //thoitrang
                case "Giày Thời Trang Nam Crocs \r\nPacer Literide 2":
                    label_sanphamchinh_chitiet.Text = 
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                        "  và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự thoải mái\r\n" +
                        "  và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động và đậm chất riêng\r\n" +
                        "  bằng các loại Jibbitz dành cho Dây giày thể thao.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_giaythoitrang_2_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_giaythoitrang_2_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_giaythoitrang_2_2;
                    Add_lichsu();
                    break;

                //xangdan
                case "Dép Unisex Crocs \r\nAll Terrain Classic":
                    label_sanphamchinh_chitiet.Text = 
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                        "  và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự\r\n" +
                        "  thoải mái và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                        "  đậm chất riêng bằng\r\n" +
                        "  các loại Jibbitz dành cho Dây giày thể thao.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_xangdan_2_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_xangdan_2_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_xangdan_2_2;
                    Add_lichsu();
                    break;

                //xongon
                case "Dép Xỏ Ngón Unisex Crocs \r\nBayaband":
                    label_sanphamchinh_chitiet.Text = 
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                        "  và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại\r\n" +
                        "  sự thoải mái và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                        "  đậm chất riêng bằng\r\n" +
                        "  các loại Jibbitz dành cho Dây giày thể thao.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_xongon_2_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_xongon_2_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_xongon_2_2;
                    Add_lichsu();
                    break;
            }
        }


        private void pictureBox_sanphamchinh_trai1_Click(object sender, EventArgs e)
        {
            pictureBox_sanphamchinh.BackgroundImage = pictureBox_sanphamchinh_trai1.BackgroundImage;
        }

        private void pictureBox_sanphamchinh_trai2_Click(object sender, EventArgs e)
        {
            pictureBox_sanphamchinh.BackgroundImage = pictureBox_sanphamchinh_trai2.BackgroundImage;
        }

        private void button_nam_3_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nam.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_3.Text;
            label_sanphamchinh_giatien.Text = label_gia_3.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Được chế tác từ Croslite™ – mang đến cảm giác êm ái,\r\n" +
                        "  siêu nhẹ và thoải mái.\r\n" +
                        "- Chất liệu dễ lau chùi và chống nước\r\n" +
                        "- Cực kỳ nhẹ và thú vị khi mang\r\n" +
                        "- Có thể trang trí sáng tạo cá tính riêng\r\n" +
                        "  với phụ kiện Jibbitz ™\r\n" +
                        "- Lớp lót sử dụng công nghệ độc quyền\r\n" +
                        "  Iconic Crocs Comfort ™: \r\n" +
                        "  Nhẹ. Linh hoạt. Tiện nghi 360";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_depquaingang_1_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_depquaingang_1_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_depquaingang_1_2;
            Add_lichsu();
        }

        private void button_nam_4_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nam.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_4.Text;
            label_sanphamchinh_giatien.Text = label_gia_4.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Được chế tác từ Croslite™ – mang đến cảm giác êm ái,\r\n" +
                        "  siêu nhẹ và thoải mái.\r\n" +
                        "- Chất liệu dễ lau chùi và chống nước\r\n" +
                        "- Cực kỳ nhẹ và thú vị khi mang\r\n" +
                        "- Có thể trang trí sáng tạo cá tính riêng\r\n" +
                        "  với phụ kiện Jibbitz ™\r\n" +
                        "- Lớp lót sử dụng công nghệ độc quyền\r\n" +
                        "  Iconic Crocs Comfort ™: \r\n" +
                        "  Nhẹ. Linh hoạt. Tiện nghi 360";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_depquaingang_2_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_depquaingang_2_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_depquaingang_2_2;
            Add_lichsu();
        }

        private void button_nam_5_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nam.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_5.Text;
            label_sanphamchinh_giatien.Text = label_gia_5.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                        "  và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự thoải mái\r\n" +
                        "  và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động và đậm chất riêng\r\n" +
                        "  bằng các loại Jibbitz dành cho Dây giày thể thao.";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_2;
            Add_lichsu();
        }

        private void button_nam_6_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nam.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_6.Text;
            label_sanphamchinh_giatien.Text = label_gia_6.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                        "  và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự thoải mái\r\n" +
                        "  và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động và đậm chất riêng\r\n" +
                        "  bằng các loại Jibbitz dành cho Dây giày thể thao.";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_giaythoitrang_2_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_giaythoitrang_2_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_giaythoitrang_2_2;
            Add_lichsu();
        }

        private void button_nam_7_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nam.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_7.Text;
            label_sanphamchinh_giatien.Text = label_gia_7.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                        "  và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự\r\n" +
                        "  thoải mái và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                        "  đậm chất riêng bằng\r\n" +
                        "  các loại Jibbitz dành cho Dây giày thể thao.";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_xangdan_1_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_xangdan_1_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_xangdan_1_2;
            Add_lichsu();
        }

        private void button_nam_8_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nam.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_8.Text;
            label_sanphamchinh_giatien.Text = label_gia_8.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                        "  và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự\r\n" +
                        "  thoải mái và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                        "  đậm chất riêng bằng\r\n" +
                        "  các loại Jibbitz dành cho Dây giày thể thao.";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_xangdan_2_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_xangdan_2_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_xangdan_2_2;
            Add_lichsu();
        }

        private void button_nam_9_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nam.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_9.Text;
            label_sanphamchinh_giatien.Text = label_gia_9.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                        "  và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại\r\n" +
                        "  sự thoải mái và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                        "  đậm chất riêng bằng\r\n" +
                        "  các loại Jibbitz dành cho Dây giày thể thao.";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_xongon_1_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_xongon_1_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_xongon_1_2;
            Add_lichsu();
        }

        private void button_nam_10_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nam.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_10.Text;
            label_sanphamchinh_giatien.Text = label_gia_10.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                        "  và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại\r\n" +
                        "  sự thoải mái và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                        "  đậm chất riêng bằng\r\n" +
                        "  các loại Jibbitz dành cho Dây giày thể thao.";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_xongon_2_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_xongon_2_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_xongon_2_2;
            Add_lichsu();
        }

        private void button_nu_1_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nu.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_1.Text;
            label_sanphamchinh_giatien.Text = label_gia_11.Text;

            switch (label_sanphamchinh_tensanpham.Text)
            {
                //clogs
                case "Giày Clog Unisex Crocs \r\nLiteride 360":
                    label_sanphamchinh_chitiet.Text =
                        "- Cực kỳ nhẹ và thoải mái\r\n" +
                        "- Chống nước\r\n" +
                        "- Thiết kế các lỗ giúp tăng độ thông thoáng,\r\n" +
                        "  chống đọng nước\r\n" +
                        "- Dễ dàng làm sạch và nhanh khô\r\n" +
                        "- Dây quai gót xoay, vừa vặn an toàn\r\n" +
                        "- Có thể kết hợp với phụ kiện Jibbitz™\r\n" +
                        "- Iconic Crocs Comfort ™: Nhẹ. Linh hoạt. Tiện nghi 360 độ.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_clogs_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_clogs_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_clogs_1_2;
                    Add_lichsu();
                    break;

                //quaingang
                case "Dép Quai Ngang Unisex Crocs \r\nTie-dye Classic":
                    label_sanphamchinh_chitiet.Text =
                        "- Được chế tác từ Croslite™ – mang đến cảm giác êm ái,\r\n" +
                        "  siêu nhẹ và thoải mái.\r\n" +
                        "- Chất liệu dễ lau chùi và chống nước\r\n" +
                        "- Cực kỳ nhẹ và thú vị khi mang\r\n" +
                        "- Có thể trang trí sáng tạo cá tính riêng\r\n" +
                        "  với phụ kiện Jibbitz ™\r\n" +
                        "- Lớp lót sử dụng công nghệ độc quyền\r\n" +
                        "  Iconic Crocs Comfort ™: \r\n" +
                        "  Nhẹ. Linh hoạt. Tiện nghi 360";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_depquaingang_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_depquaingang_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_depquaingang_1_2;
                    Add_lichsu();
                    break;

                //thoitrang
                case "Giày Thời Trang Nam Crocs \r\nPacer Literide 1":
                    label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                        "  và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự thoải mái\r\n" +
                        "  và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động và đậm chất riêng\r\n" +
                        "  bằng các loại Jibbitz dành cho Dây giày thể thao.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_2;
                    Add_lichsu();
                    break;

                //xangdan
                case "Dép Unisex Crocs \r\nCozzzy Classic":
                    label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                        "  và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự\r\n" +
                        "  thoải mái và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                        "  đậm chất riêng bằng\r\n" +
                        "  các loại Jibbitz dành cho Dây giày thể thao.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_xangdan_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_xangdan_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_xangdan_1_2;
                    Add_lichsu();
                    break;

                //xongon
                case "Dép Xỏ Ngón Nữ Crocs \r\nTulum":
                    label_sanphamchinh_chitiet.Text =
                       "- Kiểu dáng thể thao\r\n" +
                       "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                       "  và có độ đàn hồi cao\r\n" +
                       "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                       "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại\r\n" +
                       "  sự thoải mái và hỗ trợ cả ngày\r\n" +
                       "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                       "  đậm chất riêng bằng\r\n" +
                       "  các loại Jibbitz dành cho Dây giày thể thao.";


                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_depxongon_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_depxongon_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_depxongon_1_2;
                    Add_lichsu();
                    break;

                //giaybet
                case "Giày Bệt Nữ Crocs \r\nTulum":
                    label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ\r\n" +
                        "  nhẹ và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự\r\n" +
                        " thoải mái và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động\r\n" +
                        "  và đậm chất riêng bằng các loại Jibbitz\r\n" +
                        "  dành cho Dây giày thể thao.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_giaybet_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_giaybet_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_giaybet_1_2;
                    Add_lichsu();
                    break;

                //giaydexuong
                case "Giày Đế Xuồng Nữ Crocs \r\nBrooklyn":
                    label_sanphamchinh_chitiet.Text = 
                        "- Kiểu dáng hai dây đeo thanh lịch với dây cài\r\n" +
                        "  phần gót chân đảm bảo an toàn cho mỗi bước chân của bạn\r\n" +
                        "- Công nghệ LiteRide™ cách tân tạo cảm giác thoải mái tối ưu \r\n" +
                        "- Đế Croslite™ siêu nhẹ mang lại sự thoải mái trên mỗi bước chân \r\n" +
                        "- Quai Matlite ™ siêu mềm, linh hoạt cho cảm giác\r\n" +
                        "  dễ chịu ngay từ ngày đầu tiên\r\n" +
                        "- Gót sâu và phần đế được nâng cao nhằm nâng chiều cao và sự ổn định\r\n" +
                        "- Dây đeo với khóa cài thông minh giúp dễ dàng điều chỉnh\r\n" +
                        "- Chiều cao gót: 1.7 inches / 45mm\r\n" +
                        "- Tấm lót LiteRide™ : Mang tính cách mạng. Cực mềm và êm.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_giaydexuong_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_giaydexuong_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_giaydexuong_1_2;
                    Add_lichsu();
                    break;
            }

        }

        private void button_nu_2_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nu.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_2.Text;
            label_sanphamchinh_giatien.Text = label_gia_12.Text;

            switch (label_sanphamchinh_tensanpham.Text)
            {
                //clogs
                case "Giày Clog Unisex Crocs \r\nStreetx Classic":
                    label_sanphamchinh_chitiet.Text =
                        "- Cực kỳ nhẹ và thoải mái\r\n" +
                        "- Chống nước\r\n" +
                        "- Thiết kế các lỗ giúp tăng độ thông thoáng,\r\n" +
                        "  chống đọng nước\r\n" +
                        "- Dễ dàng làm sạch và nhanh khô\r\n" +
                        "- Dây quai gót xoay, vừa vặn an toàn\r\n" +
                        "- Có thể kết hợp với phụ kiện Jibbitz™\r\n" +
                        "- Iconic Crocs Comfort ™: Nhẹ. Linh hoạt. Tiện nghi 360 độ.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_clogs_2_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_clogs_2_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_clogs_2_2;
                    Add_lichsu();
                    break;


                //xangdan
                case "Dép Unisex Crocs \r\nMarbled Classic":
                    label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                        "  và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự\r\n" +
                        "  thoải mái và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                        "  đậm chất riêng bằng\r\n" +
                        "  các loại Jibbitz dành cho Dây giày thể thao.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_xangdan_2_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_xangdan_2_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_xangdan_2_2;
                    Add_lichsu();
                    break;


                //giaydexuong
                case "Balenciaga X Crocs \r\nLogo Debossed Pumps":
                    label_sanphamchinh_chitiet.Text =
                        "2 TỪ: ĐẲNG CẤP";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_giaydexuong_2_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_giaydexuong_2_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_giaydexuong_2_2;
                    Add_lichsu();
                    break;

            }
        }

        private void button_nu_3_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nu.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_3.Text;
            label_sanphamchinh_giatien.Text = label_gia_13.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                        "  và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự\r\n" +
                        "  thoải mái và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                        "  đậm chất riêng bằng\r\n" +
                        "  các loại Jibbitz dành cho Dây giày thể thao.";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_xangdan_1_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_xangdan_1_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_xangdan_1_2;
            Add_lichsu();
        }

        private void button_nu_4_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nu.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_4.Text;
            label_sanphamchinh_giatien.Text = label_gia_14.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                        "  và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự\r\n" +
                        "  thoải mái và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                        "  đậm chất riêng bằng\r\n" +
                        "  các loại Jibbitz dành cho Dây giày thể thao.";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_xangdan_2_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_xangdan_2_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_xangdan_2_2;
            Add_lichsu();
        }

        private void button_nu_5_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nu.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_5.Text;
            label_sanphamchinh_giatien.Text = label_gia_15.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Được chế tác từ Croslite™ – mang đến cảm giác êm ái,\r\n" +
                        "  siêu nhẹ và thoải mái.\r\n" +
                        "- Chất liệu dễ lau chùi và chống nước\r\n" +
                        "- Cực kỳ nhẹ và thú vị khi mang\r\n" +
                        "- Có thể trang trí sáng tạo cá tính riêng\r\n" +
                        "  với phụ kiện Jibbitz ™\r\n" +
                        "- Lớp lót sử dụng công nghệ độc quyền\r\n" +
                        "  Iconic Crocs Comfort ™: \r\n" +
                        "  Nhẹ. Linh hoạt. Tiện nghi 360";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_depquaingang_1_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_depquaingang_1_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_depquaingang_1_2;
            Add_lichsu();
        }

        private void button_nu_6_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nu.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_6.Text;
            label_sanphamchinh_giatien.Text = label_gia_16.Text;

            label_sanphamchinh_chitiet.Text =
                       "- Kiểu dáng thể thao\r\n" +
                       "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                       "  và có độ đàn hồi cao\r\n" +
                       "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                       "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại\r\n" +
                       "  sự thoải mái và hỗ trợ cả ngày\r\n" +
                       "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                       "  đậm chất riêng bằng\r\n" +
                       "  các loại Jibbitz dành cho Dây giày thể thao.";


            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_depxongon_1_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_depxongon_1_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_depxongon_1_2;
            Add_lichsu();
        }

        private void button_nu_7_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nu.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_7.Text;
            label_sanphamchinh_giatien.Text = label_gia_17.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ\r\n" +
                        "  nhẹ và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự\r\n" +
                        " thoải mái và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động\r\n" +
                        "  và đậm chất riêng bằng các loại Jibbitz\r\n" +
                        "  dành cho Dây giày thể thao.";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_giaybet_1_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_giaybet_1_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_giaybet_1_2;
            Add_lichsu();
        }

        private void button_nu_8_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nu.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_8.Text;
            label_sanphamchinh_giatien.Text = label_gia_18.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng hai dây đeo thanh lịch với dây cài\r\n" +
                        "  phần gót chân đảm bảo an toàn cho mỗi bước chân của bạn\r\n" +
                        "- Công nghệ LiteRide™ cách tân tạo cảm giác thoải mái tối ưu \r\n" +
                        "- Đế Croslite™ siêu nhẹ mang lại sự thoải mái trên mỗi bước chân \r\n" +
                        "- Quai Matlite ™ siêu mềm, linh hoạt cho cảm giác\r\n" +
                        "  dễ chịu ngay từ ngày đầu tiên\r\n" +
                        "- Gót sâu và phần đế được nâng cao nhằm nâng chiều cao và sự ổn định\r\n" +
                        "- Dây đeo với khóa cài thông minh giúp dễ dàng điều chỉnh\r\n" +
                        "- Chiều cao gót: 1.7 inches / 45mm\r\n" +
                        "- Tấm lót LiteRide™ : Mang tính cách mạng. Cực mềm và êm.";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_giaydexuong_1_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_giaydexuong_1_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_giaydexuong_1_2;
            Add_lichsu();
        }

        private void button_nu_9_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nu.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_9.Text;
            label_sanphamchinh_giatien.Text = label_gia_19.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                        "  và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự thoải mái\r\n" +
                        "  và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động và đậm chất riêng\r\n" +
                        "  bằng các loại Jibbitz dành cho Dây giày thể thao.";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_2;
            Add_lichsu();
        }

        private void button_nu_10_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nu.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_10.Text;
            label_sanphamchinh_giatien.Text = label_gia_20.Text;

            label_sanphamchinh_chitiet.Text =
                        "2 TỪ: ĐẲNG CẤP";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_giaydexuong_2_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_giaydexuong_2_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_giaydexuong_2_2;
            Add_lichsu();
        }

        private void panel_sanphamchinh_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Nam.Visible = false;
            panel_Nu.Visible = false;
        }

        private void button_phukien_1_Click(object sender, EventArgs e)
        {
            label_sanphamchinh_huongdansudung.Visible = true;
            label_sanphamchinh_huongdansudung2.Visible = true;

            button_size1.Visible = false;
            button_size2.Visible = false;
            button_size3.Visible = false;
            button_size4.Visible = false;
            button_size5.Visible = true;

            panel_sanphamchinh.Visible = true;
            panel_sanphamphukien.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_1.Text;
            label_sanphamchinh_giatien.Text = label_gia_21.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Sản phẩm này không phải là đồ chơi\r\n" +
                        "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                        "- Họa tiết: hoạt hình\r\n" +
                        "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_1_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_1_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_1_2;
            Add_lichsu();
        }

        private void button_phukien_2_Click(object sender, EventArgs e)
        {
            label_sanphamchinh_huongdansudung.Visible = true;
            label_sanphamchinh_huongdansudung2.Visible = true;

            button_size1.Visible = false;
            button_size2.Visible = false;
            button_size3.Visible = false;
            button_size4.Visible = false;
            button_size5.Visible = true;

            panel_sanphamchinh.Visible = true;
            panel_sanphamphukien.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_2.Text;
            label_sanphamchinh_giatien.Text = label_gia_22.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Sản phẩm này không phải là đồ chơi\r\n" +
                        "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                        "- Họa tiết: hoạt hình\r\n" +
                        "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_2_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_2_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_2_2;
            Add_lichsu();
        }

        private void button_phukien_3_Click(object sender, EventArgs e)
        {
            label_sanphamchinh_huongdansudung.Visible = true;
            label_sanphamchinh_huongdansudung2.Visible = true;

            button_size1.Visible = false;
            button_size2.Visible = false;
            button_size3.Visible = false;
            button_size4.Visible = false;
            button_size5.Visible = true;

            panel_sanphamchinh.Visible = true;
            panel_sanphamphukien.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_3.Text;
            label_sanphamchinh_giatien.Text = label_gia_23.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Sản phẩm này không phải là đồ chơi\r\n" +
                        "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                        "- Họa tiết: hoạt hình\r\n" +
                        "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_3_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_3_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_3_2;
            Add_lichsu();
        }

        private void button_phukien_4_Click(object sender, EventArgs e)
        {
            label_sanphamchinh_huongdansudung.Visible = true;
            label_sanphamchinh_huongdansudung2.Visible = true;

            button_size1.Visible = false;
            button_size2.Visible = false;
            button_size3.Visible = false;
            button_size4.Visible = false;
            button_size5.Visible = true;

            panel_sanphamchinh.Visible = true;
            panel_sanphamphukien.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_4.Text;
            label_sanphamchinh_giatien.Text = label_gia_24.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Sản phẩm này không phải là đồ chơi\r\n" +
                        "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                        "- Họa tiết: hoạt hình\r\n" +
                        "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_10_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_10_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_10_2;
            Add_lichsu();
        }

        private void button_phukien_5_Click(object sender, EventArgs e)
        {
            label_sanphamchinh_huongdansudung.Visible = true;
            label_sanphamchinh_huongdansudung2.Visible = true;

            button_size1.Visible = false;
            button_size2.Visible = false;
            button_size3.Visible = false;
            button_size4.Visible = false;
            button_size5.Visible = true;

            panel_sanphamchinh.Visible = true;
            panel_sanphamphukien.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_5.Text;
            label_sanphamchinh_giatien.Text = label_gia_25.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Sản phẩm này không phải là đồ chơi\r\n" +
                        "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                        "- Họa tiết: hoạt hình\r\n" +
                        "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_4_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_4_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_4_2;
            Add_lichsu();
        }

        private void button_phukien_6_Click(object sender, EventArgs e)
        {
            label_sanphamchinh_huongdansudung.Visible = true;
            label_sanphamchinh_huongdansudung2.Visible = true;

            button_size1.Visible = false;
            button_size2.Visible = false;
            button_size3.Visible = false;
            button_size4.Visible = false;
            button_size5.Visible = true;

            panel_sanphamchinh.Visible = true;
            panel_sanphamphukien.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_6.Text;
            label_sanphamchinh_giatien.Text = label_gia_26.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Sản phẩm này không phải là đồ chơi\r\n" +
                        "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                        "- Họa tiết: hoạt hình\r\n" +
                        "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_5_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_5_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_5_2;
            Add_lichsu();
        }

        private void button_phukien_7_Click(object sender, EventArgs e)
        {
            label_sanphamchinh_huongdansudung.Visible = true;
            label_sanphamchinh_huongdansudung2.Visible = true;

            button_size1.Visible = false;
            button_size2.Visible = false;
            button_size3.Visible = false;
            button_size4.Visible = false;
            button_size5.Visible = true;

            panel_sanphamchinh.Visible = true;
            panel_sanphamphukien.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_7.Text;
            label_sanphamchinh_giatien.Text = label_gia_27.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Sản phẩm này không phải là đồ chơi\r\n" +
                        "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                        "- Họa tiết: hoạt hình\r\n" +
                        "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_6_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_6_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_6_2;
            Add_lichsu();
        }

        private void button_phukien_8_Click(object sender, EventArgs e)
        {
            label_sanphamchinh_huongdansudung.Visible = true;
            label_sanphamchinh_huongdansudung2.Visible = true;

            button_size1.Visible = false;
            button_size2.Visible = false;
            button_size3.Visible = false;
            button_size4.Visible = false;
            button_size5.Visible = true;

            panel_sanphamchinh.Visible = true;
            panel_sanphamphukien.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_8.Text;
            label_sanphamchinh_giatien.Text = label_gia_28.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Sản phẩm này không phải là đồ chơi\r\n" +
                        "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                        "- Họa tiết: hoạt hình\r\n" +
                        "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_11_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_11_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_11_2;
            Add_lichsu();
        }

        private void button_phukien_9_Click(object sender, EventArgs e)
        {
            label_sanphamchinh_huongdansudung.Visible = true;
            label_sanphamchinh_huongdansudung2.Visible = true;

            button_size1.Visible = false;
            button_size2.Visible = false;
            button_size3.Visible = false;
            button_size4.Visible = false;
            button_size5.Visible = true;

            panel_sanphamchinh.Visible = true;
            panel_sanphamphukien.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_9.Text;
            label_sanphamchinh_giatien.Text = label_gia_29.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Sản phẩm này không phải là đồ chơi\r\n" +
                        "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                        "- Họa tiết: hoạt hình\r\n" +
                        "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_7_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_7_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_7_2;
            Add_lichsu();
        }

        private void button_phukien_10_Click(object sender, EventArgs e)
        {
            label_sanphamchinh_huongdansudung.Visible = true;
            label_sanphamchinh_huongdansudung2.Visible = true;

            button_size1.Visible = false;
            button_size2.Visible = false;
            button_size3.Visible = false;
            button_size4.Visible = false;
            button_size5.Visible = true;

            panel_sanphamchinh.Visible = true;
            panel_sanphamphukien.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_10.Text;
            label_sanphamchinh_giatien.Text = label_gia_30.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Sản phẩm này không phải là đồ chơi\r\n" +
                        "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                        "- Họa tiết: hoạt hình\r\n" +
                        "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_8_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_8_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_8_2;
            Add_lichsu();
        }

        private void button_phukien_11_Click(object sender, EventArgs e)
        {
            label_sanphamchinh_huongdansudung.Visible = true;
            label_sanphamchinh_huongdansudung2.Visible = true;

            button_size1.Visible = false;
            button_size2.Visible = false;
            button_size3.Visible = false;
            button_size4.Visible = false;
            button_size5.Visible = true;

            panel_sanphamchinh.Visible = true;
            panel_sanphamphukien.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_11.Text;
            label_sanphamchinh_giatien.Text = label_gia_31.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Sản phẩm này không phải là đồ chơi\r\n" +
                        "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                        "- Họa tiết: hoạt hình\r\n" +
                        "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_9_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_9_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_9_2;
            Add_lichsu();
        }

        private void button_phukien_12_Click(object sender, EventArgs e)
        {
            label_sanphamchinh_huongdansudung.Visible = true;
            label_sanphamchinh_huongdansudung2.Visible = true;

            button_size1.Visible = false;
            button_size2.Visible = false;
            button_size3.Visible = false;
            button_size4.Visible = false;
            button_size5.Visible = true;

            panel_sanphamchinh.Visible = true;
            panel_sanphamphukien.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_12.Text;
            label_sanphamchinh_giatien.Text = label_gia_32.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Sản phẩm này không phải là đồ chơi\r\n" +
                        "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                        "- Họa tiết: hoạt hình\r\n" +
                        "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_12_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_12_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_12_2;
            Add_lichsu();
        }

        private void button_main_new_1_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nam.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_3.Text;
            label_sanphamchinh_giatien.Text = label_gia_3.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Được chế tác từ Croslite™ – mang đến cảm giác êm ái,\r\n" +
                        "  siêu nhẹ và thoải mái.\r\n" +
                        "- Chất liệu dễ lau chùi và chống nước\r\n" +
                        "- Cực kỳ nhẹ và thú vị khi mang\r\n" +
                        "- Có thể trang trí sáng tạo cá tính riêng\r\n" +
                        "  với phụ kiện Jibbitz ™\r\n" +
                        "- Lớp lót sử dụng công nghệ độc quyền\r\n" +
                        "  Iconic Crocs Comfort ™: \r\n" +
                        "  Nhẹ. Linh hoạt. Tiện nghi 360";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_depquaingang_1_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_depquaingang_1_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_depquaingang_1_2;
            Add_lichsu();
        }

        private void button_main_new_2_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nu.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_7.Text;
            label_sanphamchinh_giatien.Text = label_gia_17.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ\r\n" +
                        "  nhẹ và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự\r\n" +
                        " thoải mái và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động\r\n" +
                        "  và đậm chất riêng bằng các loại Jibbitz\r\n" +
                        "  dành cho Dây giày thể thao.";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_giaybet_1_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_giaybet_1_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_giaybet_1_2;
            Add_lichsu();
        }

        private void button_main_new_3_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nam.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_8.Text;
            label_sanphamchinh_giatien.Text = label_gia_8.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                        "  và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự\r\n" +
                        "  thoải mái và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                        "  đậm chất riêng bằng\r\n" +
                        "  các loại Jibbitz dành cho Dây giày thể thao.";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_xangdan_2_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_xangdan_2_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_xangdan_2_2;
            Add_lichsu();
        }

        private void button_main_new_4_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nu.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_6.Text;
            label_sanphamchinh_giatien.Text = label_gia_16.Text;

            label_sanphamchinh_chitiet.Text =
                       "- Kiểu dáng thể thao\r\n" +
                       "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                       "  và có độ đàn hồi cao\r\n" +
                       "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                       "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại\r\n" +
                       "  sự thoải mái và hỗ trợ cả ngày\r\n" +
                       "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                       "  đậm chất riêng bằng\r\n" +
                       "  các loại Jibbitz dành cho Dây giày thể thao.";


            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_depxongon_1_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_depxongon_1_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_depxongon_1_2;
            Add_lichsu();
        }

        private void pictureBox_ads_2_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nam.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_2.Text;
            label_sanphamchinh_giatien.Text = label_gia_2.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Cực kỳ nhẹ và thoải mái\r\n" +
                        "- Chống nước\r\n" +
                        "- Thiết kế các lỗ giúp tăng độ thông thoáng,\r\n" +
                        "  chống đọng nước\r\n" +
                        "- Dễ dàng làm sạch và nhanh khô\r\n" +
                        "- Dây quai gót xoay, vừa vặn an toàn\r\n" +
                        "- Có thể kết hợp với phụ kiện Jibbitz™\r\n" +
                        "- Iconic Crocs Comfort ™: Nhẹ. Linh hoạt. Tiện nghi 360 độ.";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_clogs_2_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_clogs_2_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_clogs_2_2;
            Add_lichsu();
        }

        private void pictureBox_ads_1_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nu.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_3.Text;
            label_sanphamchinh_giatien.Text = label_gia_13.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Kiểu dáng thể thao\r\n" +
                        "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                        "  và có độ đàn hồi cao\r\n" +
                        "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                        "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự\r\n" +
                        "  thoải mái và hỗ trợ cả ngày\r\n" +
                        "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                        "  đậm chất riêng bằng\r\n" +
                        "  các loại Jibbitz dành cho Dây giày thể thao.";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_xangdan_1_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_xangdan_1_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_xangdan_1_2;
            Add_lichsu();
        }

        private void pictureBox_salemain_Click(object sender, EventArgs e)
        {
            panel_sanphamchinh.Visible = true;
            panel_sanpham_nu.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_2.Text;
            label_sanphamchinh_giatien.Text = label_gia_12.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Cực kỳ nhẹ và thoải mái\r\n" +
                        "- Chống nước\r\n" +
                        "- Thiết kế các lỗ giúp tăng độ thông thoáng,\r\n" +
                        "  chống đọng nước\r\n" +
                        "- Dễ dàng làm sạch và nhanh khô\r\n" +
                        "- Dây quai gót xoay, vừa vặn an toàn\r\n" +
                        "- Có thể kết hợp với phụ kiện Jibbitz™\r\n" +
                        "- Iconic Crocs Comfort ™: Nhẹ. Linh hoạt. Tiện nghi 360 độ.";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_clogs_2_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_clogs_2_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_clogs_2_2;
            Add_lichsu();
        }

        private void button_main_phukien1_Click(object sender, EventArgs e)
        {
            label_sanphamchinh_huongdansudung.Visible = true;
            label_sanphamchinh_huongdansudung2.Visible = true;

            button_size1.Visible = false;
            button_size2.Visible = false;
            button_size3.Visible = false;
            button_size4.Visible = false;
            button_size5.Visible = true;

            panel_sanphamchinh.Visible = true;
            panel_sanphamphukien.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_12.Text;
            label_sanphamchinh_giatien.Text = label_gia_32.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Sản phẩm này không phải là đồ chơi\r\n" +
                        "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                        "- Họa tiết: hoạt hình\r\n" +
                        "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_12_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_12_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_12_2;
            Add_lichsu();
        }

        private void button_main_phukien2_Click(object sender, EventArgs e)
        {
            label_sanphamchinh_huongdansudung.Visible = true;
            label_sanphamchinh_huongdansudung2.Visible = true;

            button_size1.Visible = false;
            button_size2.Visible = false;
            button_size3.Visible = false;
            button_size4.Visible = false;
            button_size5.Visible = true;

            panel_sanphamchinh.Visible = true;
            panel_sanphamphukien.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_8.Text;
            label_sanphamchinh_giatien.Text = label_gia_28.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Sản phẩm này không phải là đồ chơi\r\n" +
                        "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                        "- Họa tiết: hoạt hình\r\n" +
                        "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_11_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_11_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_11_2;
            Add_lichsu();
        }

        private void button_main_phukien3_Click(object sender, EventArgs e)
        {
            label_sanphamchinh_huongdansudung.Visible = true;
            label_sanphamchinh_huongdansudung2.Visible = true;

            button_size1.Visible = false;
            button_size2.Visible = false;
            button_size3.Visible = false;
            button_size4.Visible = false;
            button_size5.Visible = true;

            panel_sanphamchinh.Visible = true;
            panel_sanphamphukien.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_11.Text;
            label_sanphamchinh_giatien.Text = label_gia_31.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Sản phẩm này không phải là đồ chơi\r\n" +
                        "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                        "- Họa tiết: hoạt hình\r\n" +
                        "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_9_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_9_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_9_2;
            Add_lichsu();
        }

        private void button_main_phukien4_Click(object sender, EventArgs e)
        {
            label_sanphamchinh_huongdansudung.Visible = true;
            label_sanphamchinh_huongdansudung2.Visible = true;

            button_size1.Visible = false;
            button_size2.Visible = false;
            button_size3.Visible = false;
            button_size4.Visible = false;
            button_size5.Visible = true;

            panel_sanphamchinh.Visible = true;
            panel_sanphamphukien.Visible = false;

            label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_4.Text;
            label_sanphamchinh_giatien.Text = label_gia_24.Text;

            label_sanphamchinh_chitiet.Text =
                        "- Sản phẩm này không phải là đồ chơi\r\n" +
                        "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                        "- Họa tiết: hoạt hình\r\n" +
                        "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

            pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_10_1;
            pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_10_1;
            pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_10_2;
            Add_lichsu();
        }

        //search
        private void pictureBox_Search_Click(object sender, EventArgs e)
        {
            check_nam = check_nu = check_pk = 0;
            

            switch (comboBox_search.Text.ToLower().Replace(" ", ""))
            {
                //sanpham1
                case "giàyclogunisexcrocscrushspraydyeclassic":
                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nam.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_1.Text;
                    label_sanphamchinh_giatien.Text = label_gia_1.Text;

                    label_sanphamchinh_chitiet.Text =
                        "- Cực kỳ nhẹ và thoải mái\r\n" +
                        "- Chống nước\r\n" +
                        "- Thiết kế các lỗ giúp tăng độ thông thoáng,\r\n" +
                        "  chống đọng nước\r\n" +
                        "- Dễ dàng làm sạch và nhanh khô\r\n" +
                        "- Dây quai gót xoay, vừa vặn an toàn\r\n" +
                        "- Có thể kết hợp với phụ kiện Jibbitz™\r\n" +
                        "- Iconic Crocs Comfort ™: Nhẹ. Linh hoạt. Tiện nghi 360 độ.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_clogs_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_clogs_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_clogs_1_2;
                    Add_lichsu();
                    break;
                //sanpham2
                case "giàyclogunisexcrocspokemonclassic":
                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nam.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_2.Text;
                    label_sanphamchinh_giatien.Text = label_gia_2.Text;

                    label_sanphamchinh_chitiet.Text =
                        "- Cực kỳ nhẹ và thoải mái\r\n" +
                        "- Chống nước\r\n" +
                        "- Thiết kế các lỗ giúp tăng độ thông thoáng,\r\n" +
                        "  chống đọng nước\r\n" +
                        "- Dễ dàng làm sạch và nhanh khô\r\n" +
                        "- Dây quai gót xoay, vừa vặn an toàn\r\n" +
                        "- Có thể kết hợp với phụ kiện Jibbitz™\r\n" +
                        "- Iconic Crocs Comfort ™: Nhẹ. Linh hoạt. Tiện nghi 360 độ.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_clogs_2_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_clogs_2_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_clogs_2_2;
                    Add_lichsu();
                    break;
                //sanpham3
                case "dépquaingangunisexcrocscybernightsclassic":
                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nam.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_3.Text;
                    label_sanphamchinh_giatien.Text = label_gia_3.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Được chế tác từ Croslite™ – mang đến cảm giác êm ái,\r\n" +
                                "  siêu nhẹ và thoải mái.\r\n" +
                                "- Chất liệu dễ lau chùi và chống nước\r\n" +
                                "- Cực kỳ nhẹ và thú vị khi mang\r\n" +
                                "- Có thể trang trí sáng tạo cá tính riêng\r\n" +
                                "  với phụ kiện Jibbitz ™\r\n" +
                                "- Lớp lót sử dụng công nghệ độc quyền\r\n" +
                                "  Iconic Crocs Comfort ™: \r\n" +
                                "  Nhẹ. Linh hoạt. Tiện nghi 360";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_depquaingang_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_depquaingang_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_depquaingang_1_2;
                    Add_lichsu();
                    break;
                //sanpham4
                case "dépquaingangunisexcrocsclassic":
                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nam.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_4.Text;
                    label_sanphamchinh_giatien.Text = label_gia_4.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Được chế tác từ Croslite™ – mang đến cảm giác êm ái,\r\n" +
                                "  siêu nhẹ và thoải mái.\r\n" +
                                "- Chất liệu dễ lau chùi và chống nước\r\n" +
                                "- Cực kỳ nhẹ và thú vị khi mang\r\n" +
                                "- Có thể trang trí sáng tạo cá tính riêng\r\n" +
                                "  với phụ kiện Jibbitz ™\r\n" +
                                "- Lớp lót sử dụng công nghệ độc quyền\r\n" +
                                "  Iconic Crocs Comfort ™: \r\n" +
                                "  Nhẹ. Linh hoạt. Tiện nghi 360";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_depquaingang_2_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_depquaingang_2_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_depquaingang_2_2;
                    Add_lichsu();
                    break;
                //sanpham5
                case "giàythờitrangnamcrocspacerliteride1":
                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nam.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_6.Text;
                    label_sanphamchinh_giatien.Text = label_gia_6.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Kiểu dáng thể thao\r\n" +
                                "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                                "  và có độ đàn hồi cao\r\n" +
                                "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                                "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự thoải mái\r\n" +
                                "  và hỗ trợ cả ngày\r\n" +
                                "- Có thể trang trí đôi giày thêm sinh động và đậm chất riêng\r\n" +
                                "  bằng các loại Jibbitz dành cho Dây giày thể thao.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_2;
                    Add_lichsu();
                    break;
                //sanpham6
                case "giàythờitrangnamcrocspacerliteride2":
                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nam.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_6.Text;
                    label_sanphamchinh_giatien.Text = label_gia_6.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Kiểu dáng thể thao\r\n" +
                                "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                                "  và có độ đàn hồi cao\r\n" +
                                "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                                "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự thoải mái\r\n" +
                                "  và hỗ trợ cả ngày\r\n" +
                                "- Có thể trang trí đôi giày thêm sinh động và đậm chất riêng\r\n" +
                                "  bằng các loại Jibbitz dành cho Dây giày thể thao.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_giaythoitrang_2_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_giaythoitrang_2_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_giaythoitrang_2_2; Add_lichsu();
                    break;
                //sanpham7
                case "dépunisexcrocsspraydyeclassic":
                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nam.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_7.Text;
                    label_sanphamchinh_giatien.Text = label_gia_7.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Kiểu dáng thể thao\r\n" +
                                "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                                "  và có độ đàn hồi cao\r\n" +
                                "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                                "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự\r\n" +
                                "  thoải mái và hỗ trợ cả ngày\r\n" +
                                "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                                "  đậm chất riêng bằng\r\n" +
                                "  các loại Jibbitz dành cho Dây giày thể thao.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_xangdan_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_xangdan_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_xangdan_1_2; Add_lichsu();
                    break;
                //sanpham8
                case "dépunisexcrocsallterrainclassic":
                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nam.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_8.Text;
                    label_sanphamchinh_giatien.Text = label_gia_8.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Kiểu dáng thể thao\r\n" +
                                "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                                "  và có độ đàn hồi cao\r\n" +
                                "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                                "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự\r\n" +
                                "  thoải mái và hỗ trợ cả ngày\r\n" +
                                "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                                "  đậm chất riêng bằng\r\n" +
                                "  các loại Jibbitz dành cho Dây giày thể thao.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_xangdan_2_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_xangdan_2_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_xangdan_2_2; Add_lichsu();
                    break;
                //sanpham9
                case "dépxỏngónunisexcrocsspraydyeclassic":
                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nam.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_9.Text;
                    label_sanphamchinh_giatien.Text = label_gia_9.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Kiểu dáng thể thao\r\n" +
                                "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                                "  và có độ đàn hồi cao\r\n" +
                                "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                                "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại\r\n" +
                                "  sự thoải mái và hỗ trợ cả ngày\r\n" +
                                "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                                "  đậm chất riêng bằng\r\n" +
                                "  các loại Jibbitz dành cho Dây giày thể thao.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_xongon_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_xongon_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_xongon_1_2; Add_lichsu();
                    break;
                //sanpham10
                case "dépxỏngónunisexcrocsbayaband":
                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nam.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nam_10.Text;
                    label_sanphamchinh_giatien.Text = label_gia_10.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Kiểu dáng thể thao\r\n" +
                                "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                                "  và có độ đàn hồi cao\r\n" +
                                "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                                "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại\r\n" +
                                "  sự thoải mái và hỗ trợ cả ngày\r\n" +
                                "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                                "  đậm chất riêng bằng\r\n" +
                                "  các loại Jibbitz dành cho Dây giày thể thao.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_xongon_2_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_xongon_2_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_xongon_2_2; Add_lichsu();
                    break;

                //sanpham11
                case "giàyclogunisexcrocsliteride360":
                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nu.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_1.Text;
                    label_sanphamchinh_giatien.Text = label_gia_11.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Cực kỳ nhẹ và thoải mái\r\n" +
                                "- Chống nước\r\n" +
                                "- Thiết kế các lỗ giúp tăng độ thông thoáng,\r\n" +
                                "  chống đọng nước\r\n" +
                                "- Dễ dàng làm sạch và nhanh khô\r\n" +
                                "- Dây quai gót xoay, vừa vặn an toàn\r\n" +
                                "- Có thể kết hợp với phụ kiện Jibbitz™\r\n" +
                                "- Iconic Crocs Comfort ™: Nhẹ. Linh hoạt. Tiện nghi 360 độ.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_clogs_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_clogs_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_clogs_1_2; Add_lichsu();
                    break;

                //sanpham12
                case "giàyclogunisexcrocsstreetxclassic":
                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nu.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_2.Text;
                    label_sanphamchinh_giatien.Text = label_gia_12.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Cực kỳ nhẹ và thoải mái\r\n" +
                                "- Chống nước\r\n" +
                                "- Thiết kế các lỗ giúp tăng độ thông thoáng,\r\n" +
                                "  chống đọng nước\r\n" +
                                "- Dễ dàng làm sạch và nhanh khô\r\n" +
                                "- Dây quai gót xoay, vừa vặn an toàn\r\n" +
                                "- Có thể kết hợp với phụ kiện Jibbitz™\r\n" +
                                "- Iconic Crocs Comfort ™: Nhẹ. Linh hoạt. Tiện nghi 360 độ.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_clogs_2_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_clogs_2_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_clogs_2_2; Add_lichsu();
                    break;

                //sanpham13
                case "dépunisexcrocscozzzyclassic":
                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nu.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_3.Text;
                    label_sanphamchinh_giatien.Text = label_gia_13.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Kiểu dáng thể thao\r\n" +
                                "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                                "  và có độ đàn hồi cao\r\n" +
                                "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                                "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự\r\n" +
                                "  thoải mái và hỗ trợ cả ngày\r\n" +
                                "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                                "  đậm chất riêng bằng\r\n" +
                                "  các loại Jibbitz dành cho Dây giày thể thao.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_xangdan_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_xangdan_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_xangdan_1_2; Add_lichsu();
                    break;
                //sanpham14
                case "dépunisexcrocsmarbledclassic":

                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nu.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_4.Text;
                    label_sanphamchinh_giatien.Text = label_gia_14.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Kiểu dáng thể thao\r\n" +
                                "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                                "  và có độ đàn hồi cao\r\n" +
                                "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                                "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự\r\n" +
                                "  thoải mái và hỗ trợ cả ngày\r\n" +
                                "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                                "  đậm chất riêng bằng\r\n" +
                                "  các loại Jibbitz dành cho Dây giày thể thao.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_xangdan_2_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_xangdan_2_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_xangdan_2_2; Add_lichsu();
                    break;

                //sanpham15
                case "dépquaingangunisexcrocstie-dyeclassic":
                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nu.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_5.Text;
                    label_sanphamchinh_giatien.Text = label_gia_15.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Được chế tác từ Croslite™ – mang đến cảm giác êm ái,\r\n" +
                                "  siêu nhẹ và thoải mái.\r\n" +
                                "- Chất liệu dễ lau chùi và chống nước\r\n" +
                                "- Cực kỳ nhẹ và thú vị khi mang\r\n" +
                                "- Có thể trang trí sáng tạo cá tính riêng\r\n" +
                                "  với phụ kiện Jibbitz ™\r\n" +
                                "- Lớp lót sử dụng công nghệ độc quyền\r\n" +
                                "  Iconic Crocs Comfort ™: \r\n" +
                                "  Nhẹ. Linh hoạt. Tiện nghi 360";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_depquaingang_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_depquaingang_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_depquaingang_1_2; Add_lichsu();
                    break;

                //sanpham16
                case "dépxỏngónnữcrocstulum":

                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nu.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_6.Text;
                    label_sanphamchinh_giatien.Text = label_gia_16.Text;

                    label_sanphamchinh_chitiet.Text =
                               "- Kiểu dáng thể thao\r\n" +
                               "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                               "  và có độ đàn hồi cao\r\n" +
                               "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                               "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại\r\n" +
                               "  sự thoải mái và hỗ trợ cả ngày\r\n" +
                               "- Có thể trang trí đôi giày thêm sinh động và\r\n" +
                               "  đậm chất riêng bằng\r\n" +
                               "  các loại Jibbitz dành cho Dây giày thể thao.";


                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_depxongon_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_depxongon_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_depxongon_1_2; Add_lichsu();
                    break;

                //sanpham17
                case "giàybệtnữcrocstulum":

                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nu.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_7.Text;
                    label_sanphamchinh_giatien.Text = label_gia_17.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Kiểu dáng thể thao\r\n" +
                                "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ\r\n" +
                                "  nhẹ và có độ đàn hồi cao\r\n" +
                                "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                                "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự\r\n" +
                                " thoải mái và hỗ trợ cả ngày\r\n" +
                                "- Có thể trang trí đôi giày thêm sinh động\r\n" +
                                "  và đậm chất riêng bằng các loại Jibbitz\r\n" +
                                "  dành cho Dây giày thể thao.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_giaybet_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_giaybet_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_giaybet_1_2; Add_lichsu();
                    break;
                //sanpham18
                case "giàyđếxuồngnữcrocsbrooklyn":

                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nu.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_8.Text;
                    label_sanphamchinh_giatien.Text = label_gia_18.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Kiểu dáng hai dây đeo thanh lịch với dây cài\r\n" +
                                "  phần gót chân đảm bảo an toàn cho mỗi bước chân của bạn\r\n" +
                                "- Công nghệ LiteRide™ cách tân tạo cảm giác thoải mái tối ưu \r\n" +
                                "- Đế Croslite™ siêu nhẹ mang lại sự thoải mái trên mỗi bước chân \r\n" +
                                "- Quai Matlite ™ siêu mềm, linh hoạt cho cảm giác\r\n" +
                                "  dễ chịu ngay từ ngày đầu tiên\r\n" +
                                "- Gót sâu và phần đế được nâng cao nhằm nâng chiều cao và sự ổn định\r\n" +
                                "- Dây đeo với khóa cài thông minh giúp dễ dàng điều chỉnh\r\n" +
                                "- Chiều cao gót: 1.7 inches / 45mm\r\n" +
                                "- Tấm lót LiteRide™ : Mang tính cách mạng. Cực mềm và êm.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_giaydexuong_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_giaydexuong_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_giaydexuong_1_2; Add_lichsu();
                    break;

                //sanpham19
                case "giàythờitrangnữcrocspacerliteride360":

                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nu.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_9.Text;
                    label_sanphamchinh_giatien.Text = label_gia_19.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Kiểu dáng thể thao\r\n" +
                                "- Đệm LiteRide ™ thế hệ mới siêu mềm, cực kỳ nhẹ\r\n" +
                                "  và có độ đàn hồi cao\r\n" +
                                "- Quai giày mềm mại, co giãn linh hoạt\r\n" +
                                "- Đệm đế ngoài Croslite ™ bền bỉ, mang lại sự thoải mái\r\n" +
                                "  và hỗ trợ cả ngày\r\n" +
                                "- Có thể trang trí đôi giày thêm sinh động và đậm chất riêng\r\n" +
                                "  bằng các loại Jibbitz dành cho Dây giày thể thao.";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_2; Add_lichsu();
                    break;

                //sanpham20
                case "balenciagaxcrocslogodebossedpumps":

                    panel_sanphamchinh.Visible = true;
                    panel_sanpham_nu.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_nu_10.Text;
                    label_sanphamchinh_giatien.Text = label_gia_20.Text;

                    label_sanphamchinh_chitiet.Text =
                                "2 TỪ: ĐẲNG CẤP";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.nu_giaydexuong_2_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.nu_giaydexuong_2_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.nu_giaydexuong_2_2; Add_lichsu();
                    break;

                //sanpahm21
                case "jibbitzcharmspeppapigmummypig":

                    label_sanphamchinh_huongdansudung.Visible = true;
                    label_sanphamchinh_huongdansudung2.Visible = true;

                    button_size1.Visible = false;
                    button_size2.Visible = false;
                    button_size3.Visible = false;
                    button_size4.Visible = false;
                    button_size5.Visible = true;

                    panel_sanphamchinh.Visible = true;
                    panel_sanphamphukien.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_1.Text;
                    label_sanphamchinh_giatien.Text = label_gia_21.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Sản phẩm này không phải là đồ chơi\r\n" +
                                "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                                "- Họa tiết: hoạt hình\r\n" +
                                "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_1_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_1_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_1_2; Add_lichsu();
                    break;

                //sanpham22
                case "jibbitzcharms'mores":

                    label_sanphamchinh_huongdansudung.Visible = true;
                    label_sanphamchinh_huongdansudung2.Visible = true;

                    button_size1.Visible = false;
                    button_size2.Visible = false;
                    button_size3.Visible = false;
                    button_size4.Visible = false;
                    button_size5.Visible = true;

                    panel_sanphamchinh.Visible = true;
                    panel_sanphamphukien.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_2.Text;
                    label_sanphamchinh_giatien.Text = label_gia_22.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Sản phẩm này không phải là đồ chơi\r\n" +
                                "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                                "- Họa tiết: hoạt hình\r\n" +
                                "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_2_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_2_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_2_2; Add_lichsu();
                    break;

                //sanpham23
                case "jibbitzcharmletterd":

                    label_sanphamchinh_huongdansudung.Visible = true;
                    label_sanphamchinh_huongdansudung2.Visible = true;

                    button_size1.Visible = false;
                    button_size2.Visible = false;
                    button_size3.Visible = false;
                    button_size4.Visible = false;
                    button_size5.Visible = true;

                    panel_sanphamchinh.Visible = true;
                    panel_sanphamphukien.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_3.Text;
                    label_sanphamchinh_giatien.Text = label_gia_23.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Sản phẩm này không phải là đồ chơi\r\n" +
                                "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                                "- Họa tiết: hoạt hình\r\n" +
                                "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_3_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_3_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_3_2; Add_lichsu();
                    break;

                //sanpham24
                case "jibbitzcharmscrocsdudepinbacker":

                    label_sanphamchinh_huongdansudung.Visible = true;
                    label_sanphamchinh_huongdansudung2.Visible = true;

                    button_size1.Visible = false;
                    button_size2.Visible = false;
                    button_size3.Visible = false;
                    button_size4.Visible = false;
                    button_size5.Visible = true;

                    panel_sanphamchinh.Visible = true;
                    panel_sanphamphukien.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_4.Text;
                    label_sanphamchinh_giatien.Text = label_gia_24.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Sản phẩm này không phải là đồ chơi\r\n" +
                                "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                                "- Họa tiết: hoạt hình\r\n" +
                                "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_10_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_10_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_10_2; Add_lichsu();
                    break;
                //sanpham25
                case "jibbitzcharmletter1":

                    label_sanphamchinh_huongdansudung.Visible = true;
                    label_sanphamchinh_huongdansudung2.Visible = true;

                    button_size1.Visible = false;
                    button_size2.Visible = false;
                    button_size3.Visible = false;
                    button_size4.Visible = false;
                    button_size5.Visible = true;

                    panel_sanphamchinh.Visible = true;
                    panel_sanphamphukien.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_5.Text;
                    label_sanphamchinh_giatien.Text = label_gia_25.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Sản phẩm này không phải là đồ chơi\r\n" +
                                "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                                "- Họa tiết: hoạt hình\r\n" +
                                "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_4_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_4_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_4_2; Add_lichsu();
                    break;

                //sanpham26
                case "jibbitzcharmalien":
            
                    label_sanphamchinh_huongdansudung.Visible = true;
                    label_sanphamchinh_huongdansudung2.Visible = true;

                    button_size1.Visible = false;
                    button_size2.Visible = false;
                    button_size3.Visible = false;
                    button_size4.Visible = false;
                    button_size5.Visible = true;

                    panel_sanphamchinh.Visible = true;
                    panel_sanphamphukien.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_6.Text;
                    label_sanphamchinh_giatien.Text = label_gia_26.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Sản phẩm này không phải là đồ chơi\r\n" +
                                "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                                "- Họa tiết: hoạt hình\r\n" +
                                "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_5_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_5_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_5_2; Add_lichsu();
                    break;

                //sanpham27
                case "jibbitzcharmflowercactus":

                    label_sanphamchinh_huongdansudung.Visible = true;
                    label_sanphamchinh_huongdansudung2.Visible = true;

                    button_size1.Visible = false;
                    button_size2.Visible = false;
                    button_size3.Visible = false;
                    button_size4.Visible = false;
                    button_size5.Visible = true;

                    panel_sanphamchinh.Visible = true;
                    panel_sanphamphukien.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_7.Text;
                    label_sanphamchinh_giatien.Text = label_gia_27.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Sản phẩm này không phải là đồ chơi\r\n" +
                                "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                                "- Họa tiết: hoạt hình\r\n" +
                                "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_6_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_6_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_6_2; Add_lichsu();
                    break;

                //sanpham28
                case "jibbitzcharmtoystory":
            
                    label_sanphamchinh_huongdansudung.Visible = true;
                    label_sanphamchinh_huongdansudung2.Visible = true;

                    button_size1.Visible = false;
                    button_size2.Visible = false;
                    button_size3.Visible = false;
                    button_size4.Visible = false;
                    button_size5.Visible = true;

                    panel_sanphamchinh.Visible = true;
                    panel_sanphamphukien.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_8.Text;
                    label_sanphamchinh_giatien.Text = label_gia_28.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Sản phẩm này không phải là đồ chơi\r\n" +
                                "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                                "- Họa tiết: hoạt hình\r\n" +
                                "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_11_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_11_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_11_2; Add_lichsu();
                    break;

                //sapham29
                case "jibbitzcharmnumberonetrophy":

                    label_sanphamchinh_huongdansudung.Visible = true;
                    label_sanphamchinh_huongdansudung2.Visible = true;

                    button_size1.Visible = false;
                    button_size2.Visible = false;
                    button_size3.Visible = false;
                    button_size4.Visible = false;
                    button_size5.Visible = true;

                    panel_sanphamchinh.Visible = true;
                    panel_sanphamphukien.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_9.Text;
                    label_sanphamchinh_giatien.Text = label_gia_29.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Sản phẩm này không phải là đồ chơi\r\n" +
                                "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                                "- Họa tiết: hoạt hình\r\n" +
                                "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_7_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_7_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_7_2; Add_lichsu();
                    break;

                //sanpham30
                case "jibbitzcharmrubberducky":

                    label_sanphamchinh_huongdansudung.Visible = true;
                    label_sanphamchinh_huongdansudung2.Visible = true;

                    button_size1.Visible = false;
                    button_size2.Visible = false;
                    button_size3.Visible = false;
                    button_size4.Visible = false;
                    button_size5.Visible = true;

                    panel_sanphamchinh.Visible = true;
                    panel_sanphamphukien.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_10.Text;
                    label_sanphamchinh_giatien.Text = label_gia_30.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Sản phẩm này không phải là đồ chơi\r\n" +
                                "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                                "- Họa tiết: hoạt hình\r\n" +
                                "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_8_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_8_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_8_2; Add_lichsu();
                    break;

                //sanpham31
                case "jibbitzcharmdisneysthemandalorian":

                    label_sanphamchinh_huongdansudung.Visible = true;
                    label_sanphamchinh_huongdansudung2.Visible = true;

                    button_size1.Visible = false;
                    button_size2.Visible = false;
                    button_size3.Visible = false;
                    button_size4.Visible = false;
                    button_size5.Visible = true;

                    panel_sanphamchinh.Visible = true;
                    panel_sanphamphukien.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_11.Text;
                    label_sanphamchinh_giatien.Text = label_gia_31.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Sản phẩm này không phải là đồ chơi\r\n" +
                                "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                                "- Họa tiết: hoạt hình\r\n" +
                                "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_9_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_9_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_9_2; Add_lichsu();
                    break;
                //sanpham32
                case "jibbitzcharmspacejamcharacter":

                    label_sanphamchinh_huongdansudung.Visible = true;
                    label_sanphamchinh_huongdansudung2.Visible = true;

                    button_size1.Visible = false;
                    button_size2.Visible = false;
                    button_size3.Visible = false;
                    button_size4.Visible = false;
                    button_size5.Visible = true;

                    panel_sanphamchinh.Visible = true;
                    panel_sanphamphukien.Visible = false;

                    label_sanphamchinh_tensanpham.Text = label_sanphamchinh_tensanpham2.Text = button_phukien_12.Text;
                    label_sanphamchinh_giatien.Text = label_gia_32.Text;

                    label_sanphamchinh_chitiet.Text =
                                "- Sản phẩm này không phải là đồ chơi\r\n" +
                                "- Không dùng cho trẻ em dưới 3 tuổi\r\n" +
                                "- Họa tiết: hoạt hình\r\n" +
                                "- Công dụng: dùng để gắn lên các lỗ trên giày dép Crocs Classic\r\n";

                    pictureBox_sanphamchinh.BackgroundImage = Properties.Resources.phukien_12_1;
                    pictureBox_sanphamchinh_trai1.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage = Properties.Resources.phukien_12_1;
                    pictureBox_sanphamchinh_trai2.BackgroundImage = Properties.Resources.phukien_12_2; Add_lichsu();
                    break;

                //kocosanpham
                default:
                    MessageBox.Show("Không tìm thấy sản phẩm","Thông báo !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    break;
              
            }
            comboBox_search.Text = "";
        }



        int count_star = 0;
        //comment
        private void pictureBox_review_star5_Click(object sender, EventArgs e)
        {
            pictureBox_review_star1.BackgroundImage = Properties.Resources.star_yellow;
            pictureBox_review_star2.BackgroundImage = Properties.Resources.star_yellow;
            pictureBox_review_star3.BackgroundImage = Properties.Resources.star_yellow;
            pictureBox_review_star4.BackgroundImage = Properties.Resources.star_yellow;
            pictureBox_review_star5.BackgroundImage = Properties.Resources.star_yellow;
            count_star = 5;
        }

        private void pictureBox_review_star4_Click(object sender, EventArgs e)
        {
            pictureBox_review_star1.BackgroundImage = Properties.Resources.star_yellow;
            pictureBox_review_star2.BackgroundImage = Properties.Resources.star_yellow;
            pictureBox_review_star3.BackgroundImage = Properties.Resources.star_yellow;
            pictureBox_review_star4.BackgroundImage = Properties.Resources.star_yellow;
            pictureBox_review_star5.BackgroundImage = Properties.Resources.star_dark;
            count_star = 4;
        }

        private void pictureBox_review_star3_Click(object sender, EventArgs e)
        {
            pictureBox_review_star1.BackgroundImage = Properties.Resources.star_yellow;
            pictureBox_review_star2.BackgroundImage = Properties.Resources.star_yellow;
            pictureBox_review_star3.BackgroundImage = Properties.Resources.star_yellow;
            pictureBox_review_star4.BackgroundImage = Properties.Resources.star_dark;
            pictureBox_review_star5.BackgroundImage = Properties.Resources.star_dark;
            count_star = 3;

        }

        private void pictureBox_review_star2_Click(object sender, EventArgs e)
        {
            pictureBox_review_star1.BackgroundImage = Properties.Resources.star_yellow;
            pictureBox_review_star2.BackgroundImage = Properties.Resources.star_yellow;
            pictureBox_review_star3.BackgroundImage = Properties.Resources.star_dark;
            pictureBox_review_star4.BackgroundImage = Properties.Resources.star_dark;
            pictureBox_review_star5.BackgroundImage = Properties.Resources.star_dark;
            count_star = 2;
        }

        private void pictureBox_review_star1_Click(object sender, EventArgs e)
        {
            pictureBox_review_star1.BackgroundImage = Properties.Resources.star_yellow;
            pictureBox_review_star2.BackgroundImage = Properties.Resources.star_dark;
            pictureBox_review_star3.BackgroundImage = Properties.Resources.star_dark;
            pictureBox_review_star4.BackgroundImage = Properties.Resources.star_dark;
            pictureBox_review_star5.BackgroundImage = Properties.Resources.star_dark;
            count_star = 1;
        }

        private void label_danhgia_Click(object sender, EventArgs e)
        {
            panel_review.Visible = true;
        }

        private void pictureBox_review_return_Click(object sender, EventArgs e)
        {
            pictureBox_review_star1.BackgroundImage = Properties.Resources.star_dark;
            pictureBox_review_star2.BackgroundImage = Properties.Resources.star_dark;
            pictureBox_review_star3.BackgroundImage = Properties.Resources.star_dark;
            pictureBox_review_star4.BackgroundImage = Properties.Resources.star_dark;
            pictureBox_review_star5.BackgroundImage = Properties.Resources.star_dark;
            count_star = 0;

            textBox_review_danhgiabu.Text = "";
            textBox_review_tenbanlagi.Text = "";
            comboBox_review.Text = "";
            panel_review.Visible = false;
        }
 

        int x = 0;
        void Add_Comment()
        {
            Panel bang= new Panel();
            bang.Width = 700;
            bang.Height = 200;
            bang.Location = new Point(0,x);
            bang.BorderStyle = BorderStyle.FixedSingle;


            Label ten = new Label();
            Label loaisanpham = new Label();
            Label danhgia = new Label();
            Label sosao = new Label();

            PictureBox hinh_anh = new PictureBox();
            PictureBox ngoisao = new PictureBox();
            PictureBox user = new PictureBox();

            bang.Controls.Add(ten);
            bang.Controls.Add(loaisanpham);
            bang.Controls.Add(danhgia);
            bang.Controls.Add(sosao);
            bang.Controls.Add(ngoisao);
            bang.Controls.Add(hinh_anh);
            bang.Controls.Add(user);

            user.Location = new Point(3, 40);
            user.Width = 30;
            user.Height = 30;
            user.BackgroundImageLayout = ImageLayout.Stretch;
            user.BackgroundImage = Properties.Resources._1564535_customer_user_userphoto_account_person_icon;

            ngoisao.Location = new Point(133, 165);
            ngoisao.Width = 30;
            ngoisao.Height = 30;
            ngoisao.BackgroundImageLayout = ImageLayout.Stretch;
            ngoisao.BackgroundImage = Properties.Resources.star_yellow;


            hinh_anh.BorderStyle = BorderStyle.FixedSingle;
            hinh_anh.Location = new Point(3, 95);
            hinh_anh.BackgroundImageLayout = ImageLayout.Stretch;
            hinh_anh.Width = 100;
            hinh_anh.Height = 100;

            switch (comboBox_review.Text.ToLower().Replace(" ", ""))
            {
                //sanpham1
                case "giàyclogunisexcrocscrushspraydyeclassic":
                    hinh_anh.BackgroundImage = Properties.Resources.nam_clogs_1_1;
                    break;
                //sanpham2
                case "giàyclogunisexcrocspokemonclassic":
                    hinh_anh.BackgroundImage = Properties.Resources.nam_clogs_2_1;
                    break;
                //sanpham3
                case "dépquaingangunisexcrocscybernightsclassic":
                    hinh_anh.BackgroundImage = Properties.Resources.nam_depquaingang_1_1;
                    break;
                //sanpham4
                case "dépquaingangunisexcrocsclassic":
                    hinh_anh.BackgroundImage = Properties.Resources.nam_depquaingang_2_1;
                    break;
                //sanpham5
                case "giàythờitrangnamcrocspacerliteride1":
                    hinh_anh.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_1;
                    break;
                //sanpham6
                case "giàythờitrangnamcrocspacerliteride2":
                    hinh_anh.BackgroundImage = Properties.Resources.nam_giaythoitrang_2_1;
                    break;
                //sanpham7
                case "dépunisexcrocsspraydyeclassic":
                    hinh_anh.BackgroundImage = Properties.Resources.nam_xangdan_1_1;
                    break;
                //sanpham8
                case "dépunisexcrocsallterrainclassic":
                    hinh_anh.BackgroundImage = Properties.Resources.nam_xangdan_2_1;
                    break;
                //sanpham9
                case "dépxỏngónunisexcrocsspraydyeclassic":
                    hinh_anh.BackgroundImage = Properties.Resources.nam_xongon_1_1;
                    break;
                //sanpham10
                case "dépxỏngónunisexcrocsbayaband":
                    hinh_anh.BackgroundImage = Properties.Resources.nam_xongon_2_1;
                    break;
                //sanpham11
                case "giàyclogunisexcrocsliteride360":
                    hinh_anh.BackgroundImage = Properties.Resources.nu_clogs_1_1;
                    break;
                //sanpham12
                case "giàyclogunisexcrocsstreetxclassic":
                    hinh_anh.BackgroundImage = Properties.Resources.nu_clogs_2_1;
                    break;
                //sanpham13
                case "dépunisexcrocscozzzyclassic":
                    hinh_anh.BackgroundImage = Properties.Resources.nu_xangdan_1_1;
                    break;
                //sanpham14
                case "dépunisexcrocsmarbledclassic":
                    hinh_anh.BackgroundImage = Properties.Resources.nu_xangdan_2_1;
                    break;
                //sanpham15
                case "dépquaingangunisexcrocstie-dyeclassic":
                    hinh_anh.BackgroundImage = Properties.Resources.nu_depquaingang_1_1;
                    break;
                //sanpham16
                case "dépxỏngónnữcrocstulum":
                    hinh_anh.BackgroundImage = Properties.Resources.nu_depxongon_1_1;
                    break;
                //sanpham17
                case "giàybệtnữcrocstulum":
                    hinh_anh.BackgroundImage = Properties.Resources.nu_giaybet_1_1;
                    break;
                //sanpham18
                case "giàyđếxuồngnữcrocsbrooklyn":
                    hinh_anh.BackgroundImage = Properties.Resources.nu_giaydexuong_1_1;
                    break;
                //sanpham19
                case "giàythờitrangnữcrocspacerliteride360":
                    hinh_anh.BackgroundImage = Properties.Resources.nu_giaythoitrang_1_1;
                    break;
                //sanpham20
                case "balenciagaxcrocslogodebossedpumps":
                    hinh_anh.BackgroundImage = Properties.Resources.nu_giaydexuong_2_1;
                    break;

                //sanpahm21
                case "jibbitzcharmspeppapigmummypig":
                    hinh_anh.BackgroundImage = Properties.Resources.phukien_1_1;
                    break;
                //sanpham22
                case "jibbitzcharms'mores":
                    hinh_anh.BackgroundImage = Properties.Resources.phukien_2_1;
                    break;
                //sanpham23
                case "jibbitzcharmletterd":
                    hinh_anh.BackgroundImage = Properties.Resources.phukien_3_1;
                    break;
                //sanpham24
                case "jibbitzcharmscrocsdudepinbacker":
                    hinh_anh.BackgroundImage = Properties.Resources.phukien_10_1;
                    break;
                //sanpham25
                case "jibbitzcharmletter1":
                    hinh_anh.BackgroundImage = Properties.Resources.phukien_4_1;
                    break;
                //sanpham26
                case "jibbitzcharmalien":
                    hinh_anh.BackgroundImage = Properties.Resources.phukien_5_1;
                    break;
                //sanpham27
                case "jibbitzcharmflowercactus":
                    hinh_anh.BackgroundImage = Properties.Resources.phukien_6_1;
                    break;
                //sanpham28
                case "jibbitzcharmtoystory":
                    hinh_anh.BackgroundImage = Properties.Resources.phukien_11_1;
                    break;
                //sapham29
                case "jibbitzcharmnumberonetrophy":
                    hinh_anh.BackgroundImage = Properties.Resources.phukien_7_1;
                    break;
                //sanpham30
                case "jibbitzcharmrubberducky":
                    hinh_anh.BackgroundImage = Properties.Resources.phukien_8_1;
                    break;
                //sanpham31
                case "jibbitzcharmdisneysthemandalorian":
                    hinh_anh.BackgroundImage = Properties.Resources.phukien_9_1;
                    break;
                //sanpham32
                case "jibbitzcharmspacejamcharacter":
                    hinh_anh.BackgroundImage = Properties.Resources.phukien_12_1;
                    break;
            }

            ten.Font = new Font("UTM Avo", 12, FontStyle.Bold);
            loaisanpham.Font = new Font("UTM Avo", 8);
            danhgia.Font = new Font("UTM Avo", 10);
            sosao.Font = new Font("UTM Avo", 12, FontStyle.Bold);

            ten.Location = new Point(3, 6);
            loaisanpham.Location = new Point(40,32);
            danhgia.Location = new Point(190, 54);
            sosao.Location = new Point(109, 165);


            ten.Width = 300;
            ten.Height = 30;
            loaisanpham.Width = 200;
            loaisanpham.Height = 20;
            danhgia.Width = 500;
            danhgia.Height = 140;
            danhgia.BorderStyle = BorderStyle.FixedSingle;

            ten.Text = comboBox_review.Text;
            loaisanpham.Text = textBox_review_tenbanlagi.Text;
            danhgia.Text = textBox_review_danhgiabu.Text;
            sosao.Text = count_star.ToString();
            sosao.Width = 25;
            sosao.Height = 25;


            panel_comment.Controls.Add(bang);

            x += bang.Height;
        }

   
        private void button1_Click(object sender, EventArgs e)
        {
            Add_Comment();
            textBox_review_danhgiabu.Text = "";
            textBox_review_tenbanlagi.Text = "";
        }

        //mua hang

        private void button_sanphamchinh_themhang_Click(object sender, EventArgs e)
        {
            if(    button_size1.BackColor == Color.SpringGreen 
                && button_size2.BackColor == Color.SpringGreen 
                && button_size3.BackColor == Color.SpringGreen
                && button_size4.BackColor == Color.SpringGreen
                && button_size5.BackColor == Color.SpringGreen
                )
            {
                MessageBox.Show("Vui lòng chọn kích cỡ !", "Thêm hàng thất bại !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Add_sanpham();
                MessageBox.Show("Đã thêm 1 sản phẩm vào giỏ hàng của bạn !", "Thêm hàng thành công !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
                
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void pictureBox_Shopping_Click(object sender, EventArgs e)
        {
            panel_giohang.Visible = true ;
            panel_sanpham_nam.Visible = false;
            panel_sanpham_nu.Visible = false;
            panel_sanphamphukien.Visible = false;
            panel_review.Visible = false;
            panel_lichsu.Visible = false;
        }

        int y = 0;
        int count_hang = 0;
        int tong_tien = 0;
        List<string> hoadon = new List<string>();
        List<string> soluonghoadon = new List<string>();
        List<string> sizedep = new List<string>();
        void Add_sanpham()
        {
            count_hang++;
            Panel sanpham = new Panel();
            sanpham.BorderStyle = BorderStyle.FixedSingle;
            sanpham.Width = 650;
            sanpham.Height = 200;
            sanpham.Location = new Point(0, y);

            Label ten = new Label();
            Label kichthuoc = new Label();
            Label kichthuoc_2 = new Label();
            Label soluong = new Label();
            Label xoa = new Label();
            Label tongcong = new Label();
            Label tien = new Label();
            Label VND = new Label();

            PictureBox hinh = new PictureBox();

            NumericUpDown soluonghang = new NumericUpDown();

            ten.Width = 1000;
            ten.Height = 30;
            ten.Font = new Font("UTM Avo", 12, FontStyle.Bold);
            ten.Text = label_sanphamchinh_tensanpham.Text.Replace("\n", "").Replace("\r", "");

            ten.Location = new Point(132, 11);

            hinh.Location = new Point(9, 11);
            hinh.Width = 100;
            hinh.Height = 100;
            hinh.BackgroundImageLayout = ImageLayout.Stretch;


            switch (label_sanphamchinh_tensanpham.Text.ToLower().Replace(" ", "").Replace("\n", "").Replace("\r", ""))
            {
                //sanpham1
                case "giàyclogunisexcrocscrushspraydyeclassic":
                    hinh.BackgroundImage = Properties.Resources.nam_clogs_1_1;
                    break;
                //sanpham2
                case "giàyclogunisexcrocspokemonclassic":
                    hinh.BackgroundImage = Properties.Resources.nam_clogs_2_1;
                    break;
                //sanpham3
                case "dépquaingangunisexcrocscybernightsclassic":
                    hinh.BackgroundImage = Properties.Resources.nam_depquaingang_1_1;
                    break;
                //sanpham4
                case "dépquaingangunisexcrocsclassic":
                    hinh.BackgroundImage = Properties.Resources.nam_depquaingang_2_1;
                    break;
                //sanpham5
                case "giàythờitrangnamcrocspacerliteride1":
                    hinh.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_1;
                    break;
                //sanpham6
                case "giàythờitrangnamcrocspacerliteride2":
                    hinh.BackgroundImage = Properties.Resources.nam_giaythoitrang_2_1;
                    break;
                //sanpham7
                case "dépunisexcrocsspraydyeclassic":
                    hinh.BackgroundImage = Properties.Resources.nam_xangdan_1_1;
                    break;
                //sanpham8
                case "dépunisexcrocsallterrainclassic":
                    hinh.BackgroundImage = Properties.Resources.nam_xangdan_2_1;
                    break;
                //sanpham9
                case "dépxỏngónunisexcrocsspraydyeclassic":
                    hinh.BackgroundImage = Properties.Resources.nam_xongon_1_1;
                    break;
                //sanpham10
                case "dépxỏngónunisexcrocsbayaband":
                    hinh.BackgroundImage = Properties.Resources.nam_xongon_2_1;
                    break;
                //sanpham11
                case "giàyclogunisexcrocsliteride360":
                    hinh.BackgroundImage = Properties.Resources.nu_clogs_1_1;
                    break;
                //sanpham12
                case "giàyclogunisexcrocsstreetxclassic":
                    hinh.BackgroundImage = Properties.Resources.nu_clogs_2_1;
                    break;
                //sanpham13
                case "dépunisexcrocscozzzyclassic":
                    hinh.BackgroundImage = Properties.Resources.nu_xangdan_1_1;
                    break;
                //sanpham14
                case "dépunisexcrocsmarbledclassic":
                    hinh.BackgroundImage = Properties.Resources.nu_xangdan_2_1;
                    break;
                //sanpham15
                case "dépquaingangunisexcrocstie-dyeclassic":
                    hinh.BackgroundImage = Properties.Resources.nu_depquaingang_1_1;
                    break;
                //sanpham16
                case "dépxỏngónnữcrocstulum":
                    hinh.BackgroundImage = Properties.Resources.nu_depxongon_1_1;
                    break;
                //sanpham17
                case "giàybệtnữcrocstulum":
                    hinh.BackgroundImage = Properties.Resources.nu_giaybet_1_1;
                    break;
                //sanpham18
                case "giàyđếxuồngnữcrocsbrooklyn":
                    hinh.BackgroundImage = Properties.Resources.nu_giaydexuong_1_1;
                    break;
                //sanpham19
                case "giàythờitrangnữcrocspacerliteride360":
                    hinh.BackgroundImage = Properties.Resources.nu_giaythoitrang_1_1;
                    break;
                //sanpham20
                case "balenciagaxcrocslogodebossedpumps":
                    hinh.BackgroundImage = Properties.Resources.nu_giaydexuong_2_1;
                    break;

                //sanpahm21
                case "jibbitz™charmspeppapigmummypig":
                    hinh.BackgroundImage = Properties.Resources.phukien_1_1;
                    break;
                //sanpham22
                case "jibbitz™charms'mores":
                    hinh.BackgroundImage = Properties.Resources.phukien_2_1;
                    break;
                //sanpham23
                case "jibbitz™charmletterd":
                    hinh.BackgroundImage = Properties.Resources.phukien_3_1;
                    break;
                //sanpham24
                case "jibbitz™charmscrocsdudepinbacker":
                    hinh.BackgroundImage = Properties.Resources.phukien_10_1;
                    break;
                //sanpham25
                case "jibbitz™charmletter1":
                    hinh.BackgroundImage = Properties.Resources.phukien_4_1;
                    break;
                //sanpham26
                case "jibbitz™charmalien":
                    hinh.BackgroundImage = Properties.Resources.phukien_5_1;
                    break;
                //sanpham27
                case "jibbitz™charmflowercactus":
                    hinh.BackgroundImage = Properties.Resources.phukien_6_1;
                    break;
                //sanpham28
                case "jibbitz™charmtoystory":
                    hinh.BackgroundImage = Properties.Resources.phukien_11_1;
                    break;
                //sapham29
                case "jibbitz™charmnumberonetrophy":
                    hinh.BackgroundImage = Properties.Resources.phukien_7_1;
                    break;
                //sanpham30
                case "jibbitz™charmrubberducky":
                    hinh.BackgroundImage = Properties.Resources.phukien_8_1;
                    break;
                //sanpham31
                case "jibbitz™charmdisneysthemandalorian":
                    hinh.BackgroundImage = Properties.Resources.phukien_9_1;
                    break;
                //sanpham32
                case "jibbitz™charmspacejamcharacter":
                    hinh.BackgroundImage = Properties.Resources.phukien_12_1;
                    break;
            }

            kichthuoc.Width = 122;
            kichthuoc.Height = 27;
            kichthuoc.Font = new Font("UTM Avo", 12);
            kichthuoc.Text = "Kích thước: ";
            kichthuoc.Location = new Point(132,52);

            kichthuoc_2.Width = 150;
            kichthuoc_2.Height = 27;
            kichthuoc_2.Font = new Font("UTM Avo", 12,FontStyle.Bold);
            kichthuoc_2.Text = ten_size;
            kichthuoc_2.Location = new Point(270, 52);
            sizedep.Add(kichthuoc_2.Text);

            soluong.Width = 101;
            soluong.Height = 27;
            soluong.Font = new Font("UTM Avo", 12);
            soluong.Text = "Số lượng: ";
            soluong.Location = new Point(132, 103);

            xoa.Width = 51;
            xoa.Height = 27;
            xoa.Font = new Font("UTM Avo", 12,FontStyle.Underline);
            xoa.Text = "Xóa";
            xoa.Location = new Point(132, 166);
            

            tongcong.Width = 180;
            tongcong.Height = 27;
            tongcong.Font = new Font("UTM Avo", 12);
            tongcong.Text = "Tiền 1 sản phẩm: ";
            tongcong.Location = new Point(300, 164);

            tien.Width = 250;
            tien.Height = 30;
            tien.Font = new Font("UTM Avo", 12);
            tien.Text = label_sanphamchinh_giatien.Text;
            tien.Location = new Point(500, 164);

            tong_tien += kiemtragiatien(label_sanphamchinh_giatien.Text);
            label_giohang_tinhtien.Text = tong_tien.ToString();


            soluonghang.Font = new Font("UTM Avo",12,FontStyle.Bold);
            soluonghang.Location = new Point(260, 101);
            soluonghang.Width = 50;
            soluonghang.Height = 35;
            soluonghang.Maximum = 3;
            soluonghang.Minimum = 0;
            soluonghang.ReadOnly = true;

            hoadon.Add(ten.Text);

            int cur_val = 1;
            int a = kiemtragiatien(tien.Text);
            soluonghang.ValueChanged += (s, e) =>
            {
                int last_val = Convert.ToInt32(soluonghang.Value);
                if(cur_val == 0 && last_val == 1)
                {
                    soluonghang.Minimum = 1;
                    cur_val = 1;
                }
                if (cur_val == 1 && last_val == 2)
                {
                    tong_tien += kiemtragiatien(tien.Text);
                    cur_val = 2;
                }
                if (cur_val == 2 && last_val == 1)
                {
                    tong_tien -= kiemtragiatien(tien.Text);
                    cur_val = 1;
                }
                if (cur_val == 2 && last_val == 3)
                {
                    tong_tien += kiemtragiatien(tien.Text);
                    cur_val = 3;
                }
                if (cur_val == 3 && last_val == 2)
                {
                    tong_tien -= kiemtragiatien(tien.Text);
                    cur_val = 2;
                }
                label_giohang_tinhtien.Text = tong_tien.ToString();
                soluonghoadon.Add(cur_val.ToString());
            };
            

            VND.Width = 55;
            VND.Height = 30;
            VND.Font = new Font("UTM Avo", 12);
            VND.Text = "VNĐ";
            VND.Location = new Point(600, 164);

            sanpham.Controls.Add(ten);
            sanpham.Controls.Add(kichthuoc);
            sanpham.Controls.Add(kichthuoc_2);
            sanpham.Controls.Add(soluong);
            sanpham.Controls.Add(xoa);
            sanpham.Controls.Add(tongcong);
            sanpham.Controls.Add(tien);
            sanpham.Controls.Add(VND);
            sanpham.Controls.Add(soluonghang);
            sanpham.Controls.Add(hinh);

            
            label_giohang_tinhtien.Text = tong_tien.ToString();

            xoa.Click += (s, e) =>
            {
                y -= 200;
                tong_tien -= a * Convert.ToInt32(soluonghang.Value);
                label_giohang_tinhtien.Text = tong_tien.ToString();
                hoadon.RemoveAt(count_hang-1);
                soluonghoadon.RemoveAt(count_hang-1);
                sizedep.RemoveAt(count_hang-1);
                count_hang--;
                panel_giohang_1.Controls.Remove(sanpham);
                
            };
            panel_giohang_1.Controls.Add(sanpham);
            if (label_sanphamchinh_giatien.Text == "0")
                y = 0;
            y += 200;
        }

        int size_check_1 = 0;
        int size_check_2 = 0;
        int size_check_3 = 0;
        int size_check_4 = 0;
        int size_check_5 = 0;
        string ten_size = "";

        private void button_size1_Click(object sender, EventArgs e)
        {
            size_check_1 = 1;
            size_check_2 = 0;
            size_check_3 = 0;
            size_check_4 = 0;
            size_check_5 = 0;
            ten_size = button_size1.Text;
            button_size1.BackColor = Color.Red;
            button_size2.BackColor = Color.SpringGreen;
            button_size3.BackColor = Color.SpringGreen;
            button_size4.BackColor = Color.SpringGreen;
            button_size5.BackColor = Color.SpringGreen;

        }

        private void button_size2_Click(object sender, EventArgs e)
        {
            size_check_1 = 0;
            size_check_2 = 1;
            size_check_3 = 0;
            size_check_4 = 0;
            size_check_5 = 0;
            ten_size = button_size2.Text;
            button_size1.BackColor = Color.SpringGreen;
            button_size2.BackColor = Color.Red;
            button_size3.BackColor = Color.SpringGreen;
            button_size4.BackColor = Color.SpringGreen;
            button_size5.BackColor = Color.SpringGreen;
        }

        private void button_size3_Click(object sender, EventArgs e)
        {
            size_check_1 = 0;
            size_check_2 = 0;
            size_check_3 = 1;
            size_check_4 = 0;
            size_check_5 = 0;
            ten_size = button_size3.Text;
            button_size1.BackColor = Color.SpringGreen;
            button_size2.BackColor = Color.SpringGreen;
            button_size3.BackColor = Color.Red;
            button_size4.BackColor = Color.SpringGreen;
            button_size5.BackColor = Color.SpringGreen;
        }

        private void button_size4_Click(object sender, EventArgs e)
        {
            size_check_1 = 0;
            size_check_2 = 0;
            size_check_3 = 0;
            size_check_4 = 1;
            size_check_5 = 0;
            ten_size = button_size4.Text;
            button_size1.BackColor = Color.SpringGreen;
            button_size2.BackColor = Color.SpringGreen;
            button_size3.BackColor = Color.SpringGreen;
            button_size4.BackColor = Color.Red;
            button_size5.BackColor = Color.SpringGreen;
        }

        private void button_size5_Click(object sender, EventArgs e)
        {
            size_check_1 = 0;
            size_check_2 = 0;
            size_check_3 = 0;
            size_check_4 = 0;
            size_check_5 = 1;
            ten_size = button_size5.Text;
            button_size1.BackColor = Color.SpringGreen;
            button_size2.BackColor = Color.SpringGreen;
            button_size3.BackColor = Color.SpringGreen;
            button_size4.BackColor = Color.SpringGreen;
            button_size5.BackColor = Color.Red;
        }
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void pictureBox_giohang_return_Click(object sender, EventArgs e)
        {
            panel_giohang.Visible = false;
        }

        int kiemtragiatien(string tien)
        {
            int tienint=0;
            switch (tien)
            {
                case "200.000 VNĐ":
                    tienint = 200000;
                    break;
                case "500.000 VNĐ":
                    tienint = 500000;
                    break;
                case "1.000.000 VNĐ":
                    tienint = 1000000;
                    break;
                case "2.000.000 VNĐ":
                    tienint = 2000000;
                    break;
                case "14.000.000 VNĐ":
                    tienint = 14000000;
                    break;
            }
            return tienint;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (
                textBox_giohang_email.Text == "Email" ||
                textBox_giohang_sdt.Text == "Số điện thoại" ||
                textBox_giohang_diachi.Text == "Địa chỉ" ||
                textBox_giohang_ho.Text == "Họ" ||
                textBox_giohang_ten.Text == "Tên" ||
                textBox_giohang_tinh.Text == "Tỉnh thành" ||
                textBox_giohang_phuong.Text == "Phường/xã" ||
                textBox_giohang_quan.Text == "Quận/huyện" ||
                textBox_giohang_email.Text == "" ||
                textBox_giohang_sdt.Text == "" ||
                textBox_giohang_diachi.Text == "" ||
                textBox_giohang_ho.Text == "" ||
                textBox_giohang_ten.Text == "" ||
                textBox_giohang_tinh.Text == "" ||
                textBox_giohang_phuong.Text == "" ||
                textBox_giohang_quan.Text == ""
                )
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                if(count_hang == 0)
                    MessageBox.Show("Vui lòng chọn ít nhất 1 sản phẩm để thanh toán !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else 
                {
                    panel_hoadon.Visible = true;
                    panel_giohang.Visible = false;
                    label_hoadon_email.Text = textBox_giohang_email.Text;
                    label_hoadon_sdt.Text = textBox_giohang_sdt.Text;
                    label_hoadon_diachi.Text = textBox_giohang_diachi.Text;
                    label_hoadon_hoten.Text = textBox_giohang_ho.Text;
                    label_hoadon_hoten.Text += " " + textBox_giohang_ten.Text;
                    label_hoadon_tinh.Text = textBox_giohang_tinh.Text;
                    label_hoadon_phuong.Text = textBox_giohang_phuong.Text;
                    label_hoadon_quan.Text = textBox_giohang_quan.Text;
                    label_giohang_tong.Text = label_giohang_tinhtien.Text;
                    Add_hoadon();
                }
            }
        }

        private void textBox_giohang_email_Click(object sender, EventArgs e)
        {
            if (textBox_giohang_email.Text == "Email")
                textBox_giohang_email.Text = "";
        }

        private void textBox_giohang_ten_Click(object sender, EventArgs e)
        {
            if(textBox_giohang_ten.Text == "Tên")
                textBox_giohang_ten.Text = "";
        }

        private void textBox_giohang_ho_Click(object sender, EventArgs e)
        {
            if (textBox_giohang_ho.Text == "Họ")
                textBox_giohang_ho.Text = "";
        }

        private void textBox_giohang_diachi_Click(object sender, EventArgs e)
        {
            if (textBox_giohang_diachi.Text == "Địa chỉ")
                textBox_giohang_diachi.Text = "";
        }

        private void textBox_giohang_tinh_Click(object sender, EventArgs e)
        {
            if (textBox_giohang_tinh.Text == "Tỉnh thành")
                textBox_giohang_tinh.Text = "";
        }

        private void textBox_giohang_phuong_Click(object sender, EventArgs e)
        {
            if (textBox_giohang_phuong.Text == "Phường/Xã")
                textBox_giohang_phuong.Text = "";
        }

        private void textBox_giohang_quan_Click(object sender, EventArgs e)
        {
            if (textBox_giohang_quan.Text == "Quận/Huyện")
                textBox_giohang_quan.Text = "";
        }

        private void textBox_giohang_sdt_Click(object sender, EventArgs e)
        {
            if (textBox_giohang_sdt.Text == "Số điện thoại")
                textBox_giohang_sdt.Text = "";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            panel_hoadon.Visible = false;
        }
        int z = 0;
        void Add_hoadon()
        {
            for(int i = 0;i<count_hang;i++)
            {
                Panel hoadoncuoi = new Panel();
                hoadoncuoi.Width = 330;
                hoadoncuoi.Height = 150;
                hoadoncuoi.Location = new Point(0, z);
                hoadoncuoi.BorderStyle = BorderStyle.FixedSingle;

                Label tenhoadon = new Label();
                tenhoadon.Width = 150;
                tenhoadon.Height = 30;
                tenhoadon.Font = new Font("UTM Avo", 8, FontStyle.Bold);
                tenhoadon.Text = hoadon[i];
                tenhoadon.Location = new Point(120,0);

                Label soluong = new Label();
                soluong.Width = 100;
                soluong.Height = 30;
                soluong.Font = new Font("UTM Avo", 10);
                soluong.Text = "Số lượng: ";
                soluong.Location = new Point(120, 40);

                Label soluong_2 = new Label();
                soluong_2.Width = 150;
                soluong_2.Height = 30;
                soluong_2.Font = new Font("UTM Avo", 10, FontStyle.Bold);
                soluong_2.Text = soluonghoadon[i];
                soluong_2.Location = new Point(250, 40);

                Label kichthuoc = new Label();
                kichthuoc.Width = 80;
                kichthuoc.Height = 30;
                kichthuoc.Font = new Font("UTM Avo", 10);
                kichthuoc.Text = "Size: ";
                kichthuoc.Location = new Point(120, 80);

                Label kichthuoc_2 = new Label();
                kichthuoc_2.Width = 150;
                kichthuoc_2.Height = 30;
                kichthuoc_2.Font = new Font("UTM Avo", 10, FontStyle.Bold);
                kichthuoc_2.Text = sizedep[i];
                kichthuoc_2.Location = new Point(210, 80);

                PictureBox hinhhoadon = new PictureBox();
                hinhhoadon.Location = new Point(0, 0);
                hinhhoadon.Width = 100;
                hinhhoadon.Height = 100;
                hinhhoadon.BackgroundImageLayout = ImageLayout.Stretch;


                switch (tenhoadon.Text.ToLower().Replace(" ", "").Replace("\n", "").Replace("\r", ""))
                {
                    //sanpham1
                    case "giàyclogunisexcrocscrushspraydyeclassic":
                        hinhhoadon.BackgroundImage = Properties.Resources.nam_clogs_1_1;
                        break;
                    //sanpham2
                    case "giàyclogunisexcrocspokemonclassic":
                        hinhhoadon.BackgroundImage = Properties.Resources.nam_clogs_2_1;
                        break;
                    //sanpham3
                    case "dépquaingangunisexcrocscybernightsclassic":
                        hinhhoadon.BackgroundImage = Properties.Resources.nam_depquaingang_1_1;
                        break;
                    //sanpham4
                    case "dépquaingangunisexcrocsclassic":
                        hinhhoadon.BackgroundImage = Properties.Resources.nam_depquaingang_2_1;
                        break;
                    //sanpham5
                    case "giàythờitrangnamcrocspacerliteride1":
                        hinhhoadon.BackgroundImage = Properties.Resources.nam_giaythoitrang_1_1;
                        break;
                    //sanpham6
                    case "giàythờitrangnamcrocspacerliteride2":
                        hinhhoadon.BackgroundImage = Properties.Resources.nam_giaythoitrang_2_1;
                        break;
                    //sanpham7
                    case "dépunisexcrocsspraydyeclassic":
                        hinhhoadon.BackgroundImage = Properties.Resources.nam_xangdan_1_1;
                        break;
                    //sanpham8
                    case "dépunisexcrocsallterrainclassic":
                        hinhhoadon.BackgroundImage = Properties.Resources.nam_xangdan_2_1;
                        break;
                    //sanpham9
                    case "dépxỏngónunisexcrocsspraydyeclassic":
                        hinhhoadon.BackgroundImage = Properties.Resources.nam_xongon_1_1;
                        break;
                    //sanpham10
                    case "dépxỏngónunisexcrocsbayaband":
                        hinhhoadon.BackgroundImage = Properties.Resources.nam_xongon_2_1;
                        break;
                    //sanpham11
                    case "giàyclogunisexcrocsliteride360":
                        hinhhoadon.BackgroundImage = Properties.Resources.nu_clogs_1_1;
                        break;
                    //sanpham12
                    case "giàyclogunisexcrocsstreetxclassic":
                        hinhhoadon.BackgroundImage = Properties.Resources.nu_clogs_2_1;
                        break;
                    //sanpham13
                    case "dépunisexcrocscozzzyclassic":
                        hinhhoadon.BackgroundImage = Properties.Resources.nu_xangdan_1_1;
                        break;
                    //sanpham14
                    case "dépunisexcrocsmarbledclassic":
                        hinhhoadon.BackgroundImage = Properties.Resources.nu_xangdan_2_1;
                        break;
                    //sanpham15
                    case "dépquaingangunisexcrocstie-dyeclassic":
                        hinhhoadon.BackgroundImage = Properties.Resources.nu_depquaingang_1_1;
                        break;
                    //sanpham16
                    case "dépxỏngónnữcrocstulum":
                        hinhhoadon.BackgroundImage = Properties.Resources.nu_depxongon_1_1;
                        break;
                    //sanpham17
                    case "giàybệtnữcrocstulum":
                        hinhhoadon.BackgroundImage = Properties.Resources.nu_giaybet_1_1;
                        break;
                    //sanpham18
                    case "giàyđếxuồngnữcrocsbrooklyn":
                        hinhhoadon.BackgroundImage = Properties.Resources.nu_giaydexuong_1_1;
                        break;
                    //sanpham19
                    case "giàythờitrangnữcrocspacerliteride360":
                        hinhhoadon.BackgroundImage = Properties.Resources.nu_giaythoitrang_1_1;
                        break;
                    //sanpham20
                    case "balenciagaxcrocslogodebossedpumps":
                        hinhhoadon.BackgroundImage = Properties.Resources.nu_giaydexuong_2_1;
                        break;

                    //sanpahm21
                    case "jibbitz™charmspeppapigmummypig":
                        hinhhoadon.BackgroundImage = Properties.Resources.phukien_1_1;
                        break;
                    //sanpham22
                    case "jibbitz™charms'mores":
                        hinhhoadon.BackgroundImage = Properties.Resources.phukien_2_1;
                        break;
                    //sanpham23
                    case "jibbitz™charmletterd":
                        hinhhoadon.BackgroundImage = Properties.Resources.phukien_3_1;
                        break;
                    //sanpham24
                    case "jibbitz™charmscrocsdudepinbacker":
                        hinhhoadon.BackgroundImage = Properties.Resources.phukien_10_1;
                        break;
                    //sanpham25
                    case "jibbitz™charmletter1":
                        hinhhoadon.BackgroundImage = Properties.Resources.phukien_4_1;
                        break;
                    //sanpham26
                    case "jibbitz™charmalien":
                        hinhhoadon.BackgroundImage = Properties.Resources.phukien_5_1;
                        break;
                    //sanpham27
                    case "jibbitz™charmflowercactus":
                        hinhhoadon.BackgroundImage = Properties.Resources.phukien_6_1;
                        break;
                    //sanpham28
                    case "jibbitz™charmtoystory":
                        hinhhoadon.BackgroundImage = Properties.Resources.phukien_11_1;
                        break;
                    //sapham29
                    case "jibbitz™charmnumberonetrophy":
                        hinhhoadon.BackgroundImage = Properties.Resources.phukien_7_1;
                        break;
                    //sanpham30
                    case "jibbitz™charmrubberducky":
                        hinhhoadon.BackgroundImage = Properties.Resources.phukien_8_1;
                        break;
                    //sanpham31
                    case "jibbitz™charmdisneysthemandalorian":
                        hinhhoadon.BackgroundImage = Properties.Resources.phukien_9_1;
                        break;
                    //sanpham32
                    case "jibbitz™charmspacejamcharacter":
                        hinhhoadon.BackgroundImage = Properties.Resources.phukien_12_1;
                        break;
                }

                hoadoncuoi.Controls.Add(tenhoadon);
                hoadoncuoi.Controls.Add(soluong);
                hoadoncuoi.Controls.Add(soluong_2);
                hoadoncuoi.Controls.Add(kichthuoc);
                hoadoncuoi.Controls.Add(kichthuoc_2);
                hoadoncuoi.Controls.Add(hinhhoadon);

                panel_hoadon_sanpham.Controls.Add(hoadoncuoi);
                z += 150;
            }
            
        }

        private void pictureBox_history_Click(object sender, EventArgs e)
        {
            panel_lichsu.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panel_lichsu.Visible = false;
        }

        int hangngang_lichsu = 0;
        int hangdoc_lichsu = 0;
        void Add_lichsu()
        {
            Panel lichsu = new Panel();
            lichsu.Width = 200;
            lichsu.Height = 300;
            lichsu.Location = new Point(hangngang_lichsu, hangdoc_lichsu);
            lichsu.BorderStyle = BorderStyle.FixedSingle;
            lichsu.BackColor = Color.Bisque;
            lichsu.MouseMove += (s, e) =>
            {
                lichsu.BackColor = Color.Cyan;
            };
            lichsu.MouseLeave += (s, e) =>
            {
                lichsu.BackColor = Color.Bisque;
            };

            Label lichsu_ten = new Label();
            lichsu_ten.Width = 190;
            lichsu_ten.Height = 30;
            lichsu_ten.Font = new Font("UTM Avo", 8, FontStyle.Bold);
            lichsu_ten.Text = label_sanphamchinh_tensanpham.Text;
            lichsu_ten.Location = new Point(4, 202);

            Label lichsu_gia = new Label();
            lichsu_gia.Width = 200;
            lichsu_gia.Height = 30;
            lichsu_gia.Font = new Font("UTM Avo", 15, FontStyle.Bold);
            lichsu_gia.Text = label_sanphamchinh_giatien.Text;
            lichsu_gia.ForeColor = Color.Red;
            lichsu_gia.Location = new Point(4, 250);

            PictureBox hinhhoadon = new PictureBox();
            hinhhoadon.Location = new Point(25, 10);
            hinhhoadon.Width = 150;
            hinhhoadon.Height = 150;
            hinhhoadon.BackgroundImage = pictureBox_sanphamchinh_phai.BackgroundImage;
            hinhhoadon.BackgroundImageLayout = ImageLayout.Stretch;

            lichsu.Controls.Add(lichsu_ten);
            lichsu.Controls.Add(lichsu_gia);
            lichsu.Controls.Add(hinhhoadon);

            panel5.Controls.Add(lichsu);

            hangngang_lichsu += 300;
            if (hangngang_lichsu == 1200)
            {
                hangdoc_lichsu += 350;
                hangngang_lichsu = 0;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            panel_hoadon.Visible = true;
        }

        private void panel_giohang_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Nam.Visible = false;
            panel_Nu.Visible = false;
        }

        private void panel_comment_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Nam.Visible = false;
            panel_Nu.Visible = false;
        }

        private void panel_lichsu_MouseMove(object sender, MouseEventArgs e)
        {
            panel_Nam.Visible = false;
            panel_Nu.Visible = false;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            panel_review.Visible = true;
            panel_sanphamchinh.Visible = false;
            panel_sanpham_nam.Visible = false;
            panel_sanpham_nu.Visible = false;
            panel_sanphamphukien.Visible = false;
            panel_sanphamchinh.Visible = false;

            comboBox_review.Text = label_sanphamchinh_tensanpham.Text.Replace("\r","").Replace("\n","");
        }
    }
}
