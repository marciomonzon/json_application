// See https://aka.ms/new-console-template for more information
using JsonApplication;
using Newtonsoft.Json;

var customers = new List<Customer>
{
    new Customer
    {
        CustomerName = "John",
        Age = 33,
        Email = "john@gmail.com",
        TotalSales = 4000,
        FinalPurchaseDate = new DateTime(2021, 3, 29)
    },
    new Customer
    {
        CustomerName = "George",
        Age = 32,
        Email = "george@gmail.com",
        TotalSales = 6000,
        FinalPurchaseDate = new DateTime(2021, 2, 12)
    },
    new Customer
    {
        CustomerName = "Peter",
        Age = 28,
        Email = "peter@gmail.com",
        TotalSales = 2000,
        FinalPurchaseDate = new DateTime(2021, 1, 10)
    }
};

var customer = new Customer
{
    CustomerName = "James",
    Age = 20,
    Email = "james@gmail.com",
    TotalSales = 5000,
    FinalPurchaseDate = new DateTime(2021, 1, 5)
};

var customerJson = JsonConvert.SerializeObject(customer);
Console.WriteLine(customerJson);

var json = JsonConvert.DeserializeObject<Customer>(customerJson);

Console.ReadKey();
