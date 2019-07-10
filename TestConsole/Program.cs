using Modelo;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IUnitOfWork Repository = new Modelo.RepositoryUoW();
            var Categories = Repository.FindEntitySet<Category>(c => true);

            var Category1 = Repository.Create(new Category
            {
                CategoryName ="CatDemoZ", Description ="Nueva Z"
            });

            var Customer = Repository.Create(new Customer
            {
                CustomerID = "c",
                CompanyName = "c",
                ContactName = "CNSEGOVIAcccc"
            });

            var Changes = Repository.Save();
            Console.Write("Presiona enter para finalizar\n");
            Console.ReadLine();
        }
        static void SinTrans(string[] args)
        {
            IRepository Repository = new Modelo.Repository();
            var Categories = Repository.FindEntitySet<Category>(c => true);

            var Category1 = Repository.Create(new Category
            {
                CategoryName = "CatDemoB", Description = "Nueva B"
            });

            var Customer1 = Repository.Create<Customer>(new Customer
            {
                CustomerID="b", CompanyName= "b",  ContactName = "CNSEGOVIAbbbb"
            });
            Console.Write("Presiona enter para finalizar\n");
            Console.ReadLine();
        }
    }
}
