using BDGA3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDGA3.Controllers
{
    public class VideoController : BaseController       
    {
        public override void Read()
        {
            Console.Clear();
            try
            {

                foreach (var i in context.video)
                {
                    Console.WriteLine("Id: {0}", i.id);
                    Console.WriteLine("title: {0}", i.title);
                    Console.WriteLine("url: {0}", i.url);
                    Console.WriteLine("creator: {0}", i.creator);
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
            var entity = new Video();



            string title = null;
            string url = null;
            int creator = 0;

            bool correct = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter video properties:");
                Console.WriteLine("title:");
                title = Console.ReadLine();
                Console.WriteLine("url:");
                url = Console.ReadLine();
                Console.WriteLine("creator:");
                creator = Int32.Parse(Console.ReadLine());
                correct = true;
            } while (correct == false);


            entity.title = title;
            entity.url = url;
            entity.creator = creator;

            try
            {
                context.video.Add(entity);
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
            var entity = context.video.Find(base.deleteId);
            context.video.Remove(entity);
            context.SaveChanges();
        }
        public override void Update()
        {
            base.Update();
            var entity = context.video.Find(base.updateId);
            context.video.Update(entity);
            context.SaveChanges();
        }
        public override void Find()
        {
            base.Find();
            var i = context.video.Find(base.findId);
            Console.WriteLine("Id: {0}", i.id);
            Console.WriteLine("title: {0}", i.title);
            Console.WriteLine("url: {0}", i.url);
            Console.WriteLine("creator: {0}", i.creator);
            Console.WriteLine();
        }
    }
}
