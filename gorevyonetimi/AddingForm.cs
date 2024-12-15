using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gorevyonetimi
{
    public partial class AddingForm : Form
    {
        public AddingForm()
        {
            InitializeComponent();
        }

        private void AddingForm_Load(object sender, EventArgs e)
        {

        }

        public void addRecords(string filePath, Task task)
        {
            ListControl listControl=new ListControl();
            var lines = File.ReadAllLines(filePath);
            var ids = lines.Select(line => line.Split(',')[0])
                .ToList();

            int id;
            
            if (ids.Count > 1) 
            {
             id=int.Parse(ids.Last())+1;
            }
            else
            {
                 id=1;
            }


            try
            {
                FileStream stream = new FileStream(filePath, FileMode.Append,FileAccess.Write);
                using (StreamWriter wr = new StreamWriter(stream))
                {
                    wr.WriteLine(id + "," + task.title + "," + task.description + "," + DateTime.Now + "," + task.status);
                }

                MessageBox.Show("addRecords metodu çağrıldı.");


            }
            catch (Exception ex)
            {
                throw new Exception("akfşkjasdşfk");
            }
        }


        private void ButtonAdd(object sender, EventArgs e)
        {
            AddingForm addingForm= new AddingForm();
            Task task = new Task();
            task.title = textTitle.Text;
            task.description = descriptionText.Text;
            task.date=DateTime.Now;
            task.status = status.Text;
            addRecords(Task.filePath, task);
            addingForm.Close();
        }
        
    }
}
