// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

using Entities.Concrete;




ProductManager productManager = new ProductManager(new EfProductDal());

foreach (var product in productManager.GetProductDetails())
{
    Console.WriteLine(product.ProductName+product.CategoryName);
   
}