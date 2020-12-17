namespace ITS_462_Final
{
    partial class ProductData
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
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.RadioName = new System.Windows.Forms.RadioButton();
            this.RadioPrice = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(267, 58);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(392, 22);
            this.SearchBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(325, 129);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 3;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(520, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 186);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(756, 396);
            this.textBox1.TabIndex = 5;
            // 
            // RadioName
            // 
            this.RadioName.AutoSize = true;
            this.RadioName.Location = new System.Drawing.Point(52, 59);
            this.RadioName.Name = "RadioName";
            this.RadioName.Size = new System.Drawing.Size(97, 21);
            this.RadioName.TabIndex = 7;
            this.RadioName.TabStop = true;
            this.RadioName.Text = "FInd Name";
            this.RadioName.UseVisualStyleBackColor = true;
            // 
            // RadioPrice
            // 
            this.RadioPrice.AutoSize = true;
            this.RadioPrice.Location = new System.Drawing.Point(52, 86);
            this.RadioPrice.Name = "RadioPrice";
            this.RadioPrice.Size = new System.Drawing.Size(92, 21);
            this.RadioPrice.TabIndex = 8;
            this.RadioPrice.TabStop = true;
            this.RadioPrice.Text = "Find Price";
            this.RadioPrice.UseVisualStyleBackColor = true;
            // 
            // ProductData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 636);
            this.Controls.Add(this.RadioPrice);
            this.Controls.Add(this.RadioName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchBox);
            this.Name = "ProductData";
            this.Text = "ProductData";
            this.Load += new System.EventHandler(this.ProductData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton RadioName;
        private System.Windows.Forms.RadioButton RadioPrice;
    }
}