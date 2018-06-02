namespace Add_Product_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.header = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.date_box = new System.Windows.Forms.TextBox();
            this.date_label = new System.Windows.Forms.Label();
            this.price_box = new System.Windows.Forms.TextBox();
            this.price_label = new System.Windows.Forms.Label();
            this.category_label = new System.Windows.Forms.Label();
            this.weight_box = new System.Windows.Forms.TextBox();
            this.weight_label = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.goods_box = new System.Windows.Forms.ComboBox();
            this.label = new System.Windows.Forms.Label();
            this.count_of_product = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.Location = new System.Drawing.Point(258, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(204, 45);
            this.header.TabIndex = 0;
            this.header.Text = "Add Product";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Calibri", 11F);
            this.name_label.Location = new System.Drawing.Point(12, 81);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(49, 18);
            this.name_label.TabIndex = 1;
            this.name_label.Text = "Name:";
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(86, 81);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(178, 20);
            this.name_box.TabIndex = 2;
            // 
            // date_box
            // 
            this.date_box.Location = new System.Drawing.Point(86, 219);
            this.date_box.Name = "date_box";
            this.date_box.Size = new System.Drawing.Size(178, 20);
            this.date_box.TabIndex = 4;
            // 
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("Calibri", 11F);
            this.date_label.Location = new System.Drawing.Point(12, 221);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(44, 18);
            this.date_label.TabIndex = 3;
            this.date_label.Text = " Date:";
            // 
            // price_box
            // 
            this.price_box.Location = new System.Drawing.Point(85, 270);
            this.price_box.Name = "price_box";
            this.price_box.Size = new System.Drawing.Size(178, 20);
            this.price_box.TabIndex = 6;
            // 
            // price_label
            // 
            this.price_label.AutoSize = true;
            this.price_label.Font = new System.Drawing.Font("Calibri", 11F);
            this.price_label.Location = new System.Drawing.Point(13, 270);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(43, 18);
            this.price_label.TabIndex = 5;
            this.price_label.Text = "Price:";
            // 
            // category_label
            // 
            this.category_label.AutoSize = true;
            this.category_label.Font = new System.Drawing.Font("Calibri", 11F);
            this.category_label.Location = new System.Drawing.Point(12, 166);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(67, 18);
            this.category_label.TabIndex = 7;
            this.category_label.Text = "Category:";
            // 
            // weight_box
            // 
            this.weight_box.Location = new System.Drawing.Point(86, 122);
            this.weight_box.Name = "weight_box";
            this.weight_box.Size = new System.Drawing.Size(178, 20);
            this.weight_box.TabIndex = 10;
            // 
            // weight_label
            // 
            this.weight_label.AutoSize = true;
            this.weight_label.Font = new System.Drawing.Font("Calibri", 11F);
            this.weight_label.Location = new System.Drawing.Point(12, 124);
            this.weight_label.Name = "weight_label";
            this.weight_label.Size = new System.Drawing.Size(52, 18);
            this.weight_label.TabIndex = 9;
            this.weight_label.Text = "Weight";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(61, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 38);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Product";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // goods_box
            // 
            this.goods_box.FormattingEnabled = true;
            this.goods_box.Items.AddRange(new object[] {
            "Meet",
            "Sweet",
            "Vegetable"});
            this.goods_box.Location = new System.Drawing.Point(85, 166);
            this.goods_box.Name = "goods_box";
            this.goods_box.Size = new System.Drawing.Size(179, 21);
            this.goods_box.TabIndex = 17;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(372, 88);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(139, 13);
            this.label.TabIndex = 18;
            this.label.Text = "Count Of Products in Stock:";
            // 
            // count_of_product
            // 
            this.count_of_product.AutoSize = true;
            this.count_of_product.Location = new System.Drawing.Point(518, 88);
            this.count_of_product.Name = "count_of_product";
            this.count_of_product.Size = new System.Drawing.Size(0, 13);
            this.count_of_product.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(594, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.count_of_product);
            this.Controls.Add(this.label);
            this.Controls.Add(this.goods_box);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.weight_box);
            this.Controls.Add(this.weight_label);
            this.Controls.Add(this.category_label);
            this.Controls.Add(this.price_box);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.date_box);
            this.Controls.Add(this.date_label);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.header);
            this.Name = "Form1";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.TextBox date_box;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.TextBox price_box;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.TextBox weight_box;
        private System.Windows.Forms.Label weight_label;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox goods_box;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label count_of_product;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

