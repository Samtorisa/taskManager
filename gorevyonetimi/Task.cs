using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gorevyonetimi
{
    public class Task
    {
        public static string filePath="taskData.txt";
        public int id {  get; set; }
        public string title{ get; set; }    
        public string description { get; set; }

        public string status { get; set; }
        public DateTime date { get; set; }

        public Task()
        {

        }

        public Task(int id, string title, string description, DateTime date,string status)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.date = date;
            this.status= status;

        }

        

    }
}
