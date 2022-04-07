using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadAsyncDirectoryFile
{
    class User
    {
        /*User class
        - Id
        - Statuses - status obyektlərini özündə saxlayan bir list olacaq.
        - Username
        - ShareStatus() - parametr olaraq bir status obyekti qəbul edib statuses listinə əlavə edəcək.
        
        - GetStatusById() - parametr olaraq nullable int tipindən bir id qəbul edəcək həmin id-li statusu tapıb geriyə qaytaracaq.
        - GetAllStatuses() - geriyə user-in bütün statuslarını qaytaracaq.
        - FilterStatusByDate() - parametr olaraq bir nullable id və DateTime tipindən bir tarix qəbul edəcək 
        göndərilən id-li user-in həmin tarixdən sonra paylaşılan bütün statuslarını geriyə qaytaracaq, 
        göndərilən tarixdən sonra heç bir status paylaşılmayıbsa NotFoundException baş verəcək.

        ps: Username olmadan user obyekti yaratmaq olmaz.*/
        private static int _id;
        public int ID { get; }
        public string Username { get; set; }
           
        List<Status> statuses ;

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
            //bool exist = false;
            //foreach (Status item in statuses)
            //{
            //    if (item.ID == id)
            //    {
            //        exist = true;
            //        Console.WriteLine(item);
            //    }
            //}
            //if (exist == false)
            //    throw new NotFoundExpection($"The status not found with this {ID}");
            Status stat1=statuses.Find(n => n.ID == id);
            if (stat1 == null)
            {
                throw new NotFoundExpection($"The status not found with this { ID }");

            }
            Console.WriteLine(stat1);
        }

        public void GetAllStatuses()

        {
            foreach (var item in statuses)
            {
                Console.WriteLine($"ID: {item.ID} \n" +
                $"Title: {item.Title} \n" +
                $"Content: {item.Content} \n" +
                $"Shared Date: {item.SharedDate}");
                
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
                throw new NotFoundExpection($"The status not found with this {ID}");                
            }
                
        }
        
    }
}
