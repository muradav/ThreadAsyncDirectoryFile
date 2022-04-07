using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadAsyncDirectoryFile.Models
{
    internal class Status
    {
        private static int _id;
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public DateTime SharedDate { get; set; }

        public Status()
        {

        }

        public Status(string title,string content)
        {            
            Title = title;
            Content = content;
            SharedDate=DateTime.Now;
            _id++;
            ID = _id;

        }

        public void GetStatusInfo()
        {
            Console.WriteLine($"ID: {ID} \n" +
                $"Title: {Title} \n" +
                $"Content: {Content}");           
            
        }
        
    }
}
