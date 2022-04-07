using System;

namespace ThreadAsyncDirectoryFile
{
    class Program
    {
        enum menu { ShareStatus = 1, GetAllStatuses, GetStatusById, FilterStatusByDate, Quit = 0 }

        static void Main(string[] args)

        {
            Console.WriteLine("Please enter username: ");
            string inputuser = Console.ReadLine();

            User user = new User(inputuser);
            int input;
            do
            {
                Console.Clear();
                MainMenu();
                input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    
                    case (int)menu.ShareStatus:
                        Console.WriteLine("Please enter title: ");
                        string intputtitle = Console.ReadLine();
                        Console.WriteLine("Please enter content: ");
                        string inputcontent = Console.ReadLine();
                        Status stat = new Status(intputtitle, inputcontent);
                        user.ShareStatus(stat);
                        break;

                    case (int)menu.GetAllStatuses:
                        user.GetAllStatuses();
                        break;

                    case (int)menu.GetStatusById:
                        Console.WriteLine("Please enter ID: ");
                        int inputId = int.Parse(Console.ReadLine());
                        user.GetStatusById(inputId);

                        break;

                    case (int)menu.FilterStatusByDate:
                        Console.WriteLine("Please enter ID: ");
                        int inputFilterID = int.Parse(Console.ReadLine());
                        Console.WriteLine("Please enter Date Time: ");
                        string inputTime = Console.ReadLine();
                        user.FilterStatusByDate(inputFilterID, DateTime.Parse(inputTime));
                        break;

                    case (int)menu.Quit:
                        break;

                }

            } while (input != 0);


        }
        public static void MainMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1.Share Status \n" +
                "2.Get All Statuses \n" +
                "3.Get Status by Id \n" +
                "4.Filter Status by ID \n" +
                "0.Quit");
            Console.WriteLine("Please input your choice: ");
        }
    }
}
