
using LINQdemo;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net.NetworkInformation;

public class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>()
        {
            new Product{Id = 101, Name = "Laptop", Company = "HP", Price = 45000},
            new Product{Id = 102, Name = "Laptop", Company = "Lenovo", Price = 85000},
            new Product{Id = 103, Name = "Mobile", Company = "Apple", Price = 78000},
            new Product{Id = 104, Name = "Mobile", Company = "Samsung", Price = 25000},
            new Product{Id = 105, Name = "Mouse", Company = "Dell", Price = 4500},
            new Product{Id = 106, Name = "Mobile", Company = "OnePlus", Price = 30000},
            new Product{Id = 107, Name = "Keyboard", Company = "Microsoft", Price = 8000},
            new Product{Id = 108, Name = "Mobile", Company = "MI", Price = 12000},
        };

        //LINQ to Object

        // display products whose price is >10000

        /*  var qry = from p in products
                    where p.Price>10000
                    select p;
  */
        // display products of name company dell

        /* var qry = from p in products
                   where p.Company.Contains("Dell")
                   select p;*/

        //display products of name company start with M 

        /*var qry = from p in products
                  where p.Company.StartsWith("M")
                  select p;*/

        //order by price

        /* var qry = from p in products
                   where p.Price > 10000
                   orderby p.Price
                   select p;*/

        //LAMBDA expression

        // display products whose price is >10000

        //   var qry = products.Where<Product>(x=>x.Price>10000).ToList();

        // display products of name company dell

        // var qry = products.Where(x=>x.Company.Contains("Dell")).ToList();

        //display products of name company start with M 

        //  var qry = products.Where(x => x.Company.StartsWith("M")).ToList();

        //Order By Name whose price >10000

        /*   var qry = products.Where(x=>x.Price>10000).OrderBy(x=>x.Name).ToList();

       foreach (var item in qry)
       {
           Console.WriteLine(item);
       }

       Console.WriteLine("Single Row by LINQOject : ");

       var qry2 = from p in products
                  where p.Id==102
                  select p;

       foreach (var item in qry2)
       {
           Console.WriteLine(item);
       }

       Console.WriteLine("Single Row by LAMBDA : ");
       //for single record
       var qry1 = products.Where(x => x.Id == 101).FirstOrDefault();
       Console.WriteLine(qry1);
*/

        //Assignments

        //      Using LINQ query

        //Display all products using LINQ query
        /*
                var qry = from p in products
                          select p;
        */

        //Display products whose price is greater than 15000
        /*
                var qry = from p in products
                          where p.Price > 15000
                          select p;
        */

        //Display products whose price is in between 10000 to 40000

        /* var qry = from p in products
                   where p.Price >= 10000 && p.Price <= 40000
                   select p;
 */
        //Display products of Dell company
        /*
                var qry = from p in products
                          where p.Company.Contains("Dell")
                          select p;
        */
        //Display all company laptops
        /*
                var qry = from p in products
                          where p.Name.Contains("Laptop")
                          select p;
        */

        //Display products whose company name start with ‘M’
        /*
                var qry = from p in products
                          where p.Company.StartsWith("M")
                          select p;
        */
        //Display all company mouse whose price is less than 10000
        /*
                var qry = from p in products
                          where p.Name.Contains("Mouse") && p.Price<10000
                          select p;
        */
        //Display all products descending order by their price
        /*
                var qry = from p in products
                          orderby p.Price descending
                          select p;
        */
        //Display all products accessing order by their company name

        /* var qry = from p in products
                   orderby p.Company
                   select p;
 */
        //Display all keyboards accessing order by their price
        /*
                var qry = from p in products
                          where p.Name.Contains("keyboard")
                          orderby p.Price
                          select p;
        
*/

        //  Using Lambda Expressions

        //Display all products descending order by their price

        // var qry = products.OrderByDescending(x=>x.Price).ToList();

        //Display product whose Id is 5

        /*  var qry1 = products.Where(x => x.Id == 5).FirstOrDefault();
          Console.WriteLine(qry1);*/

        //Display all products whose price less than 5000

        // var qry = products.Where(x=>x.Price<5000).ToList();

        //Display 3 products which have maximum price

        //  var qry = products.OrderByDescending(x => x.Price).Take(3);

        //Display 5 products which have minimum price

        var qry = products.OrderBy(x => x.Price).Take(5);

        foreach (var item in qry)
        {
            Console.WriteLine(item);
        }

    }
}
