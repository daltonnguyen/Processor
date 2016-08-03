namespace Processor
{
    partial class form_Processor
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
            this.btn_Duplication = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_SearchLaunchTime = new System.Windows.Forms.Button();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.tab_Main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_LaunchTimeResult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtxt_Duplication = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.rtxt_LongestActivity = new System.Windows.Forms.RichTextBox();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.mainMenu.SuspendLayout();
            this.tab_Main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Duplication
            // 
            this.btn_Duplication.Location = new System.Drawing.Point(29, 40);
            this.btn_Duplication.Name = "btn_Duplication";
            this.btn_Duplication.Size = new System.Drawing.Size(81, 63);
            this.btn_Duplication.TabIndex = 0;
            this.btn_Duplication.Text = "Check Duplication";
            this.btn_Duplication.UseVisualStyleBackColor = true;
            this.btn_Duplication.Click += new System.EventHandler(this.CheckDuplication);
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(165, 49);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(263, 20);
            this.txt_id.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 66);
            this.button2.TabIndex = 2;
            this.button2.Text = "Show Device";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ShowLongestLifeTime);
            // 
            // btn_SearchLaunchTime
            // 
            this.btn_SearchLaunchTime.Location = new System.Drawing.Point(454, 46);
            this.btn_SearchLaunchTime.Name = "btn_SearchLaunchTime";
            this.btn_SearchLaunchTime.Size = new System.Drawing.Size(76, 37);
            this.btn_SearchLaunchTime.TabIndex = 3;
            this.btn_SearchLaunchTime.Text = "Search";
            this.btn_SearchLaunchTime.UseVisualStyleBackColor = true;
            this.btn_SearchLaunchTime.Click += new System.EventHandler(this.SearchLaunchTime);
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(694, 24);
            this.mainMenu.TabIndex = 4;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menuOpen
            // 
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(103, 22);
            this.menuOpen.Text = "Open";
            this.menuOpen.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // tab_Main
            // 
            this.tab_Main.Controls.Add(this.tabPage1);
            this.tab_Main.Controls.Add(this.tabPage2);
            this.tab_Main.Controls.Add(this.tabPage3);
            this.tab_Main.Enabled = false;
            this.tab_Main.Location = new System.Drawing.Point(12, 58);
            this.tab_Main.Name = "tab_Main";
            this.tab_Main.SelectedIndex = 0;
            this.tab_Main.Size = new System.Drawing.Size(582, 199);
            this.tab_Main.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_LaunchTimeResult);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txt_id);
            this.tabPage1.Controls.Add(this.btn_SearchLaunchTime);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(574, 173);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Launch Time";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl_LaunchTimeResult
            // 
            this.lbl_LaunchTimeResult.AutoSize = true;
            this.lbl_LaunchTimeResult.Location = new System.Drawing.Point(140, 93);
            this.lbl_LaunchTimeResult.Name = "lbl_LaunchTimeResult";
            this.lbl_LaunchTimeResult.Size = new System.Drawing.Size(0, 13);
            this.lbl_LaunchTimeResult.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please enter product name :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.rtxt_Duplication);
            this.tabPage2.Controls.Add(this.btn_Duplication);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(574, 173);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Duplication Events";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtxt_Duplication
            // 
            this.rtxt_Duplication.Location = new System.Drawing.Point(140, 21);
            this.rtxt_Duplication.Name = "rtxt_Duplication";
            this.rtxt_Duplication.Size = new System.Drawing.Size(410, 137);
            this.rtxt_Duplication.TabIndex = 2;
            this.rtxt_Duplication.Text = "";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.rtxt_LongestActivity);
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(574, 173);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Longest Activity";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // rtxt_LongestActivity
            // 
            this.rtxt_LongestActivity.Location = new System.Drawing.Point(216, 24);
            this.rtxt_LongestActivity.Name = "rtxt_LongestActivity";
            this.rtxt_LongestActivity.Size = new System.Drawing.Size(266, 119);
            this.rtxt_LongestActivity.TabIndex = 3;
            this.rtxt_LongestActivity.Text = "";
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Location = new System.Drawing.Point(229, 275);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(0, 13);
            this.lbl_Message.TabIndex = 6;
            // 
            // form_Processor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 316);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.tab_Main);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "form_Processor";
            this.Text = "Processor";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.tab_Main.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Duplication;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_SearchLaunchTime;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.TabControl tab_Main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_LaunchTimeResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxt_Duplication;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox rtxt_LongestActivity;
        private System.Windows.Forms.Label lbl_Message;
    }
}

