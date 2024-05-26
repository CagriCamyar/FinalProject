﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //DTO ==> Data Transformation Object
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (Category category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
                ProductManager productManager = new ProductManager(new EfProductDal());

                foreach (ProductDetailDto product in productManager.GetProductDetails())
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
        }
    }
}