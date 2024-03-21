namespace proJect
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            Size = new Label();
            Buy_picture = new PictureBox();
            back = new Button();
            countBuy = new NumericUpDown();
            label1 = new Label();
            buy = new Button();
            Name_product = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Buy_picture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countBuy).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Size_6_5;
            pictureBox1.Location = new Point(829, 207);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 124);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(698, 207);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 124);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(960, 207);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 124);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(698, 337);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(125, 124);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(829, 337);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(125, 124);
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(960, 337);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(125, 124);
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // Size
            // 
            Size.AutoSize = true;
            Size.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Size.ForeColor = Color.Fuchsia;
            Size.Location = new Point(698, 139);
            Size.Name = "Size";
            Size.Size = new Size(81, 37);
            Size.TabIndex = 1;
            Size.Text = "Size";
            Size.Click += label1_Click;
            // 
            // Buy_picture
            // 
            Buy_picture.Image = Properties.Resources.สกรีนช็อต_2024_03_09_153018;
            Buy_picture.Location = new Point(194, 87);
            Buy_picture.Name = "Buy_picture";
            Buy_picture.Size = new Size(485, 374);
            Buy_picture.SizeMode = PictureBoxSizeMode.StretchImage;
            Buy_picture.TabIndex = 2;
            Buy_picture.TabStop = false;
            Buy_picture.Click += Buy_picture_Click;
            // 
            // back
            // 
            back.ForeColor = Color.Fuchsia;
            back.Location = new Point(39, 594);
            back.Name = "back";
            back.Size = new Size(94, 46);
            back.TabIndex = 3;
            back.Text = "<- ย้อนกลับ";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // countBuy
            // 
            countBuy.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            countBuy.Location = new Point(935, 477);
            countBuy.Name = "countBuy";
            countBuy.Size = new Size(150, 34);
            countBuy.TabIndex = 4;
            countBuy.ValueChanged += countBuy_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(754, 486);
            label1.Name = "label1";
            label1.Size = new Size(175, 25);
            label1.TabIndex = 5;
            label1.Text = "กรุณาเลือกจำนวนสินค้า";
            // 
            // buy
            // 
            buy.BackColor = Color.FromArgb(192, 255, 192);
            buy.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buy.ForeColor = Color.FromArgb(0, 192, 0);
            buy.Location = new Point(1006, 517);
            buy.Name = "buy";
            buy.Size = new Size(79, 44);
            buy.TabIndex = 6;
            buy.Text = "สั่งซื้อ";
            buy.UseVisualStyleBackColor = false;
            buy.Click += buy_Click;
            // 
            // Name_product
            // 
            Name_product.AutoSize = true;
            Name_product.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name_product.ForeColor = Color.Fuchsia;
            Name_product.Location = new Point(299, 38);
            Name_product.Name = "Name_product";
            Name_product.Size = new Size(265, 46);
            Name_product.TabIndex = 5;
            Name_product.Text = "Name products";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(1468, 718);
            Controls.Add(buy);
            Controls.Add(Name_product);
            Controls.Add(label1);
            Controls.Add(countBuy);
            Controls.Add(back);
            Controls.Add(Buy_picture);
            Controls.Add(Size);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)Buy_picture).EndInit();
            ((System.ComponentModel.ISupportInitialize)countBuy).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label Size;
        public PictureBox Buy_picture;
        private Button back;
        private NumericUpDown countBuy;
        private Label label1;
        private Button buy;
        public Label Name_product;
    }
}