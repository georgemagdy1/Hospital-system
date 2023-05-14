namespace fileOrgProj
{
    partial class search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(search));
            this.idTxtBox = new System.Windows.Forms.RichTextBox();
            this.codeLbl = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.displayTxtBox = new System.Windows.Forms.RichTextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // idTxtBox
            // 
            this.idTxtBox.BackColor = System.Drawing.SystemColors.Info;
            this.idTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.idTxtBox.Location = new System.Drawing.Point(201, 44);
            this.idTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(413, 65);
            this.idTxtBox.TabIndex = 0;
            this.idTxtBox.Text = "";
            // 
            // codeLbl
            // 
            this.codeLbl.AutoSize = true;
            this.codeLbl.BackColor = System.Drawing.Color.Black;
            this.codeLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.codeLbl.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.codeLbl.Location = new System.Drawing.Point(88, 50);
            this.codeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codeLbl.Name = "codeLbl";
            this.codeLbl.Size = new System.Drawing.Size(78, 43);
            this.codeLbl.TabIndex = 1;
            this.codeLbl.Text = "Code";
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Black;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.searchBtn.Location = new System.Drawing.Point(736, 44);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(139, 54);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // displayTxtBox
            // 
            this.displayTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.displayTxtBox.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTxtBox.Location = new System.Drawing.Point(36, 129);
            this.displayTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayTxtBox.Name = "displayTxtBox";
            this.displayTxtBox.Size = new System.Drawing.Size(849, 230);
            this.displayTxtBox.TabIndex = 3;
            this.displayTxtBox.Text = "";
            // 
            // backBtn
            // 
            this.backBtn.AutoSize = true;
            this.backBtn.BackColor = System.Drawing.Color.Black;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.backBtn.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.backBtn.Location = new System.Drawing.Point(128, 438);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(117, 55);
            this.backBtn.TabIndex = 11;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.displayTxtBox);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.codeLbl);
            this.Controls.Add(this.idTxtBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "search";
            this.Text = "search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox idTxtBox;
        private System.Windows.Forms.Label codeLbl;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.RichTextBox displayTxtBox;
        private System.Windows.Forms.Button backBtn;
    }
}