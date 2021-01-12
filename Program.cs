using BDGA3.Controllers;
using System;

namespace BDGA3
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int table = 0;
                int action = 0;
                Console.Clear();
                Console.WriteLine("Choose table:");
                Console.WriteLine("1. Channel");
                Console.WriteLine("2. Channel_Follow");
                Console.WriteLine("3. Comment");
                Console.WriteLine("4. Email");
                Console.WriteLine("5. Video");
                table = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Choose action:");
                Console.WriteLine("1. Create");
                Console.WriteLine("2. Read");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Find");
                Console.WriteLine("6. Generate");
                action = Int32.Parse(Console.ReadLine());

                BaseController controller = null;
                switch (table)
                {
                    case 1:
                        controller = new ChannelController();
                        break;
                    case 2:
                        controller = new ChannelFollowController();
                        break;
                    case 3:
                        controller = new CommentController();
                        break;
                    case 4:
                        controller = new EmailController();
                        break;
                    case 5:
                        controller = new VideoController();
                        break;
                }

                switch (action)
                {
                    case 1:
                        controller.Create();
                        break;
                    case 2:
                        controller.Read();
                        break;
                    case 3:
                        controller.Update();
                        break;
                    case 4:
                        controller.Delete();
                        break;
                    case 5:
                        controller.Find();
                        break;
                }
            }
        }
    }
}
