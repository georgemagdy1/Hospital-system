namespace fileOrgProj
{
    partial class searchBtn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchBtn));
            this.idTxtBox = new System.Windows.Forms.RichTextBox();
            this.ageTxtBox = new System.Windows.Forms.RichTextBox();
            this.phoneTxtBox = new System.Windows.Forms.RichTextBox();
            this.nameTxtBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.Patientmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.addPatientBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.delPatientBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.modifyPatientBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.displayPatientBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPatientBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.displayBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileNameTxtBox2 = new System.Windows.Forms.RichTextBox();
            this.patientNAmeLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.patientAgeLbl = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // idTxtBox
            // 
            this.idTxtBox.BackColor = System.Drawing.SystemColors.Info;
            this.idTxtBox.Location = new System.Drawing.Point(291, 154);
            this.idTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(437, 48);
            this.idTxtBox.TabIndex = 3;
            this.idTxtBox.Text = "";
            this.idTxtBox.TextChanged += new System.EventHandler(this.richTextBox2_TextChanged);
            // 
            // ageTxtBox
            // 
            this.ageTxtBox.BackColor = System.Drawing.SystemColors.Info;
            this.ageTxtBox.Location = new System.Drawing.Point(291, 389);
            this.ageTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ageTxtBox.Name = "ageTxtBox";
            this.ageTxtBox.Size = new System.Drawing.Size(437, 48);
            this.ageTxtBox.TabIndex = 4;
            this.ageTxtBox.Text = "";
            // 
            // phoneTxtBox
            // 
            this.phoneTxtBox.BackColor = System.Drawing.SystemColors.Info;
            this.phoneTxtBox.Location = new System.Drawing.Point(291, 312);
            this.phoneTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneTxtBox.Name = "phoneTxtBox";
            this.phoneTxtBox.Size = new System.Drawing.Size(437, 48);
            this.phoneTxtBox.TabIndex = 5;
            this.phoneTxtBox.Text = "";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.BackColor = System.Drawing.SystemColors.Info;
            this.nameTxtBox.Location = new System.Drawing.Point(291, 230);
            this.nameTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(437, 48);
            this.nameTxtBox.TabIndex = 6;
            this.nameTxtBox.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.Patientmenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 51);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewFileToolStripMenuItem,
            this.delFileToolStripMenuItem,
            this.exitBtn});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Image = global::fileOrgProj.Properties.Resources.fileIcon;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(93, 47);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createNewFileToolStripMenuItem
            // 
            this.createNewFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("createNewFileToolStripMenuItem.Image")));
            this.createNewFileToolStripMenuItem.Name = "createNewFileToolStripMenuItem";
            this.createNewFileToolStripMenuItem.Size = new System.Drawing.Size(312, 48);
            this.createNewFileToolStripMenuItem.Text = "Create New File ";
            // 
            // delFileToolStripMenuItem
            // 
            this.delFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("delFileToolStripMenuItem.Image")));
            this.delFileToolStripMenuItem.Name = "delFileToolStripMenuItem";
            this.delFileToolStripMenuItem.Size = new System.Drawing.Size(312, 48);
            this.delFileToolStripMenuItem.Text = "Del File";
            // 
            // exitBtn
            // 
            this.exitBtn.Image = ((System.Drawing.Image)(resources.GetObject("exitBtn.Image")));
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(312, 48);
            this.exitBtn.Text = "Exit";
            // 
            // Patientmenu
            // 
            this.Patientmenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPatientBtn,
            this.delPatientBtn,
            this.modifyPatientBtn,
            this.displayPatientBtn,
            this.searchPatientBtn});
            this.Patientmenu.Image = ((System.Drawing.Image)(resources.GetObject("Patientmenu.Image")));
            this.Patientmenu.Name = "Patientmenu";
            this.Patientmenu.Size = new System.Drawing.Size(141, 47);
            this.Patientmenu.Text = "Patient";
            // 
            // addPatientBtn
            // 
            this.addPatientBtn.Image = ((System.Drawing.Image)(resources.GetObject("addPatientBtn.Image")));
            this.addPatientBtn.Name = "addPatientBtn";
            this.addPatientBtn.Size = new System.Drawing.Size(359, 48);
            this.addPatientBtn.Text = "Add Patient";
            // 
            // delPatientBtn
            // 
            this.delPatientBtn.Image = ((System.Drawing.Image)(resources.GetObject("delPatientBtn.Image")));
            this.delPatientBtn.Name = "delPatientBtn";
            this.delPatientBtn.Size = new System.Drawing.Size(359, 48);
            this.delPatientBtn.Text = "Del Patient";
            // 
            // modifyPatientBtn
            // 
            this.modifyPatientBtn.Image = ((System.Drawing.Image)(resources.GetObject("modifyPatientBtn.Image")));
            this.modifyPatientBtn.Name = "modifyPatientBtn";
            this.modifyPatientBtn.Size = new System.Drawing.Size(359, 48);
            this.modifyPatientBtn.Text = "Modify Patient Info";
            // 
            // displayPatientBtn
            // 
            this.displayPatientBtn.Image = global::fileOrgProj.Properties.Resources.displayIcon;
            this.displayPatientBtn.Name = "displayPatientBtn";
            this.displayPatientBtn.Size = new System.Drawing.Size(359, 48);
            this.displayPatientBtn.Text = "Display All Patients ";
            // 
            // searchPatientBtn
            // 
            this.searchPatientBtn.Image = global::fileOrgProj.Properties.Resources.search;
            this.searchPatientBtn.Name = "searchPatientBtn";
            this.searchPatientBtn.Size = new System.Drawing.Size(359, 48);
            this.searchPatientBtn.Text = "SearchFor Patient";
            // 
            // displayBtn
            // 
            this.displayBtn.BackColor = System.Drawing.Color.Black;
            this.displayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.displayBtn.CausesValidation = false;
            this.displayBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.displayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.displayBtn.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBtn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.displayBtn.Location = new System.Drawing.Point(781, 452);
            this.displayBtn.Margin = new System.Windows.Forms.Padding(4);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(163, 65);
            this.displayBtn.TabIndex = 13;
            this.displayBtn.Text = "update";
            this.displayBtn.UseVisualStyleBackColor = false;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
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
            this.backBtn.Location = new System.Drawing.Point(226, 462);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(117, 55);
            this.backBtn.TabIndex = 14;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(68, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 47);
            this.label1.TabIndex = 15;
            this.label1.Text = "File Name";
            // 
            // fileNameTxtBox2
            // 
            this.fileNameTxtBox2.BackColor = System.Drawing.SystemColors.Info;
            this.fileNameTxtBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fileNameTxtBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameTxtBox2.Location = new System.Drawing.Point(291, 67);
            this.fileNameTxtBox2.Margin = new System.Windows.Forms.Padding(4);
            this.fileNameTxtBox2.Name = "fileNameTxtBox2";
            this.fileNameTxtBox2.Size = new System.Drawing.Size(368, 53);
            this.fileNameTxtBox2.TabIndex = 16;
            this.fileNameTxtBox2.Text = "";
            // 
            // patientNAmeLbl
            // 
            this.patientNAmeLbl.AutoSize = true;
            this.patientNAmeLbl.BackColor = System.Drawing.Color.Black;
            this.patientNAmeLbl.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNAmeLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.patientNAmeLbl.Location = new System.Drawing.Point(125, 231);
            this.patientNAmeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientNAmeLbl.Name = "patientNAmeLbl";
            this.patientNAmeLbl.Size = new System.Drawing.Size(99, 47);
            this.patientNAmeLbl.TabIndex = 17;
            this.patientNAmeLbl.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(113, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 47);
            this.label2.TabIndex = 18;
            this.label2.Text = "Code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(96, 312);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 47);
            this.label4.TabIndex = 19;
            this.label4.Text = "Phone";
            // 
            // patientAgeLbl
            // 
            this.patientAgeLbl.AutoSize = true;
            this.patientAgeLbl.BackColor = System.Drawing.Color.Black;
            this.patientAgeLbl.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientAgeLbl.ForeColor = System.Drawing.SystemColors.Control;
            this.patientAgeLbl.Location = new System.Drawing.Point(125, 389);
            this.patientAgeLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientAgeLbl.Name = "patientAgeLbl";
            this.patientAgeLbl.Size = new System.Drawing.Size(70, 47);
            this.patientAgeLbl.TabIndex = 20;
            this.patientAgeLbl.Text = "Age";
            // 
            // searchBtn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.patientAgeLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patientNAmeLbl);
            this.Controls.Add(this.fileNameTxtBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.phoneTxtBox);
            this.Controls.Add(this.ageTxtBox);
            this.Controls.Add(this.idTxtBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "searchBtn";
            this.Text = "modify";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox idTxtBox;
        private System.Windows.Forms.RichTextBox ageTxtBox;
        private System.Windows.Forms.RichTextBox phoneTxtBox;
        private System.Windows.Forms.RichTextBox nameTxtBox;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitBtn;
        public System.Windows.Forms.ToolStripMenuItem Patientmenu;
        private System.Windows.Forms.ToolStripMenuItem addPatientBtn;
        private System.Windows.Forms.ToolStripMenuItem delPatientBtn;
        private System.Windows.Forms.ToolStripMenuItem modifyPatientBtn;
        private System.Windows.Forms.ToolStripMenuItem displayPatientBtn;
        private System.Windows.Forms.ToolStripMenuItem searchPatientBtn;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox fileNameTxtBox2;
        private System.Windows.Forms.Label patientNAmeLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label patientAgeLbl;
    }
}