using System;
using ThreadAsyncDirectoryFile.Models;

namespace ThreadAsyncDirectoryFile
{
    class Program
    {
        enum menu {ShareStatus=1, GetAllStatuses,GetStatusById,FilterStatusById,Quit=0}
        static void Main(string[] args)
        {
            User[] users = new User[0];
            Status[] statuses = new Status[0];
            int input;
            do
            {                
                Console.WriteLine("1.Share Status \n" +
                    "2.Get All Statuses \n" +
                    "3.Get Status by Id \n" +
                    "4.Filter Status by ID \n" +
                    "0.Quit");
                Console.WriteLine("Please input your choice: ");
                input = int.Parse(Console.ReadLine());

                switch (input)
                {                   

                    case (int)menu.ShareStatus:
                        
                        break;

                    case (int)menu.GetAllStatuses:
                        
                        break;

                    case (int)menu.GetStatusById:
                        
                        break;

                    case (int)menu.FilterStatusById:
                        
                        break;                    

                    case (int)menu.Quit:
                        break;

                }

            } while (input != 0);
        }
    }
}
