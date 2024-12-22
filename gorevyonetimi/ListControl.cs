using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorevyonetimi
{
    public partial class ListControl : UserControl
    {
        public ListControl()
        {
            InitializeComponent();
        }

        private void ListControl_Load(object sender, EventArgs e)
        {
            gridSettings();
        }

        void gridSettings()
        {
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Baslik";
            dataGridView1.Columns[2].Name = "Aciklama";
            dataGridView1.Columns[3].Name = "Tarih";
            dataGridView1.Columns[4].Name = "Durum";

            getData();

            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
            {
                HeaderText = "Sil",
                Name = "deleteButton",
                Text = "Sil",
                UseColumnTextForButtonValue = true
            };
            dataGridView1.Columns.Add(btnDelete);
        }

        public  void getData()
        {
            dataGridView1.Rows.Clear();

            try
            {

                using (StreamReader streamReader = new StreamReader(Task.filePath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string[] row = line.Split(',');
                        if (row.Length == 5)
                        {
                            dataGridView1.Rows.Add(row[0], row[1], row[2], row[3], row[4]);
                        }
                        else
                        {
                            continue;
                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("hata: " + ex.Message);

            }
        }

        

        
        
       

        public void openAddModal(object sender, EventArgs e)
        {
            AddingForm addingForm = new AddingForm(this);
            addingForm.ShowDialog();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            
            if (e.ColumnIndex == dataGridView1.Columns["deleteButton"].Index)
            {
                var id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value?.ToString();

                if (!string.IsNullOrEmpty(id))
                {
                    
                    var lines = File.ReadAllLines(Task.filePath).ToList();
                    var updatedLines = lines.Where(line => !line.StartsWith(id + ",")).ToList();

                    
                    File.WriteAllLines(Task.filePath, updatedLines);

                    
                    getData();
                    MessageBox.Show("başarıyla silindi!");
                }
                else
                {
                    MessageBox.Show("Geçersiz Id.");
                }
            }
            else
            {
                var id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value?.ToString();
                var title = dataGridView1.Rows[e.RowIndex].Cells["Baslik"].Value?.ToString();
                var description = dataGridView1.Rows[e.RowIndex].Cells["Aciklama"].Value?.ToString();
                var date = dataGridView1.Rows[e.RowIndex].Cells["Tarih"].Value?.ToString();
                var state = dataGridView1.Rows[e.RowIndex].Cells["Durum"].Value?.ToString();

                UpdateForm updateForm = new UpdateForm(id, title, description, date, state);
                updateForm.ShowDialog();
            }
        }

        void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex == dataGridView1.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == dataGridView1.Columns["deleteButton"].Index)
            {
                var image = Properties.Resources.ImageDelete;

                
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                
                int imageWidth = Math.Min(image.Width, e.CellBounds.Width - 4); 
                int imageHeight = Math.Min(image.Height, e.CellBounds.Height - 4);

                
                var x = e.CellBounds.Left + (e.CellBounds.Width - imageWidth) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - imageHeight) / 2;

                
                e.Graphics.DrawImage(image, new Rectangle(x, y, imageWidth, imageHeight));

                
                e.Handled = true;
            }
        }

    }
}
