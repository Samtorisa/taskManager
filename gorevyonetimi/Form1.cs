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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            setActivePanel(listControl1);

        }

       

        
        public void setActivePanel(UserControl userControl)
        {
            listControl1.Visible = false;
            statistics1.Visible = false;
            userControl.Visible = true;
        }

        private void taskListButton_Click(object sender, EventArgs e)
        {
            setActivePanel(listControl1);
        }

      
        
        

        private void listControl1_Load(object sender, EventArgs e)
        {

        }

        private void buttonStatistic_Click(object sender, EventArgs e)
        {
            try
            {

            statistics1.loadTable();
            setActivePanel(statistics1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }

        }
    }
}
