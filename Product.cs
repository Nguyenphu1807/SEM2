using System;
public class InvalidInput : ApplicationException
{
    public InvalidInput()
    : base("Enter a number greater than Zero") { }
}
namespace Product
{
    class Product
    {
        public string id;
        public void getid()
        {
            Console.WriteLine("Enter your id :");
            id = Console.ReadLine();
            Console.WriteLine("id :" +id);
        }
        public string name;
        public void getname()
        {
            Console.WriteLine("Enter your name :");
            name = Console.ReadLine();
            Console.WriteLine("name :" + name);
        }
        public string producer;
        public void getproducer()
        {
            Console.WriteLine("Enter producer :");
            producer = Console.ReadLine();
            Console.WriteLine("producer :" + producer);
        }
        public string constructor;
        public void getconstructor()
        {
            Console.WriteLine("Enter constructor :");
            constructor = Console.ReadLine();
            Console.WriteLine("contructor :" + constructor);
        }
        static void Main(string[] args)
        {
            double intCnt = 0.08;
            //double intCnt = 0.1;
            double intprice;
            Console.WriteLine("Enter a price :");
            intprice = Convert.ToInt32(Console.ReadLine());
            if (intprice <= 0)
            {
                throw new InvalidInput();
            }
            Console.WriteLine(intprice + intCnt*intprice);
        }
          
    }
}
