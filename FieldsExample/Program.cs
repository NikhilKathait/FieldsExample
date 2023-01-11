class Sample
{
    //Using ClassLibrary1 in reference
    static void Main()
    {
        //Create reference varaibles
        Product product1, product2, product3;

        //Create objects
        product1 = new Product();
        product2 = new Product();
        product3 = new Product();

        //Intializing Fields
        product1.productID = 1001;
        product1.productName = "Mobile";
        product1.cost = 20000;
        product1.quantityInStock = 1200;

        product2.productID = 1002;
        product2.productName = "Laptop";
        product2.cost = 45000;
        product2.quantityInStock = 3400;

        product3.productID = 1003;
        product3.productName = "Speakers";
        product3.cost = 36000;
        product3.quantityInStock = 800;

        //Display value from fields
        System.Console.WriteLine("\nProduct 1");
        System.Console.WriteLine("Product ID: " + product1.productID);
        System.Console.WriteLine("Product Name: " + product1.productName);
        System.Console.WriteLine("Product cost: " + product1.cost);
        System.Console.WriteLine("Product quantityInStock: " + product1.quantityInStock);

        System.Console.WriteLine("\nProduct 2");
        System.Console.WriteLine("Product ID: " + product2.productID);
        System.Console.WriteLine("Product Name: " + product2.productName);
        System.Console.WriteLine("Product cost: " + product2.cost);
        System.Console.WriteLine("Product quantityInStock: " + product2.quantityInStock);

        System.Console.WriteLine("\nProduct 3");
        System.Console.WriteLine("Product ID: " + product3.productID);
        System.Console.WriteLine("Product Name: " + product3.productName);
        System.Console.WriteLine("Product cost: " + product3.cost);
        System.Console.WriteLine("Product quantityInStock: " + product3.quantityInStock);

        System.Console.ReadKey();
    }
}