using System;
using System.Collections.Generic;
using System.Text;

namespace ThreadAsyncDirectoryFile
{
    internal class Status
    /*Status class
    - Id  
    - Title
    - Content
    - SharedDate - DateTime tipindən bir property, statusdan yeni bir obyekt yaranan zaman yarandığı tarix set olunacaq.
    - GetStatusInfo() - 
    geriyə "Title: test title - Content: test content - 
    shared 5 seconds ago"(burda qeyd olunan "shared 5 seconds ago" hissəsi 
    dinamik olmalıdı status neçə saniyə əvvəl paylaşılıbsa o yazılmalıdı) bu tipdə bir məlumat qaytaracaq.*/
    {
        private static int _id;
        public int ID { get;}
        public string Title { get; set; }
        public string Content { get; set; }

        public DateTime SharedDate { get; set; }

       

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
            var interval = DateTime.Now.Subtract(SharedDate).Milliseconds;
            Console.WriteLine($"ID: {ID} \n" +
                $"Title: {Title} \n" +
                $"Content: {Content} \n"  +
                $"Shared Date: {interval}");          
        }
        
    }
}
