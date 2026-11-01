using System.ComponentModel;
using System.Windows.Forms;

namespace MultiWhatsapp.Forms
{
    partial class ActivateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.browseBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.activateButton = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.browseBox);
            this.panel1.Controls.Add(this.browseButton);
            this.panel1.Controls.Add(this.copyButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cancelButton);
            this.panel1.Controls.Add(this.activateButton);
            this.panel1.Controls.Add(this.idBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(582, 297);
            this.panel1.TabIndex = 0;
            // 
            // browseBox
            // 
            this.browseBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseBox.Location = new System.Drawing.Point(101, 181);
            this.browseBox.Margin = new System.Windows.Forms.Padding(10, 14, 10, 9);
            this.browseBox.Name = "browseBox";
            this.browseBox.ReadOnly = true;
            this.browseBox.Size = new System.Drawing.Size(340, 27);
            this.browseBox.TabIndex = 5;
            // 
            // browseButton
            // 
            this.browseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseButton.BackColor = System.Drawing.Color.DarkGray;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Location = new System.Drawing.Point(17, 177);
            this.browseButton.Margin = new System.Windows.Forms.Padding(5);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(77, 35);
            this.browseButton.TabIndex = 6;
            this.browseButton.Text = "انتخاب";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // copyButton
            // 
            this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.copyButton.BackColor = System.Drawing.Color.DarkGray;
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyButton.Location = new System.Drawing.Point(17, 106);
            this.copyButton.Margin = new System.Windows.Forms.Padding(5);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(77, 35);
            this.copyButton.TabIndex = 3;
            this.copyButton.Text = "کپی";
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 177);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 14, 10, 9);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "فایل فعالساز:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(177, 243);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(150, 40);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "انصراف";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // activateButton
            // 
            this.activateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.activateButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.activateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activateButton.ForeColor = System.Drawing.Color.White;
            this.activateButton.Location = new System.Drawing.Point(17, 243);
            this.activateButton.Margin = new System.Windows.Forms.Padding(5);
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(150, 40);
            this.activateButton.TabIndex = 8;
            this.activateButton.Text = "فعالسازی";
            this.activateButton.UseVisualStyleBackColor = false;
            this.activateButton.Click += new System.EventHandler(this.ActivateButton_Click);
            // 
            // idBox
            // 
            this.idBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.idBox.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idBox.Location = new System.Drawing.Point(101, 110);
            this.idBox.Margin = new System.Windows.Forms.Padding(10, 14, 10, 9);
            this.idBox.Name = "idBox";
            this.idBox.ReadOnly = true;
            this.idBox.Size = new System.Drawing.Size(340, 27);
            this.idBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 14, 10, 9);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "شناسه:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(582, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "فعالسازی نرم افزار";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "license";
            this.openFileDialog1.Title = "انتخاب فایل فعالساز";
            // 
            // ActivateForm
            // 
            this.AcceptButton = this.activateButton;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(582, 297);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ActivateForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "MultiWhatsapp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label4;
        private TextBox idBox;
        private Button activateButton;
        private Button cancelButton;
        private Label label2;
        private Button copyButton;
        private Button browseButton;
        private TextBox browseBox;
        private OpenFileDialog openFileDialog1;
    }
}

