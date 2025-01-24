using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
namespace OtelRezervasyonSistemi
{
    public partial class MusteriForm : Form
    {
        private OleDbConnection _connection;

        public MusteriForm()
        {
            InitializeComponent();
            _connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OtelRezervasyon.accdb;");
        }


        private void CustomizeDataGridView(DataGridView dgv)
        {
            
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.EnableHeadersVisualStyles = false;

            
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSteelBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.Padding = new Padding(5); // Hücre içine boşluk
            dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.GridColor = Color.LightGray;

            
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Kolonları tam genişlikte doldur
            }

            
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

           
            dgv.RowHeadersVisible = false;

            
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
        }

        public void gridViewDoldur()
        {
            try
            {
                dataGridView1.Columns.Clear();
                
                _connection.Open();

               
                string query = "SELECT * FROM Rezervasyon";

                
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, _connection);
                DataTable dataTable = new DataTable();

               
                dataAdapter.Fill(dataTable);

                
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                
                if (_connection.State == ConnectionState.Open)
                {
                    _connection.Close();
                }
            }
        }
        private void btnRezervasyonYap_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO Rezervasyon (OdaId,MusteriAdi, GirisTarihi, CikisTarihi) VALUES ('" + Convert.ToInt32(txtOdaId.Text) + "','" + txtMusteriAdi.Text + "', '" + dtpGirisTarihi.Value.ToString() + "', '" + dtpCikisTarihi.Value.ToString() + "')";
                using (OleDbCommand command = new OleDbCommand(query, _connection))
                {
                    if (_connection.State == ConnectionState.Open)
                    {
                        _connection.Close();
                    }
                    _connection.Open();
                    command.ExecuteNonQuery();
                    _connection.Close();
                }
                MessageBox.Show("Rezervasyon başarıyla yapıldı.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                gridViewDoldur();
            }
        }

        private void btnRezervasyonIptal_Click(object sender, EventArgs e)
        {
            try
            {
                _connection.Open();
                string query = "DELETE FROM Rezervasyon WHERE RezervasyonId = @RezervasyonId";
                using (OleDbCommand command = new OleDbCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@RezervasyonId", int.Parse(txtRezervasyonId.Text));
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Rezervasyon başarıyla iptal edildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                _connection.Close();
                gridViewDoldur();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            CustomizeDataGridView(dataGridView1);
            gridViewDoldur();

        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string MusteriAdi = dataGridView1.SelectedRows[0].Cells[5].Value + string.Empty;
                string OdaId = dataGridView1.SelectedRows[0].Cells[2].Value + string.Empty;
                string RezervasyonID = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                string girisTarihi = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                string cikisTarihi = dataGridView1.SelectedRows[0].Cells[4].Value + string.Empty;
                txtMusteriAdi.Text = MusteriAdi;
                txtOdaId.Text = OdaId;
                txtRezervasyonId.Text = RezervasyonID;
                dtpGirisTarihi.Value = Convert.ToDateTime(girisTarihi);
                dtpCikisTarihi.Value = Convert.ToDateTime(cikisTarihi);
            }
        }
    }
}
