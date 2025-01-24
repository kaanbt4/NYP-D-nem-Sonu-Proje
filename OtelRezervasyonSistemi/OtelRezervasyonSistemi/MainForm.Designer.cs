namespace OtelRezervasyonSistemi
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private CustomButton btnMusteriGirisi;
        private CustomButton btnYoneticiGirisi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            btnMusteriGirisi = new CustomButton();
            btnYoneticiGirisi = new CustomButton();
            SuspendLayout();
            // 
            // btnMusteriGirisi
            // 
            btnMusteriGirisi.Text = "Müşteri Girişi";
            btnMusteriGirisi.Size = new Size(437, 152);
            btnMusteriGirisi.Location = new Point(45, 57);
            btnMusteriGirisi.BackColor = Color.White;
            btnMusteriGirisi.Click += btnMusteriGirisi_Click;
            // 
            // btnYoneticiGirisi
            // 
            btnYoneticiGirisi.Text = "Yönetici Girişi";
            btnYoneticiGirisi.Size = new Size(437, 170);
            btnYoneticiGirisi.BackColor = Color.White;
            btnYoneticiGirisi.Location = new Point(45, 225);
            btnYoneticiGirisi.Click += btnYoneticiGirisi_Click;
            // 
            // MainForm
            // 
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(545, 445);
            Controls.Add(btnMusteriGirisi);
            Controls.Add(btnYoneticiGirisi);
            Text = "Otel Yönetim Sistemi";
            ResumeLayout(false);
        }
    }
}
