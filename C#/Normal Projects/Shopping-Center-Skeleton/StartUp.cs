using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_Center
{
    public class StartUp
    {
        private static readonly ProductList ProductList = new ProductList();

        public static void Main()
        {
            var count = int.Parse(Console.ReadLine());

            for (var i = 0; i < count; i++)
            {
                var command = Console.ReadLine();
                ProcessCommand(command);
            }
        }

        private static void ProcessCommand(string input)
        {
            input = input.Trim();

            var index = input.IndexOf(' ');
            var command = input.Substring(0, index);

            input = input.Substring(index + 1);

            var args = input.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            string result;

            switch (command)
            {
                case "AddProduct":
                    result = AddProduct(args);
                    break;
                case "DeleteProducts":
                    result = DeleteProducts(args);
                    break;
                case "FindProductsByName":
                    result = FindProductsByName(args);
                    break;
                case "FindProductsByProducer":
                    result = FindProductsByProducer(args);
                    break;
                case "FindProductsByPriceRange":
                    result = FindProductsByPriceRange(args);
                    break;
                default:
                    result = "Invalid Command";
                    break;
            }

            Console.WriteLine(result);
        }

        private static string FindProductsByPriceRange(string[] args)
        {
            List<Product> result = ProductList
                .FindProductsByPriceRange(decimal.Parse(args[0]), decimal.Parse(args[1]))
                .ToList();
            if (result.Count == 0)
            {
                return "No products found";
            }
            return string.Join("\n", result);
        }

        private static string FindProductsByProducer(string[] args)
        {
            List<Product> result = ProductList.FindProductsProducer(args[0]).ToList();
            if (result.Count == 0)
            {
                return "No products found";
            }
            return string.Join("\n", result);
        }

        private static string FindProductsByName(string[] args)
        {
            List<Product> result = ProductList.FindProductsByName(args[0]).ToList();
            if (result.Count == 0)
            {
                return "No products found";
            }
            return string.Join("\n", result);
        }

        private static string ConcatenateProducts(IEnumerable<Product> products)
        {
            //TODO: implement using ProductList methods
            return null;
        }

        private static string DeleteProducts(string[] args)
        {
            string name;
            string producer;
            int result;
            if (args.Length > 1)
            {
                name = args[0];
                producer = args[1];
                result = ProductList.DeleteByNameAndProducer(name, producer);

            }
            else
            {
                producer = args[0];
                result = ProductList.DeleteByProducer(producer);
            }
            if (result == 0)
            {
                return "No products found";
            }
            return $"{result} products deleted";
        }

        private static string AddProduct(string[] args)
        {
            string name = args[0];
            decimal price = decimal.Parse(args[1]);
            string producer = args[2];
            ProductList.AddProduct(name, price, producer);
            return "Product added";
        }
    }
}
