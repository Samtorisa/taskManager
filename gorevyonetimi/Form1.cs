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
            graphTask1.Visible = false;
            userControl.Visible = true;
        }

        private void taskListButton_Click(object sender, EventArgs e)
        {
            setActivePanel(listControl1);
        }

        private void buttonGraph_Click(object sender, EventArgs e)
        {
            setActivePanel(graphTask1);
        }
    }
}
