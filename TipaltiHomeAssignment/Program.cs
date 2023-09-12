// See https://aka.ms/new-console-template for more information
using TipaltiHomeAssignment.Models;
using TipaltiHomeAssignment.Utility;

Person p1 = new Person() { FullName = new Name { FirstName = "Grace", LastName = "Hopper"},
    Address = new Address { City = "New York", Street = "0"} };

Person p2 = new Person()
{
    FullName = new Name { FirstName = "Alan", LastName = "Turning" },
    Address = new Address { City = "Bletchly Park", Street = "0" }
};

Person p3 = new Person()
{
    FullName = new Name { FirstName = "Joan", LastName = "Clark" },
    Address = new Address { City = "Bletchly Park", Street = "0" }
};

Person p4 = new Person()
{
    FullName = new Name { FirstName = "Joan", LastName = "Clark" },
    Address = new Address { City = "London", Street = "0" }
};

Person p5 = new Person()
{
    FullName = new Name { FirstName = "Alan", LastName = "Turing" },
    Address = new Address { City = "Cambridge", Street = "0" }
};

PeopleRelations utility = new PeopleRelations();

utility.Init(new[] { p1, p2, p3, p4, p5 });

Console.WriteLine(utility.FindMinRelationLevel(p2, p1));