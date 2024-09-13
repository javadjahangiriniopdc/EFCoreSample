using EFCoreSample.Data;
using EFCoreSample.Models;

namespace EFCoreSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using MyContext context = new MyContext();

            #region Add

            //Product veggieSpecial = new Product()
            //{
            //    Name = "Veggie Special Pizza",
            //    Price = 9.99M
            //};
            //context.Products.Add(veggieSpecial);

            //Product deluxeMeat = new Product()
            //{
            //    Name = "Deluxe Meat Pizza",
            //    Price = 12.99M
            //};
            //context.Add(deluxeMeat);

            //context.SaveChanges();
            #endregion Add

            #region Update
            //var veggieSpecial = context.Products
            //    .Where(p => p.Name == "Veggie Special Pizza")
            //    .FirstOrDefault();

            //if (veggieSpecial is Product)
            //{
            //    veggieSpecial.Price = 10.99M;
            //}

            //context.SaveChanges();
            #endregion Update

            #region Update
            var veggieSpecial = context.Products
                .Where(p => p.Name == "Veggie Special Pizza")
                .FirstOrDefault();

            if (veggieSpecial is Product)
            {
               context.Remove(veggieSpecial);
            }

            context.SaveChanges();
            #endregion Update

            #region Display

            //var products = context.Products
            //    .Where(p => p.Price > 10.00M)
            //    .OrderBy(p => p.Name);


            //foreach (Product p in products)
            //{
            //    Console.WriteLine($"Id:    {p.Id}");
            //    Console.WriteLine($"Name:  {p.Name}");
            //    Console.WriteLine($"Price: {p.Price}");
            //    Console.WriteLine(new string('-', 20));
            //}

            #endregion Display

        }
    }
}
