using System.Globalization;

namespace Wynshop_HackerRank
{
    interface ICategory
    {
        int Id { get; set; }
        string Name { get; set; }
        List<IProduct> Products { get; set; }
        void AddProduct(IProduct product);
    }
    interface IProduct
    {
        int Id { get; set; }
        string Name { get; set; }
        decimal Price { get; set; }
    }

    interface ICompany
    {
        //The top category name by product count
        string GetTopCategoryNameByProductCount();
        //The products are added to more than one category
        List<IProduct> GetProductsBelongsToMultipleCategory();
        //Top category according to the total price of its products
        (string categoryName, decimal totalValue) GetTopCategoryBySumOfProductPrices();
        //The list of categories with the sum of the prices of the products
        List<(ICategory category, decimal totalValue)> GetCategoriesWithSumOfTheProductPrices();
    }

    /*
     * Create Category,Product and Company classes by implementing
     * ICategory,
     * IProcduct,
     * ICompany interfaces.
     */

    class Category : ICategory
    {
        public Category(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
            this.Products = new List<IProduct>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<IProduct> Products { get; set; }

        public void AddProduct(IProduct product)
        {
            this.Products.Add(product);
        }
    }

    class Product : IProduct
    {
        public Product(int Id, string Name, decimal Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.Price = Price;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Company : ICompany
    {
        public Company(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
            this.Categories = new List<ICategory>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public List<ICategory> Categories { get; set; }

        public void AddCategory(ICategory category)
        {
            this.Categories.Add(category);
        }
        public List<(ICategory category, decimal totalValue)> GetCategoriesWithSumOfTheProductPrices()
        {
            List<(ICategory, decimal)> categoriesWithProductsPricesSum = new List<(ICategory, decimal)>();

            foreach (ICategory category in this.Categories)
            {
                decimal currCategoryProductsPricesSum = category.Products.Select(p => p.Price).Sum();
                categoriesWithProductsPricesSum.Add((category, currCategoryProductsPricesSum));
            }
            return categoriesWithProductsPricesSum;
        }

        public List<IProduct> GetProductsBelongsToMultipleCategory()
        {
            Dictionary<IProduct, int> productOccurenceInCategories = new Dictionary<IProduct, int>();

            foreach (ICategory category in Categories)
            {
                foreach (IProduct product in category.Products)
                {
                    if (!productOccurenceInCategories.ContainsKey(product))
                    {
                        productOccurenceInCategories[product] = 0;
                    }
                    productOccurenceInCategories[product]++;
                }
            }

            List<IProduct> commonProducts = productOccurenceInCategories
                .Where(x => x.Value > 1)
                .Select(x => x.Key)
                .ToList();
                
            return commonProducts;

        }

        public (string categoryName, decimal totalValue) GetTopCategoryBySumOfProductPrices()
        {
            ICategory? topCategory = null;
            decimal topCategoryProductPricesSum = 0m;
            foreach (ICategory category in this.Categories)
            {
                decimal currCategoryProductPricesSum = category.Products.Select(p => p.Price).Sum();
                if (currCategoryProductPricesSum > topCategoryProductPricesSum)
                {
                    topCategoryProductPricesSum = currCategoryProductPricesSum;
                    topCategory = category;
                }

            }
            return (topCategory.Name, topCategoryProductPricesSum);

        }

        public string GetTopCategoryNameByProductCount()
        {
            List<ICategory> categories = this.Categories
                .OrderByDescending(x => x.Products.Count)
                .ToList();
            return categories[0].Name;
        }
    }

    class Solution
    {
        public static void Main(string[] args)
        {
           // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            var company = new Company(1, "Company 1");
            List<IProduct> products = new List<IProduct>();
            List<ICategory> categories = new List<ICategory>();

            int n = Convert.ToInt32(Console.ReadLine().Trim());
            for (int i = 1; i <= n; i++)
            {
                var a = Console.ReadLine().Trim().Split(" ");
                products.Add(new Product(Convert.ToInt32(a[0]), a[1], Convert.ToInt32(a[2])));
            }

            int m = Convert.ToInt32(Console.ReadLine().Trim());
            for (int i = 1; i <= m; i++)
            {
                var a = Console.ReadLine().Trim().Split(" ");
                categories.Add(new Category(Convert.ToInt32(a[0]), a[1]));
            }

            int p = Convert.ToInt32(Console.ReadLine().Trim());
            for (int i = 1; i <= p; i++)
            {
                var a = Console.ReadLine().Trim().Split(" ");
                var c = categories.FirstOrDefault(x => x.Id == Convert.ToInt32(a[0]));
                var pp = products.FirstOrDefault(x => x.Id == Convert.ToInt32(a[1]));
                if (c != null && pp != null)
                {
                    c.AddProduct(pp);
                }

            }

            foreach (var item in categories)
            {
                company.AddCategory(item);
            }
            var topCategory = company.GetTopCategoryNameByProductCount();
            var commonProducts = company.GetProductsBelongsToMultipleCategory();
            var mostValuableCategory = company.GetTopCategoryBySumOfProductPrices();
            var categoriesWithTotalPrices = company.GetCategoriesWithSumOfTheProductPrices();

           // textWriter.WriteLine("Top category:" + topCategory);
            Console.WriteLine("Top category:" + topCategory);
            //textWriter.WriteLine("Common products:");
            Console.WriteLine("Common products:");
            foreach (var item in commonProducts)
            {
                //textWriter.WriteLine(item.Name);
                Console.WriteLine(item.Name);
            }
            //textWriter.WriteLine("Most valuable category:" + mostValuableCategory.categoryName
            //    + " " + mostValuableCategory.totalValue.ToString("0.0", new NumberFormatInfo() { NumberDecimalSeparator = "." }));
            Console.WriteLine("Most valuable category:" + mostValuableCategory.categoryName
             + " " + mostValuableCategory.totalValue.ToString("0.0", new NumberFormatInfo() { NumberDecimalSeparator = "." }));

            foreach (var item in categoriesWithTotalPrices)
            {
                //textWriter.WriteLine(item.category.Name + " " + item.totalValue.ToString("0.0", new NumberFormatInfo() { NumberDecimalSeparator = "." }));
                Console.WriteLine(item.category.Name + " " + item.totalValue.ToString("0.0", new NumberFormatInfo() { NumberDecimalSeparator = "." }));
            }
            //textWriter.Flush();
          //  textWriter.Close();
        }
    }
}