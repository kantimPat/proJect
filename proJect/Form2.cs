using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proJect
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string size;
        int price;
        int count;
        int total;
        //มีชื่อ อ็อบเจ็คเดียวกันกับ Form1 แต่เป็นคนละตัวกัน
        Products products = new Products();
        CSV csv = new CSV();    
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Buy_picture_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            //ปิดหน้า Form2 
        }

        private void buy_Click(object sender, EventArgs e)
        {
            total = price * count;
            string content = "คูณได้ทำการสั่งซื่อ " + Name_product.Text + "\nไซส์ " + size + " ราคารวม " + total.ToString("C0") + " สั่งซื้อเรียบร้อยแล้ว";
            
            MessageBox.Show(content, "สั่งซื้อสำเร็จ");

            bool write = csv.CSVfile(Name_product.Text , count , total);
            if (write)
            {
                MessageBox.Show("เขียนไฟล์สำเร็จ");
            }
            else
            {
                MessageBox.Show("เขียนไฟล์ไม่สำเร็จ");

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            size = "6";
            price = products.price[0];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            size = "6.5";
            price = products.price[1] ;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            size = "7";
            price = products.price[2];

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            size = "7.5";
            price = products.price[3] ;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            size = "8";
            price = products.price[4] ;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            size = "8.5";
            price = products.price[5] ;
        }

        private void countBuy_ValueChanged(object sender, EventArgs e)
        {
            count = (int)countBuy.Value; 
        }
    }
}
