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
        private ListControl formList;
        public AddingForm(ListControl listForm)
        {
            InitializeComponent();
           formList = listForm;
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

                MessageBox.Show("Başarı ile eklendi");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }


        private void ButtonAdd(object sender, EventArgs e)
        {
            if(textTitle.Text!="" &&descriptionText.Text !="")
            {


            Task task = new Task();
            task.title = textTitle.Text;
            task.description = descriptionText.Text;
            task.date=DateTime.Now;
            task.status = "YAPILACAK";
            addRecords(Task.filePath, task);

                this.Close();
                formList.getData();
            }else
            {
                MessageBox.Show("boş alan bırakmayınız");
            }
        }
        
    }
}
