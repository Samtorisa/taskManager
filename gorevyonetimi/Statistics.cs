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
    public partial class Statistics : UserControl
    {
        public Statistics()
        {
            InitializeComponent();
            loadTable();

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public void loadTable()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            double doing = 0, done = 0, willDo = 0;

            try
            {
                

             
                    var lines = File.ReadAllLines(Task.filePath).ToList();
                for (int i = 0; i < lines.Count; i++)
                {
                    var taskStatus = lines[i].Split(',')[4];

                    if (taskStatus == "YAPILDI")
                    {
                        done += 1;
                    }
                    else if (taskStatus == "YAPILIYOR")
                    {
                        doing += 1;
                    }
                    else if (taskStatus == "YAPILACAK")
                    {
                        willDo += 1;
                    }
                }

                chart1.Series["YAPILDI"].Points.Add(done);
                chart1.Series["YAPILIYOR"].Points.Add(doing);
                chart1.Series["YAPILACAK"].Points.Add(willDo);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İstatistikler yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            loadTable();
        }
    }
}
