namespace OtelRezervasyonSistemi
{
    partial class MusteriForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.TextBox txtOdaId;
        private System.Windows.Forms.TextBox txtRezervasyonId;
        private System.Windows.Forms.Button btnRezervasyonYap;
        private System.Windows.Forms.Button btnRezervasyonIptal;
        private System.Windows.Forms.DateTimePicker dtpGirisTarihi;
        private System.Windows.Forms.DateTimePicker dtpCikisTarihi;

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
            txtMusteriAdi = new TextBox();
            txtOdaId = new TextBox();
            txtRezervasyonId = new TextBox();
            dtpGirisTarihi = new DateTimePicker();
            dtpCikisTarihi = new DateTimePicker();
            btnRezervasyonYap = new Button();
            btnRezervasyonIptal = new Button();
            label1 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtMusteriAdi
            // 
            txtMusteriAdi.Location = new Point(118, 29);
            txtMusteriAdi.Name = "txtMusteriAdi";
            txtMusteriAdi.PlaceholderText = "Müşteri Adı";
            txtMusteriAdi.Size = new Size(200, 27);
            txtMusteriAdi.TabIndex = 0;
            // 
            // txtOdaId
            // 
            txtOdaId.Location = new Point(118, 69);
            txtOdaId.Name = "txtOdaId";
            txtOdaId.PlaceholderText = "Oda ID";
            txtOdaId.Size = new Size(200, 27);
            txtOdaId.TabIndex = 1;
            // 
            // txtRezervasyonId
            // 
            txtRezervasyonId.Location = new Point(118, 109);
            txtRezervasyonId.Name = "txtRezervasyonId";
            txtRezervasyonId.PlaceholderText = "Rezervasyon ID";
            txtRezervasyonId.Size = new Size(200, 27);
            txtRezervasyonId.TabIndex = 2;
            // 
            // dtpGirisTarihi
            // 
            dtpGirisTarihi.Location = new Point(472, 44);
            dtpGirisTarihi.Name = "dtpGirisTarihi";
            dtpGirisTarihi.Size = new Size(200, 27);
            dtpGirisTarihi.TabIndex = 3;
            // 
            // dtpCikisTarihi
            // 
            dtpCikisTarihi.Location = new Point(472, 106);
            dtpCikisTarihi.Name = "dtpCikisTarihi";
            dtpCikisTarihi.Size = new Size(200, 27);
            dtpCikisTarihi.TabIndex = 4;
            // 
            // btnRezervasyonYap
            // 
            btnRezervasyonYap.Location = new Point(299, 160);
            btnRezervasyonYap.Name = "btnRezervasyonYap";
            btnRezervasyonYap.Size = new Size(200, 30);
            btnRezervasyonYap.TabIndex = 5;
            btnRezervasyonYap.Text = "Rezervasyon Yap";
            btnRezervasyonYap.Click += btnRezervasyonYap_Click;
            // 
            // btnRezervasyonIptal
            // 
            btnRezervasyonIptal.Location = new Point(299, 196);
            btnRezervasyonIptal.Name = "btnRezervasyonIptal";
            btnRezervasyonIptal.Size = new Size(200, 30);
            btnRezervasyonIptal.TabIndex = 6;
            btnRezervasyonIptal.Text = "Rezervasyonu İptal Et";
            btnRezervasyonIptal.Click += btnRezervasyonIptal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(527, 16);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 7;
            label1.Text = "Giriş Tarihi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(527, 82);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 8;
            label2.Text = "Çıkış Tarihi";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 263);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(838, 201);
            dataGridView1.TabIndex = 9;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // MusteriForm
            // 
            ClientSize = new Size(838, 464);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMusteriAdi);
            Controls.Add(txtOdaId);
            Controls.Add(txtRezervasyonId);
            Controls.Add(dtpGirisTarihi);
            Controls.Add(dtpCikisTarihi);
            Controls.Add(btnRezervasyonYap);
            Controls.Add(btnRezervasyonIptal);
            Name = "MusteriForm";
            Text = "Müşteri Rezervasyon";
            Load += MusteriForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private DataGridView dataGridView1;
    }
}
