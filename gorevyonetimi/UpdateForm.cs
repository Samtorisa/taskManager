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
    public partial class UpdateForm : Form
    {
        public  string id;
        
        public UpdateForm(string id,string title,string description,string date,string state)
        {
            InitializeComponent();
            textTitle.Text = title;
            descriptionText.Text = description;
            status.Text = state;
            this.id = id;
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            var lines =File.ReadAllLines(Task.filePath).ToList();
            bool found=false;
            for (int i = 0; i < lines.Count; i++) 
            {
                var taskId = lines[i].Split(',')[0];
                if(taskId == id)
                {
                    lines[i] = id+","+textTitle.Text+","+descriptionText.Text+","+DateTime.Now.ToString()+","+status.Text;
                    found = true; 
                    break; 
                }
            
            }
            if (found)
            {
                File.WriteAllLines(Task.filePath, lines);
                MessageBox.Show($"ID {id} güncellendi.");
            }
            else
            {
                MessageBox.Show($"ID {id} bulunamadı.");

            }
        }
    }
}
