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

            try
            {
                using (StreamReader streamReader = new StreamReader(Task.filePath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string[] kemalettin = line.Split(',');

                        if (kemalettin.Length == 5) 
                        {
                            dataGridView1.Rows.Add(kemalettin[0], kemalettin[1], kemalettin[2], kemalettin[3], kemalettin[4]);
                        }
                        else
                        {
                            continue;
                        }
                       
                    }
                }


            }
            catch (Exception ex) { }


            DataGridViewImageColumn btnDelete = new DataGridViewImageColumn();
                       
            btnDelete.HeaderText = "silmek";
            btnDelete.Name = "deleteButton";
            dataGridView1.Columns.Add(btnDelete);


        }

        public void LoadData(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            try
            {
                using (StreamReader streamReader = new StreamReader(Task.filePath))
                {
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        string[] kemalettin = line.Split(',');
                        if (kemalettin.Length == 5)
                        {
                            dataGridView1.Rows.Add(kemalettin[0], kemalettin[1], kemalettin[2], kemalettin[3], kemalettin[4]);
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

            }
            }
        
       

        public void openAddModal(object sender, EventArgs e)
        {
            AddingForm addingForm = new AddingForm();
            addingForm.ShowDialog();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            
            if(e.ColumnIndex != 5)
            {

                var id = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
                var title = dataGridView1.Rows[e.RowIndex].Cells["Baslik"].Value;
                var description = dataGridView1.Rows[e.RowIndex].Cells["Aciklama"].Value;
                var date = dataGridView1.Rows[e.RowIndex].Cells["Tarih"].Value;
                var state = dataGridView1.Rows[e.RowIndex].Cells["Durum"].Value;
                UpdateForm updateForm = new UpdateForm(id.ToString(), title.ToString(), description.ToString(), date.ToString(), state.ToString());
            updateForm.ShowDialog();
            }
            

        }
    }
}
