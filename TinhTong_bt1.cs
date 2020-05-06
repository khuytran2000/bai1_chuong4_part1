using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong4_part1
{
    public partial class TinhTong_bt1 : Form
    {
        public TinhTong_bt1()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
               (e.KeyChar == '-') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
               (e.KeyChar == '-') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else e.Handled = true;
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            if (txtA.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập a");
                txtA.Focus();
                return;
            }
            if (txtB.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập b");
                txtB.Focus();
                return;
            }

            int tong = 0;
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text);

            
            if (a < b)
            {

                for (int i = a; i < b; i++)
                {
                    tong += i;
                }
                 label1.Text = tong.ToString();
            }
            else
            {
                for(int i = b; i < a; i++)
                {
                    tong = tong + i;
                }
                label1.Text = tong.ToString();
            }
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

   

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            label1.Text = "";
            txtA.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
