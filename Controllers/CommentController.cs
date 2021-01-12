using BDGA3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDGA3.Controllers
{
    public class CommentController : BaseController
    {
        public override void Read()
        {
            Console.Clear();
            try
            {

                foreach (var i in context.comment)
                {
                    Console.WriteLine("Id: {0}", i.id);
                    Console.WriteLine("creator_id: {0}", i.creator_id);
                    Console.WriteLine("video_id: {0}", i.video_id);
                    Console.WriteLine("text: {0}", i.text);
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
            var entity = new Comment();


            int creator = 0;
            int video = 0;
            string text = null;

            bool correct = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter Comment properties:");
                Console.WriteLine("creator:");
                creator = Int32.Parse(Console.ReadLine());
                Console.WriteLine("video:");
                video = Int32.Parse(Console.ReadLine());
                Console.WriteLine("text:");
                text = Console.ReadLine();
                correct = true;
            } while (correct == false);


            entity.creator_id = creator;
            entity.video_id = video;
            entity.text = text;

            try
            {
                context.comment.Add(entity);
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
            var entity = context.comment.Find(base.deleteId);
            context.comment.Remove(entity);
            context.SaveChanges();
        }
        public override void Update()
        {
            base.Update();
            var entity = context.comment.Find(base.updateId);
            context.comment.Update(entity);
            context.SaveChanges();
        }
        public override void Find()
        {
            base.Find();
            var i = context.comment.Find(base.findId);
            Console.WriteLine("Id: {0}", i.id);
            Console.WriteLine("creator_id: {0}", i.creator_id);
            Console.WriteLine("video_id: {0}", i.video_id);
            Console.WriteLine("text: {0}", i.text);
            Console.WriteLine();
        }
    }
}
