using System.Windows.Forms;

namespace MultiWhatsapp.Forms
{
    public class BaseForm : Form
    {
        protected BaseForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // BaseForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new System.Drawing.Size(982, 653);
            Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Icon = Properties.Resources.whatsapp__v1_vf5_icon;
            Margin = new Padding(5);
            Name = "BaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "";
            ResumeLayout(false);
        }
    }
}
