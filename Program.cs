using EF_Task.Data;
using EF_Task.Models;
using Microsoft.EntityFrameworkCore;

namespace EF_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ApplicationDbContext dbcontext = new ApplicationDbContext();
            //query 1 
            //var categories=dbcontext.Categories;
            //foreach (var category in categories) { 
            //Console.WriteLine($"id {category.CategoryId} Name {category.CategoryName}");
            //}

            //query 2
            //var production = dbcontext.Products.FirstOrDefault();
            //Console.WriteLine($"Product ID: {production.ProductId} Name: {production.ProductName} Price: {production.ListPrice}");

            //query 3
            //int productid = 1;
            //var production = dbcontext.Products.FirstOrDefault(e => e.ProductId==productid);
            //if (production != null)
            //{
            //    Console.WriteLine($"Product ID: {production.ProductId}, Name: {production.ProductName}");
            //}
            //else
            //{
            //    Console.WriteLine($"No product found with ID: {productid}");
            //}

            //query 4 
            //var productcertain = dbcontext.Products.Where(e => e.ModelYear == 2016);
            //foreach (var product in productcertain) {
            //    Console.WriteLine($"product {product.ProductName} with year {product.ModelYear}");
            //}


            //query 5
            //int Cusotmerid = 1;
            //var Customers = dbcontext.Customers.FirstOrDefault(e => e.CustomerId == Cusotmerid);
            //if (Customers != null)
            //{
            //    Console.WriteLine($"Customer ID: {Customers.CustomerId}, Name: {Customers.FirstName}");
            //}
            //else
            //{
            //    Console.WriteLine($"No Customer found with ID: {Cusotmerid}");
            //}

            //query 6
            //var productsNames = dbcontext.Products.Include(e =>
            //e.Brand);
            //foreach (var product in productsNames) { 
            //Console.WriteLine($"Name : {product.ProductName} Brand : {product.Brand.BrandName}");
            //}

            //query 7
            //var productCount = dbcontext.Products.Count(e => e.Category.CategoryName == "Road Bikes");
            //Console.WriteLine($"Total Products in 'Road Bikes' category: {productCount}");


            //query 8
            //var totalListPrice = dbcontext.Products
            //    .Where(p => p.Category.CategoryName=="Road Bikes") 
            //    .Sum(p => p.ListPrice);
            //Console.WriteLine($"Total List Price for 'Road Bikes': {totalListPrice:C}");



            //query 9
            //var averageprice = dbcontext.Products.Average(p => p.ListPrice);
            //Console.WriteLine($"Total List Price for 'Road Bikes': {averageprice:C}");


            //query 10
            //var comporders = dbcontext.Orders.Where(e => e.OrderStatus == 4); // i supposed here that accepted orders is with number 4 
            //foreach (var item in comporders) { 
            //Console.WriteLine($"order with date  {item.OrderDate} and status {item.OrderStatus} is accepted");
            //}
            {

            }




        }
    }
}
