namespace ITS_462_Final
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
            this.Back_Button = new System.Windows.Forms.Button();
            this.SaveDB = new System.Windows.Forms.Button();
            this.ScrapedData = new System.Windows.Forms.DataGridView();
            this.CDbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SaveDBDesc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScrapedData)).BeginInit();
            this.SuspendLayout();
            // 
            // Back_Button
            // 
            this.Back_Button.Location = new System.Drawing.Point(954, 513);
            this.Back_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Back_Button.Name = "Back_Button";
            this.Back_Button.Size = new System.Drawing.Size(100, 28);
            this.Back_Button.TabIndex = 0;
            this.Back_Button.Text = "Back";
            this.Back_Button.UseVisualStyleBackColor = true;
            this.Back_Button.Click += new System.EventHandler(this.Back_Button_Click);
            // 
            // SaveDB
            // 
            this.SaveDB.Location = new System.Drawing.Point(741, 35);
            this.SaveDB.Name = "SaveDB";
            this.SaveDB.Size = new System.Drawing.Size(160, 51);
            this.SaveDB.TabIndex = 2;
            this.SaveDB.Text = "Save Item Price";
            this.SaveDB.UseVisualStyleBackColor = true;
            this.SaveDB.Click += new System.EventHandler(this.SaveDB_Click);
            // 
            // ScrapedData
            // 
            this.ScrapedData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ScrapedData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScrapedData.Location = new System.Drawing.Point(12, 12);
            this.ScrapedData.Name = "ScrapedData";
            this.ScrapedData.RowHeadersWidth = 51;
            this.ScrapedData.RowTemplate.Height = 24;
            this.ScrapedData.Size = new System.Drawing.Size(608, 368);
            this.ScrapedData.TabIndex = 3;
            // 
            // CDbtn
            // 
            this.CDbtn.Location = new System.Drawing.Point(741, 327);
            this.CDbtn.Name = "CDbtn";
            this.CDbtn.Size = new System.Drawing.Size(160, 53);
            this.CDbtn.TabIndex = 4;
            this.CDbtn.Text = "Search Data";
            this.CDbtn.UseVisualStyleBackColor = true;
            this.CDbtn.Click += new System.EventHandler(this.CDbtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(741, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 49);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save Specification";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveDBDesc
            // 
            this.SaveDBDesc.Location = new System.Drawing.Point(741, 147);
            this.SaveDBDesc.Name = "SaveDBDesc";
            this.SaveDBDesc.Size = new System.Drawing.Size(160, 57);
            this.SaveDBDesc.TabIndex = 7;
            this.SaveDBDesc.Text = "Save Item Description";
            this.SaveDBDesc.UseVisualStyleBackColor = true;
            this.SaveDBDesc.Click += new System.EventHandler(this.SaveDBDesc_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.SaveDBDesc);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CDbtn);
            this.Controls.Add(this.ScrapedData);
            this.Controls.Add(this.SaveDB);
            this.Controls.Add(this.Back_Button);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScrapedData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Back_Button;
        private System.Windows.Forms.Button SaveDB;
        private System.Windows.Forms.DataGridView ScrapedData;
        private System.Windows.Forms.Button CDbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button SaveDBDesc;
    }
}