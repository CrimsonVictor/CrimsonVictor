using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ABSTRACT = SOYUT NESNE = INTERFACE,BASE CLASSLAR,AB.NESNELER.
            //REFERANS TİPLER ABSTRACT KISIMDA OLACAK.
            //CONCRETE = SOMUT NESNE = GERÇEK İŞİ YAPANCAK CLASSLARI BARINDIRACAĞIZ.
            //DAL= DATA ACSESS LAYER

            //ProductManager productManager = new ProductManager(new InMemoryProductDal());             (InMemoryden verileri al.)  
            //DTO = DATA TRANSFORMATION OBJECT
            ProuctTest();
            //IoC
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProuctTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());                      //Ef den verileri al.

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + " / " + product.CategoryName);                   //2 ayrı tablodan dataları join edip çıktı alabildik.
            }
        }
    }
}