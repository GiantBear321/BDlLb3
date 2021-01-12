using BDGA3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDGA3.Controllers
{
    public class ChannelController : BaseController
    {
        public override void Read()
        {
            Console.Clear();
            try
            {

                foreach (var i in context.channel)
                {
                    Console.WriteLine("Id: {0}", i.id);
                    Console.WriteLine("Name: {0}", i.name);
                    Console.WriteLine("Email id: {0}", i.email_id);
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        public override void Create()
        {
            var entity = new Channel();

            string name = null;
            int email = 0;

            bool correct = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter Channel properties:");
                Console.WriteLine("Name:");
                name = Console.ReadLine();
                Console.WriteLine("Mail:");
                email = Int32.Parse(Console.ReadLine());
                correct = true;
            } while (correct == false);

            entity.name = name;
            entity.email_id = email;

            try
            {
                context.channel.Add(entity);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }

        public override void Delete()
        {
            base.Delete();
            var entity = context.channel.Find(base.deleteId);
            context.channel.Remove(entity);
            context.SaveChanges();
        }
        public override void Update()
        {
            base.Update();
            var entity = context.channel.Find(base.updateId);
            context.channel.Update(entity);
            context.SaveChanges();
        }
        public override void Find()
        {
            base.Find();
            var i = context.channel.Find(base.findId);
            Console.WriteLine("Id: {0}", i.id);
            Console.WriteLine("Name: {0}", i.name);
            Console.WriteLine("Email_id: {0}", i.email_id);
            Console.WriteLine();
        }
    }
}
