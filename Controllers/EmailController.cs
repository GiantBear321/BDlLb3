using BDGA3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDGA3.Controllers
{
    public class EmailController : BaseController
    {
        public override void Read()
        {
            Console.Clear();
            try
            {

                foreach (var i in context.email)
                {
                    Console.WriteLine("Id: {0}", i.id);
                    Console.WriteLine("address: {0}", i.address);
                    Console.WriteLine("reg_date: {0}", i.reg_date);
                    Console.WriteLine("phone_num: {0}", i.phone_num);
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
            var entity = new Email();


            string address = null;
            string phone_num = null;
            DateTime reg_date = new DateTime(0, 0, 0);

            bool correct = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter email properties:");
                Console.WriteLine("address:");
                address = Console.ReadLine();
                Console.WriteLine("phone_num:");
                phone_num = Console.ReadLine();
                Console.WriteLine("Registration date:");
                Console.WriteLine("Year:");
                int year = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Month:");
                int month = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Day:");
                int day = Int32.Parse(Console.ReadLine());
                reg_date = new DateTime(year, month, day);
                correct = true;
            } while (correct == false);


            entity.address = address;
            entity.reg_date = reg_date;
            entity.phone_num = phone_num;

            try
            {
                context.email.Add(entity);
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
            var entity = context.email.Find(base.deleteId);
            context.email.Remove(entity);
            context.SaveChanges();
        }
        public override void Update()
        {
            base.Update();
            var entity = context.email.Find(base.updateId);
            context.email.Update(entity);
            context.SaveChanges();
        }
        public override void Find()
        {
            base.Find();
            var i = context.email.Find(base.findId);
            Console.WriteLine("Id: {0}", i.id);
            Console.WriteLine("address: {0}", i.address);
            Console.WriteLine("reg_date: {0}", i.reg_date);
            Console.WriteLine("phone_num: {0}", i.phone_num);
            Console.WriteLine();
        }
    }
}
