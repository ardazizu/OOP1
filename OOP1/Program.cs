using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("...Kaşık Yok...");

            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInstock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitsInstock = 5,
                ProductName = "Kalem",
                UnitPrice = 35
            };
            //string isim=Engin
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);

          
            //int double..deger tip //100 //değişmez
            //diziler,class.... referans tip// değişir
            //ref out
            //return ekranda döndürmek için productmanger topla gibi



        }
    }
}
