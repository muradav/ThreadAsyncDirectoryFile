using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadAsyncDirectoryFile.Models
{
    class User
    {
        private static int _id;
        public int ID { get; }
        public string Username { get; set; }
           
        List<Status> statuses =new List<Status>();

        public User(string username)
        {
            _id++;
            ID = _id;
            statuses = new List<Status>();
            Username = username;

        }
        public void ShareStatus(Status stat)
        {
            statuses.Add(stat);
        }
        
        public void GetStatusById(int? id)
        {
            bool exist = false;
            foreach (Status item in statuses)
            {
                if (item.ID == id)
                {
                    exist = true;
                    Console.WriteLine(item);
                }
            }
            if (exist == false)
                Console.WriteLine($"The status not found with this {ID}");
        }

        public void GetAllStatuses()

        {
            foreach (Status item in statuses)
            {
                Console.WriteLine(item);                
            }
        }

        public void FilterStatusByDate(int? id, DateTime date)
        {
            if (id == ID)
            {
                foreach (Status item in statuses)
                {
                    if (date >= item.SharedDate)
                        Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine($"The status not found with this {ID}");
            }
                
        }
    }
}
