using System.Threading.Channels;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {


            SuperChef super = new SuperChef();
            super.Country();

        }


    }


      abstract class Chef
      {
        public abstract void Country();
        
          
      }


        class SuperChef : Chef
    {

        public override void Country()
        {
            Console.WriteLine(" this  is a super chef from Nigeria");
        }

    }





}