using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod
{
    public abstract class Product
    {
        public abstract void Do();
    }

    public class Product1 : Product
    {
        public override void Do()
        {
            Console.WriteLine("Product1 Do()");
        }
    }

    public class Product2 : Product
    {
        public override void Do()
        {
            Console.WriteLine("Product2 Do()");
        }
    }

    public abstract class Creator
    {
        public abstract Product FactoryMethod();
    }

    public class Product1Creator : Creator
    {
        public override Product FactoryMethod()
        {
            return new Product1();
        }
    }

    public class Product2Creator : Creator
    {
        public override Product FactoryMethod()
        {
            return new Product2();
        }
    }

    public class Client
    {
        public Client()
        {
            bool condition = true;

            Product _product;

            if (condition)
                _product = new Product1Creator().FactoryMethod();
            else
                _product = new Product2Creator().FactoryMethod();

            _product.Do();
        }
    }
}
