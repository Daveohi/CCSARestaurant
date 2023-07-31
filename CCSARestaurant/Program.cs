// See https://aka.ms/new-console-template for more information
using CCSARestaurant.Core;
using CCSARestaurant.DB;

Console.WriteLine("Hello, World!");

// Establish Database Connection
var sessionFactory = new SessionFactory();
var session = sessionFactory.Session;


//Perform CRUD Operations

//Create
var customer = new Customer { FirstName = "David", Surname = "Ohimai" };
session.Save(customer);
sessionFactory.Commit(session);


//Read
{
var customers = customer.GetCustomer();
session.Save(customers);
}



//Update
{
    session.Update(customer); //update the new data 
    session.Save(customer); //commit the data 
}


//Delete
{
    session.Delete(customer); //delete the record 
    session.Save(customer); //commit it 
}
Console.WriteLine("Done!");
Console.ReadLine();
