
namespace MultiWhatsapp.Forms
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.navBar = new System.Windows.Forms.MenuStrip();
            this.backwardButton = new System.Windows.Forms.ToolStripMenuItem();
            this.forwardButton = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshButton = new System.Windows.Forms.ToolStripMenuItem();
            this.burgerButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.navBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Location = new System.Drawing.Point(0, 47);
            this.tabControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1024, 721);
            this.tabControl.TabIndex = 0;
            // 
            // navBar
            // 
            this.navBar.AllowMerge = false;
            this.navBar.BackColor = System.Drawing.Color.Gainsboro;
            this.navBar.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.navBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backwardButton,
            this.forwardButton,
            this.refreshButton,
            this.burgerButton});
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.Padding = new System.Windows.Forms.Padding(5);
            this.navBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.navBar.Size = new System.Drawing.Size(1024, 47);
            this.navBar.TabIndex = 2;
            // 
            // backwardButton
            // 
            this.backwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.backwardButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backwardButton.Margin = new System.Windows.Forms.Padding(3);
            this.backwardButton.Name = "backwardButton";
            this.backwardButton.Padding = new System.Windows.Forms.Padding(5);
            this.backwardButton.ShortcutKeyDisplayString = "";
            this.backwardButton.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.backwardButton.Size = new System.Drawing.Size(39, 31);
            this.backwardButton.Text = "";
            this.backwardButton.Click += new System.EventHandler(this.BackwardButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.forwardButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forwardButton.Margin = new System.Windows.Forms.Padding(3);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Padding = new System.Windows.Forms.Padding(5);
            this.forwardButton.ShortcutKeyDisplayString = "";
            this.forwardButton.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.forwardButton.Size = new System.Drawing.Size(39, 31);
            this.forwardButton.Text = "";
            this.forwardButton.Click += new System.EventHandler(this.ForwardButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.refreshButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Margin = new System.Windows.Forms.Padding(3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Padding = new System.Windows.Forms.Padding(5);
            this.refreshButton.ShortcutKeyDisplayString = "";
            this.refreshButton.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.refreshButton.Size = new System.Drawing.Size(39, 31);
            this.refreshButton.Text = "";
            this.refreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // burgerButton
            // 
            this.burgerButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.burgerButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.burgerButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutButton});
            this.burgerButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.burgerButton.Margin = new System.Windows.Forms.Padding(3);
            this.burgerButton.Name = "burgerButton";
            this.burgerButton.Padding = new System.Windows.Forms.Padding(5);
            this.burgerButton.ShortcutKeyDisplayString = "";
            this.burgerButton.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.burgerButton.Size = new System.Drawing.Size(39, 31);
            this.burgerButton.Text = "";
            this.burgerButton.Visible = false;
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.aboutButton.Size = new System.Drawing.Size(224, 28);
            this.aboutButton.Text = "درباره برنامه...";
            this.aboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.navBar);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.navBar.ResumeLayout(false);
            this.navBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.MenuStrip navBar;
        private System.Windows.Forms.ToolStripMenuItem backwardButton;
        private System.Windows.Forms.ToolStripMenuItem forwardButton;
        private System.Windows.Forms.ToolStripMenuItem refreshButton;
        private System.Windows.Forms.ToolStripMenuItem burgerButton;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
    }
}

