using C48_G01_L01.DataSources;

namespace C48_G01_L01

{
    internal class Program
    {
        static void Main(string[] args)
        {
                //Q1
            var result1 = Source.ProductList.Where(p => p.Category == "Seafood");

            foreach (var p in result1)
            {
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            }

            //Q2
            var result2 = Source.ProductList.Select(p => p.ProductName);

            foreach (var name in result2)
            {
                Console.WriteLine(name);
            }

            //Q3
            var result3 = Source.ProductList.OrderBy(p => p.UnitPrice);

            foreach (var p in result3)
            {
                Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
            }

            //Q4
            var result4 = Source.ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            foreach (var p in result4)
            {
                Console.WriteLine(p);
            }

            //Q5
            var result5 = Source.ProductList.Where(p => p.UnitsInStock > 0
             && p.Category == "Condiments");

            foreach (var p in result5)
            {
                Console.WriteLine(p);
            }

            //Q6
            var result6 = Source.ProductList
    .Select(p => new
    {
        Name = p.ProductName,
        Price = p.UnitPrice,
        StockStatus = p.UnitsInStock > 0
            ? "Available"
            : "Out of Stock"
    });

            foreach (var p in result6)
            {
                Console.WriteLine(
                    $"{p.Name} - {p.Price} - {p.StockStatus}");
            }

            //Q7
            var result7 = Source.ProductList            
    .Select((p, index) => new
    {
        Position = index + 1,
        p.ProductName
    });

            foreach (var p in result7)
            {
                Console.WriteLine($"{p.Position}. {p.ProductName}");
            }

            //Q8
            var result8 = Source.ProductList
    .OrderBy(p => p.Category)
    .ThenByDescending(p => p.UnitPrice);

            foreach (var p in result8)
            {
                Console.WriteLine(
                    $"{p.Category} - {p.ProductName} - {p.UnitPrice}");
            }


            //Q9
            var result9 = Source.ProductList    
    .Where(p => p.Category == "Beverages")
    .OrderByDescending(p => p.UnitsInStock)
    .Select(p => new
    {
        p.ProductName,
        p.UnitsInStock
    });

            foreach (var p in result9)
            {
                Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");
            }

            //Q10
            var result10 =
    from c in Source.CustomerList
    from o in c.Orders
    where o.OrderDate.Year >= 1997
    select new
    {
        c.CustomerID,
        o.OrderDate
    };

            foreach (var order in result10)
            {
                Console.WriteLine(
                    $"{order.CustomerID} - {order.OrderDate:d}");
            }

            //Q11
            var result11 = Source.ProductList
    .Select((p, index) => new
    {
        Position = index + 1,
        ProductName = p.ProductName
    });

            foreach (var p in result11)
            {
                Console.WriteLine($"{p.Position}. {p.ProductName}");
            }

            //Q12
            string[] Arr =
{
    "aPPLE", "AbAcUs", "bRaNcH",
    "BlUeBeRrY", "ClOvEr", "cHeRry"
};

            var result12 = Arr
                .OrderBy(s => s.Length)
                .ThenBy(s => s, StringComparer.OrdinalIgnoreCase);

            foreach (var word in result12)
            {
                Console.WriteLine(word);
            }

            //Q13
            var result13 = Arr
           .Where(s => s.Length > 1 &&
                       char.ToLower(s[1]) == 'i')
           .Reverse();

            foreach (var word in result13)
            {
                Console.WriteLine(word);
            }










        }
    }
}
