namespace ITS_462_Final
{
    partial class Main
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
            this.Scrape_Button = new System.Windows.Forms.Button();
            this.Scrape_Box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Manufacturer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Price_Deter = new System.Windows.Forms.ComboBox();
            this.Manufacturer_Deter = new System.Windows.Forms.ComboBox();
            this.Item_Deter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Scrape_Button
            // 
            this.Scrape_Button.Location = new System.Drawing.Point(279, 265);
            this.Scrape_Button.Name = "Scrape_Button";
            this.Scrape_Button.Size = new System.Drawing.Size(75, 23);
            this.Scrape_Button.TabIndex = 0;
            this.Scrape_Button.Text = "Run Scrape";
            this.Scrape_Button.UseVisualStyleBackColor = true;
            this.Scrape_Button.Click += new System.EventHandler(this.Scrape_Button_Click);
            // 
            // Scrape_Box
            // 
            this.Scrape_Box.FormattingEnabled = true;
            this.Scrape_Box.Items.AddRange(new object[] {
            "Product Description",
            "Product Specifications",
            "Price"});
            this.Scrape_Box.Location = new System.Drawing.Point(294, 161);
            this.Scrape_Box.Name = "Scrape_Box";
            this.Scrape_Box.Size = new System.Drawing.Size(121, 21);
            this.Scrape_Box.TabIndex = 1;
            this.Scrape_Box.SelectedIndexChanged += new System.EventHandler(this.Scrape_Deter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "What information to scrape for";
            // 
            // Manufacturer
            // 
            this.Manufacturer.AutoSize = true;
            this.Manufacturer.Location = new System.Drawing.Point(159, 120);
            this.Manufacturer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(99, 13);
            this.Manufacturer.TabIndex = 4;
            this.Manufacturer.Text = "What Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "What Price";
            this.label2.Visible = false;
            // 
            // Price_Deter
            // 
            this.Price_Deter.FormattingEnabled = true;
            this.Price_Deter.Items.AddRange(new object[] {
            "100-200",
            "200-300",
            "300-400",
            "400-500",
            "500+"});
            this.Price_Deter.Location = new System.Drawing.Point(462, 161);
            this.Price_Deter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Price_Deter.Name = "Price_Deter";
            this.Price_Deter.Size = new System.Drawing.Size(96, 21);
            this.Price_Deter.TabIndex = 7;
            this.Price_Deter.Visible = false;
            // 
            // Manufacturer_Deter
            // 
            this.Manufacturer_Deter.FormattingEnabled = true;
            this.Manufacturer_Deter.Location = new System.Drawing.Point(168, 161);
            this.Manufacturer_Deter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Manufacturer_Deter.Name = "Manufacturer_Deter";
            this.Manufacturer_Deter.Size = new System.Drawing.Size(82, 21);
            this.Manufacturer_Deter.TabIndex = 8;
            // 
            // Item_Deter
            // 
            this.Item_Deter.FormattingEnabled = true;
            this.Item_Deter.Items.AddRange(new object[] {
            "Computer",
            "Tablet",
            "Phone"});
            this.Item_Deter.Location = new System.Drawing.Point(36, 161);
            this.Item_Deter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Item_Deter.Name = "Item_Deter";
            this.Item_Deter.Size = new System.Drawing.Size(82, 21);
            this.Item_Deter.TabIndex = 10;
            this.Item_Deter.SelectedIndexChanged += new System.EventHandler(this.Item_Deter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "What Item";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 503);
            this.Controls.Add(this.Item_Deter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Manufacturer_Deter);
            this.Controls.Add(this.Price_Deter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Manufacturer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Scrape_Box);
            this.Controls.Add(this.Scrape_Button);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Scrape_Button;
        private System.Windows.Forms.ComboBox Scrape_Box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Manufacturer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Price_Deter;
        private System.Windows.Forms.ComboBox Manufacturer_Deter;
        private System.Windows.Forms.ComboBox Item_Deter;
        private System.Windows.Forms.Label label3;
    }
}

