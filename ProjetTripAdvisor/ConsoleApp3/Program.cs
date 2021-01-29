using DAL;
using System;
using FluentValidation;
using FluentValidation.Results;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Surname="toto";
            customer.Forename = "pcpc";
            //customer.Address = "17 rue";
            CustomerValidator validator = new CustomerValidator();

            ValidationResult results = validator.Validate(customer);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }
            }

            string allMessages = results.ToString("~");

        }
    }
}

/*
BikeStoreRepository repo = new BikeStoreRepository();
var a =  repo.GetProductById(42);
var b = repo.GetProductByName("Trek Fuel EX 5 27.5 Plus - 2017");
var c = repo.GetOrderByCustomerId(450);
*/