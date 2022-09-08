namespace letsPractice
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newRoutineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dIsplayTeacherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dIsplayStudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sadaToolStripMenuItem,
            this.manageTeacherToolStripMenuItem,
            this.manageStudentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1104, 34);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // sadaToolStripMenuItem
            // 
            this.sadaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRoutineToolStripMenuItem,
            this.displayToolStripMenuItem});
            this.sadaToolStripMenuItem.Name = "sadaToolStripMenuItem";
            this.sadaToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.sadaToolStripMenuItem.Text = "Manage Routine";
            // 
            // newRoutineToolStripMenuItem
            // 
            this.newRoutineToolStripMenuItem.Name = "newRoutineToolStripMenuItem";
            this.newRoutineToolStripMenuItem.Size = new System.Drawing.Size(223, 30);
            this.newRoutineToolStripMenuItem.Text = "New Routine";
            // 
            // displayToolStripMenuItem
            // 
            this.displayToolStripMenuItem.Name = "displayToolStripMenuItem";
            this.displayToolStripMenuItem.Size = new System.Drawing.Size(223, 30);
            this.displayToolStripMenuItem.Text = "Display";
            // 
            // manageTeacherToolStripMenuItem
            // 
            this.manageTeacherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTeacherToolStripMenuItem,
            this.dIsplayTeacherToolStripMenuItem});
            this.manageTeacherToolStripMenuItem.Name = "manageTeacherToolStripMenuItem";
            this.manageTeacherToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.manageTeacherToolStripMenuItem.Text = "Manage Teacher";
            // 
            // newTeacherToolStripMenuItem
            // 
            this.newTeacherToolStripMenuItem.Name = "newTeacherToolStripMenuItem";
            this.newTeacherToolStripMenuItem.Size = new System.Drawing.Size(255, 30);
            this.newTeacherToolStripMenuItem.Text = "New Teacher";
            this.newTeacherToolStripMenuItem.Click += new System.EventHandler(this.newTeacherToolStripMenuItem_Click);
            // 
            // dIsplayTeacherToolStripMenuItem
            // 
            this.dIsplayTeacherToolStripMenuItem.Name = "dIsplayTeacherToolStripMenuItem";
            this.dIsplayTeacherToolStripMenuItem.Size = new System.Drawing.Size(255, 30);
            this.dIsplayTeacherToolStripMenuItem.Text = "DIsplay Teacher";
            // 
            // manageStudentToolStripMenuItem
            // 
            this.manageStudentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentsToolStripMenuItem,
            this.dIsplayStudentsToolStripMenuItem});
            this.manageStudentToolStripMenuItem.Name = "manageStudentToolStripMenuItem";
            this.manageStudentToolStripMenuItem.Size = new System.Drawing.Size(185, 30);
            this.manageStudentToolStripMenuItem.Text = "Manage Student";
            // 
            // addStudentsToolStripMenuItem
            // 
            this.addStudentsToolStripMenuItem.Name = "addStudentsToolStripMenuItem";
            this.addStudentsToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.addStudentsToolStripMenuItem.Text = "Add students";
            this.addStudentsToolStripMenuItem.Click += new System.EventHandler(this.addStudentsToolStripMenuItem_Click);
            // 
            // dIsplayStudentsToolStripMenuItem
            // 
            this.dIsplayStudentsToolStripMenuItem.Name = "dIsplayStudentsToolStripMenuItem";
            this.dIsplayStudentsToolStripMenuItem.Size = new System.Drawing.Size(263, 30);
            this.dIsplayStudentsToolStripMenuItem.Text = "DIsplay Students";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 448);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sadaToolStripMenuItem;
        private ToolStripMenuItem newRoutineToolStripMenuItem;
        private ToolStripMenuItem displayToolStripMenuItem;
        private ToolStripMenuItem manageTeacherToolStripMenuItem;
        private ToolStripMenuItem newTeacherToolStripMenuItem;
        private ToolStripMenuItem dIsplayTeacherToolStripMenuItem;
        private ToolStripMenuItem manageStudentToolStripMenuItem;
        private ToolStripMenuItem addStudentsToolStripMenuItem;
        private ToolStripMenuItem dIsplayStudentsToolStripMenuItem;
    }
}