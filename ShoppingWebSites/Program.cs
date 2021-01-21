using System;

namespace ShoppingWebSites
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products();
            product1.productName = "ASUS";
            product1.productDisk = "1 TB HDD";
            product1.productRam = "16 GB RAM";
            product1.productPrice = 12.999;

            Products product2 = new Products();
            product2.productName = "MSI";
            product2.productDisk = "1 TB HDD + 128 GB SSD";
            product2.productRam = "16 GB RAM";
            product2.productPrice = 13.999;

            Products product3 = new Products();
            product3.productName = "ALIENWARE";
            product3.productDisk = "500 GB HDD + 500 GB SSD";
            product3.productRam = "16 GB RAM";
            product3.productPrice = 14.999;

            Products[] product = new Products[] {product1, product2, product3};

            foreach (var Products in product)
            {
                Console.WriteLine(Products.productName);
                Console.WriteLine(Products.productDisk);
                Console.WriteLine(Products.productRam);
                Console.WriteLine(Products.productPrice);
            }

            for (int p = 0; p < product.Length; p++)
            {
                Console.WriteLine(product[p].productName);
                Console.WriteLine(product[p].productDisk);
                Console.WriteLine(product[p].productRam);
                Console.WriteLine(product[p].productPrice);
            }

            int x = 0;
            while (x < product.Length)
            {
                Console.WriteLine(product[x].productName);
                Console.WriteLine(product[x].productDisk);
                Console.WriteLine(product[x].productRam);
                Console.WriteLine(product[x].productPrice);

                x++;
            }
        }

    }
    class Products
    {
        public string productName { get; set; }
        public string productRam { get; set; }
        public string productDisk { get; set; }
        public double productPrice { get; set; }

    }
}
