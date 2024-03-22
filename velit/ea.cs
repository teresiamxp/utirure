// Assume you have a class named Product that represents a product entity
// and a class named ProductRepository that implements the IRepository<Product, int> interface
ProductRepository repo = new ProductRepository();
// Create a new product object with some properties
Product obj = new Product { ID = 1, Name = "Laptop", Price = 999.99 };
// Add the product to the repository
repo.Add(obj);
// Find the product by its ID and store it in a variable
var storedObj = repo.Find(obj.ID);
// Print the product details
Console.WriteLine($"Product ID: {storedObj.ID}");
Console.WriteLine($"Product Name: {storedObj.Name}");
Console.WriteLine($"Product Price: {storedObj.Price}");
