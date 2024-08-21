using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Utilities utilities = new Utilities();
            List<string> result = utilities.BuildList<string>("Ankara","İzmir","Adana");
            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

            List<Customer> result2 = utilities.BuildList<Customer>(new Customer{FirstName = "Engin"}, new Customer { FirstName = "Derin" });

            foreach(var customer in result2)
            {
                Console.WriteLine(customer.FirstName);
            }

            Console.ReadLine();
        }
    }

    class Utilities
    {
        public List<T>BuildList<T>(params T[] items)
        {
            return new List<T>(items);
        }
    }

    class Product : IEntitiy
    {

    }

    interface IProductDal : IRepository<Product>
    {


    }

    class Customer : IEntitiy
    {
        public string FirstName { get; set; }
    }

    interface ICustomertDal: IRepository<Customer>
    {

    }

    interface IStudentDal : IRepository<Student>
    {

    }

    class Student: IEntitiy
    {

    }

    interface IEntitiy
    {

    }

    interface IRepository <T> where T : class,IEntitiy ,new()
    {
        List<T> GetAll();
        T Get(int id);

        void Add(T entitiy);
        void Delete(T entitiy);

        void Update(T entitiy);

    }

    class ProductDal : IProductDal
    {
        public void Add(Product entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entitiy)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entitiy)
        {
            throw new NotImplementedException();
        }
    }

    class CustomerDal : ICustomertDal
    {
        public void Add(Customer entitiy)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entitiy)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entitiy)
        {
            throw new NotImplementedException();
        }
    }
}
