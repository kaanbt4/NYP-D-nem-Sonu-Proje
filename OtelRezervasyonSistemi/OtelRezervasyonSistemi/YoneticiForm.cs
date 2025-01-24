using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace OtelRezervasyonSistemi
{
    public partial class YoneticiForm : Form
    {
        private OleDbConnection _connection;

        public YoneticiForm()
        {
            InitializeComponent();
            _connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=OtelRezervasyon.accdb;");
            gridViewDoldur();
        }


        public void gridViewDoldur()
        {
            try
            {
                dataGridView1.Columns.Clear();
                
                _connection.Open();

                // SQL
                string query = "SELECT * FROM Odalar";

                
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

        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _connection.Open();
                string query = "INSERT INTO Odalar (OdaTipi, MusaitMi, Fiyat) VALUES (@OdaTipi, @MusaitMi, @Fiyat)";
                using (OleDbCommand command = new OleDbCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@OdaTipi", txtOdaTipi.Text);
                    command.Parameters.AddWithValue("@MusaitMi", chkMusait.Checked);
                    command.Parameters.AddWithValue("@Fiyat", decimal.Parse(txtFiyat.Text));

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Oda başarıyla eklendi.");
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
                gridViewDoldur();
            }
        }

        private void btnOdaSil_Click(object sender, EventArgs e)
        {
            try
            {
                _connection.Open();
                string query = "DELETE FROM Odalar WHERE OdaId = @OdaId";
                using (OleDbCommand command = new OleDbCommand(query, _connection))
                {
                    command.Parameters.AddWithValue("@OdaId", int.Parse(txtOdaId.Text));
                    command.ExecuteNonQuery();
                }
                MessageBox.Show("Oda başarıyla silindi.");
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
                gridViewDoldur();
            }
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string odaID = dataGridView1.SelectedRows[0].Cells[0].Value + string.Empty;
                string odaTipi = dataGridView1.SelectedRows[0].Cells[1].Value + string.Empty;
                string odaFiyat = dataGridView1.SelectedRows[0].Cells[3].Value + string.Empty;
                txtOdaId.Text = odaID;
                txtFiyat.Text = odaFiyat;
                txtOdaTipi.Text = odaTipi;
            }
        }

        private void OdaDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOdaId.Text == "" || txtOdaId.Text == "")
                {
                    MessageBox.Show("Lütfen önce tablodan oda seçiniz!");
                }
                else
                {
                    string query = "UPDATE Odalar SET OdaTipi='" + txtOdaTipi.Text + "',Fiyat=" + int.Parse(txtFiyat.Text) + " WHERE OdaId = " + txtOdaId.Text + "";
                    using (OleDbCommand command = new OleDbCommand(query, _connection))
                    {
                        _connection.Open();
                        command.ExecuteNonQuery();
                        _connection.Close();
                    }
                    MessageBox.Show("Oda başarıyla güncellendi.");
                }
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
                gridViewDoldur();
            }
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
        private void YoneticiForm_Load(object sender, EventArgs e)
        {
            CustomizeDataGridView(dataGridView1);
        }
    }
}

namespace OtelRezervasyonSistemi
{
    public class Oda
    {
        public int OdaId { get; set; }
        public string OdaTipi { get; set; }
        public bool MusaitMi { get; set; }
        public decimal Fiyat { get; set; }
    }
}