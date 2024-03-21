namespace proJect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            all_text();
        }

        Products products = new Products();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void all_text()
        {
            //ฟังก์ชันซ่อนข้อความทุก label
            la_Chicago.Visible = false;
            la_Indigo.Visible = false;
            la_CaCao.Visible = false;
            la_JDsmoke.Visible = false;
            la_JDretro.Visible = false;

        }

        private void Chicago_Click(object sender, EventArgs e)
        {
            all_text();
            la_Chicago.Visible = true;
        }

        private void bt_Indigo_Click(object sender, EventArgs e)
        {
            all_text();
            la_Indigo.Visible = true;
        }

        private void bt_Cacao_Click(object sender, EventArgs e)
        {
            all_text();
            la_CaCao.Visible = true;


        }

        private void bt_JDsmoke_Click(object sender, EventArgs e)
        {
            all_text();
            la_JDsmoke.Visible = true;

        }

        private void bt_JDretro_Click(object sender, EventArgs e)
        {
            all_text();
            la_JDretro.Visible = true;

        }

        private void bt_byChicago_Click(object sender, EventArgs e)
        {
            //form2 สร้างไว้ข้างในตอนเรียกใช้ฟังก์ชัน (คลิกปุ่มซื้อ) เพราะเคยสร้างไว้ข้างนอกแล้ว error
            Form2 form2 = new Form2();
            form2.Show();
            form2.Buy_picture.Image = products.imageProducts[0];
            form2.Name_product.Text = products.Chicago;
        }

        private void bt_byIndigo_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.Buy_picture.Image = products.imageProducts[1];
            form2.Name_product.Text = products.Indigo;
        }

        private void bt_byCacao_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.Buy_picture.Image = products.imageProducts[2];
            form2.Name_product.Text = products.Cacao;
        }

        private void bt_byJDsmoke_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.Buy_picture.Image = products.imageProducts[3];
            form2.Name_product.Text = products.one_High;
        }

        private void bt_byJDretro_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            form2.Buy_picture.Image = products.imageProducts[4];
            form2.Name_product.Text = products.one_Retro;
        }

        private void la_Chicago_Click(object sender, EventArgs e)
        {

        }
    }
}
