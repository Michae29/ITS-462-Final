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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Scrape_Button
            // 
            this.Scrape_Button.Location = new System.Drawing.Point(372, 326);
            this.Scrape_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Scrape_Button.Name = "Scrape_Button";
            this.Scrape_Button.Size = new System.Drawing.Size(100, 28);
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
            this.Scrape_Box.Location = new System.Drawing.Point(392, 198);
            this.Scrape_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Scrape_Box.Name = "Scrape_Box";
            this.Scrape_Box.Size = new System.Drawing.Size(160, 24);
            this.Scrape_Box.TabIndex = 1;
            this.Scrape_Box.SelectedIndexChanged += new System.EventHandler(this.Scrape_Deter_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "What information to scrape for";
            // 
            // Manufacturer
            // 
            this.Manufacturer.AutoSize = true;
            this.Manufacturer.Location = new System.Drawing.Point(212, 148);
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.Size = new System.Drawing.Size(129, 17);
            this.Manufacturer.TabIndex = 4;
            this.Manufacturer.Text = "What Manufacturer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "What Price";
            this.label2.Visible = false;
            // 
            // Price_Deter
            // 
            this.Price_Deter.FormattingEnabled = true;
            this.Price_Deter.Items.AddRange(new object[] {
            "100-400",
            "400-700",
            "700-1000",
            "1000-1300",
            "1300+"});
            this.Price_Deter.Location = new System.Drawing.Point(616, 198);
            this.Price_Deter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Price_Deter.Name = "Price_Deter";
            this.Price_Deter.Size = new System.Drawing.Size(127, 24);
            this.Price_Deter.TabIndex = 7;
            this.Price_Deter.Visible = false;
            // 
            // Manufacturer_Deter
            // 
            this.Manufacturer_Deter.FormattingEnabled = true;
            this.Manufacturer_Deter.Location = new System.Drawing.Point(224, 198);
            this.Manufacturer_Deter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Manufacturer_Deter.Name = "Manufacturer_Deter";
            this.Manufacturer_Deter.Size = new System.Drawing.Size(108, 24);
            this.Manufacturer_Deter.TabIndex = 8;
            // 
            // Item_Deter
            // 
            this.Item_Deter.FormattingEnabled = true;
            this.Item_Deter.Items.AddRange(new object[] {
            "Computer",
            "Tablet",
            "Phone"});
            this.Item_Deter.Location = new System.Drawing.Point(48, 198);
            this.Item_Deter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Item_Deter.Name = "Item_Deter";
            this.Item_Deter.Size = new System.Drawing.Size(108, 24);
            this.Item_Deter.TabIndex = 10;
            this.Item_Deter.SelectedIndexChanged += new System.EventHandler(this.Item_Deter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "What Item";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 33);
            this.button1.TabIndex = 11;
            this.button1.Text = "View Database";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 619);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Item_Deter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Manufacturer_Deter);
            this.Controls.Add(this.Price_Deter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Manufacturer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Scrape_Box);
            this.Controls.Add(this.Scrape_Button);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button button1;
    }
}

