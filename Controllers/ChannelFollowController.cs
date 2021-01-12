using BDGA3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BDGA3.Controllers
{
    public class ChannelFollowController : BaseController
    {
        public override void Read()
        {
            Console.Clear();
            try
            {

                foreach (var i in context.channel_follow)
                {
                    Console.WriteLine("Id: {0}", i.id);
                    Console.WriteLine("Channel_id: {0}", i.channel_id);
                    Console.WriteLine("Follow_id: {0}", i.follow_id);
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
            var entity = new ChannelFollow();

            int channel = 0;
            int follow = 0;

            bool correct = false;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter Channel_follow properties:");
                Console.WriteLine("Channel:");
                channel = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Follow:");
                follow = Int32.Parse(Console.ReadLine());
                correct = true;
            } while (correct == false);


            entity.channel_id = channel;
            entity.follow_id = follow;

            try
            {
                context.channel_follow.Add(entity);
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
            var entity = context.channel_follow.Find(base.deleteId);
            context.channel_follow.Remove(entity);
            context.SaveChanges();
        }
        public override void Update()
        {
            base.Update();
            var entity = context.channel_follow.Find(base.updateId);
            context.channel_follow.Update(entity);
            context.SaveChanges();
        }
        public override void Find()
        {
            base.Find();
            var i = context.channel_follow.Find(base.findId);
            Console.WriteLine("Id: {0}", i.id);
            Console.WriteLine("Channel_id: {0}", i.channel_id);
            Console.WriteLine("Follow_id: {0}", i.follow_id);
            Console.WriteLine();
        }
    }
}
