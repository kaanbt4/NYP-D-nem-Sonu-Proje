namespace OtelRezervasyonSistemi
{
    partial class YoneticiForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtOdaTipi;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.CheckBox chkMusait;
        private System.Windows.Forms.Button btnOdaEkle;
        private System.Windows.Forms.Button btnOdaSil;

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
            txtOdaTipi = new TextBox();
            txtFiyat = new TextBox();
            chkMusait = new CheckBox();
            btnOdaEkle = new Button();
            btnOdaSil = new Button();
            txtOdaId = new TextBox();
            dataGridView1 = new DataGridView();
            OdaDuzenle = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtOdaTipi
            // 
            txtOdaTipi.Location = new Point(361, 48);
            txtOdaTipi.Name = "txtOdaTipi";
            txtOdaTipi.PlaceholderText = "Oda Tipi";
            txtOdaTipi.Size = new Size(200, 27);
            txtOdaTipi.TabIndex = 0;
            // 
            // txtFiyat
            // 
            txtFiyat.Location = new Point(361, 88);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.PlaceholderText = "Fiyat";
            txtFiyat.Size = new Size(200, 27);
            txtFiyat.TabIndex = 1;
            // 
            // chkMusait
            // 
            chkMusait.Location = new Point(361, 128);
            chkMusait.Name = "chkMusait";
            chkMusait.Size = new Size(200, 22);
            chkMusait.TabIndex = 2;
            chkMusait.Text = "Müsait Mi?";
            // 
            // btnOdaEkle
            // 
            btnOdaEkle.Location = new Point(129, 183);
            btnOdaEkle.Name = "btnOdaEkle";
            btnOdaEkle.Size = new Size(200, 30);
            btnOdaEkle.TabIndex = 4;
            btnOdaEkle.Text = "Oda Ekle";
            btnOdaEkle.Click += btnOdaEkle_Click;
            // 
            // btnOdaSil
            // 
            btnOdaSil.Location = new Point(563, 183);
            btnOdaSil.Name = "btnOdaSil";
            btnOdaSil.Size = new Size(200, 30);
            btnOdaSil.TabIndex = 5;
            btnOdaSil.Text = "Oda Sil";
            btnOdaSil.Click += btnOdaSil_Click;
            // 
            // txtOdaId
            // 
            txtOdaId.Location = new Point(848, 12);
            txtOdaId.Name = "txtOdaId";
            txtOdaId.PlaceholderText = "Oda ID";
            txtOdaId.Size = new Size(61, 27);
            txtOdaId.TabIndex = 3;
            txtOdaId.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 309);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(921, 188);
            dataGridView1.TabIndex = 6;
            dataGridView1.MouseClick += dataGridView1_MouseClick;
            // 
            // OdaDuzenle
            // 
            OdaDuzenle.Location = new Point(346, 183);
            OdaDuzenle.Name = "OdaDuzenle";
            OdaDuzenle.Size = new Size(200, 30);
            OdaDuzenle.TabIndex = 7;
            OdaDuzenle.Text = "Oda Düzenle";
            OdaDuzenle.Click += OdaDuzenle_Click;
            // 
            // YoneticiForm
            // 
            ClientSize = new Size(921, 497);
            Controls.Add(OdaDuzenle);
            Controls.Add(dataGridView1);
            Controls.Add(txtOdaTipi);
            Controls.Add(txtFiyat);
            Controls.Add(chkMusait);
            Controls.Add(txtOdaId);
            Controls.Add(btnOdaEkle);
            Controls.Add(btnOdaSil);
            Name = "YoneticiForm";
            Text = "Yönetici Paneli";
            Load += YoneticiForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtOdaId;
        private DataGridView dataGridView1;
        private Button OdaDuzenle;
    }
}
