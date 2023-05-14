namespace fileOrgProj
{
    partial class displayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(displayForm));
            this.backBtn = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            this.displayTxtBox = new System.Windows.Forms.RichTextBox();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.backBtn.Location = new System.Drawing.Point(217, 449);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(117, 55);
            this.backBtn.TabIndex = 10;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
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
            this.displayBtn.Location = new System.Drawing.Point(819, 425);
            this.displayBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(163, 65);
            this.displayBtn.TabIndex = 12;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = false;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // displayTxtBox
            // 
            this.displayTxtBox.Location = new System.Drawing.Point(159, 109);
            this.displayTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.displayTxtBox.Name = "displayTxtBox";
            this.displayTxtBox.Size = new System.Drawing.Size(823, 285);
            this.displayTxtBox.TabIndex = 13;
            this.displayTxtBox.Text = "";
            this.displayTxtBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
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
            this.menuStrip1.TabIndex = 14;
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
            // displayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.displayTxtBox);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.backBtn);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "displayForm";
            this.Text = "displayForm";
            this.Load += new System.EventHandler(this.displayForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.RichTextBox displayTxtBox;
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
    }
}