﻿namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1= new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnıtsInStock = 3;


            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}