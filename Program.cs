using Microsoft.EntityFrameworkCore;
using Wahome.CosmosDB.Data;
using Wahome.CosmosDB.Models;

using (var wahomeContext = new WahomeContext())
{

    //#region Inserting Employees

    //var employee1 = new Employee()
    //{
    //    Id = Guid.NewGuid().ToString(),
    //    LastName = "Wahome",
    //    FirstName = "Jipheens",
    //    Title = "Sales Representative",
    //    BirthDate = new DateTime(1998, 12, 08),
    //    HireDate = new DateTime(2022, 05, 01),
    //    Address = "Utawala Embakasi ",
    //    City = "Nairobi",
    //    PostalCode = "401",
    //    Country = "Kenya",
    //    HomePhone = "0708 586 099"
    //};

    //var employee2 = new Employee()
    //{
    //    Id = Guid.NewGuid().ToString(),
    //    LastName = "Doe",
    //    FirstName = "John",
    //    Title = "Human Resource",
    //    BirthDate = new DateTime(2001, 11, 06),
    //    HireDate = new DateTime(2011, 12, 01),
    //    Address = "507 Moi Ave",
    //    City = "Nairobi",
    //    PostalCode = "112",
    //    Country = "Nairobi",
    //    HomePhone = "0708 803 881"
    //};

    //wahomeContext.Employees?.Add(employee1);
    //wahomeContext.Employees?.Add(employee2);

    //await wahomeContext.SaveChangesAsync();

    //Console.WriteLine("Employee records inserted successfully...");

    //#endregion

    //    //#region Inserting Customer

    //    Customer customer = new Customer()
    //    {
    //        Id = Guid.NewGuid().ToString(),
    //        CompanyName = "BCloud",
    //        ContactName = "ketty perry",
    //        ContactTitle = "Sales Representative",
    //        Address = "Obere Str. 57",
    //        City = "Nakuru",
    //        Region = null,
    //        PostalCode = "12209",
    //        Country = "Kenya",
    //        Phone = "254-0074321",
    //        Orders = new List<Order>()
    //        {
    //            new Order()
    //            {
    //                Id = Guid.NewGuid().ToString(),
    //                OrderDate = new DateTime(2023,08,25),
    //                RequiredDate = new DateTime(2023,09,22),
    //                ShippedDate = new DateTime(2023,09,02),
    //                ShipVia = 1,
    //                Freight = 29.46,
    //                ShipName = "BCloud",
    //                ShipAddress = "Obere Str. 57",
    //                ShipCity = "Nakuru",
    //                ShipRegion = null,
    //                ShipPostalCode = "12209",
    //                ShipCountry = "Kenya"
    //            },
    //            new Order()
    //            {

    //                Id = Guid.NewGuid().ToString(),
    //                OrderDate = new DateTime(2023,10,03),
    //                RequiredDate = new DateTime(2023,10,31),
    //                ShippedDate = new DateTime(2023,10,13),
    //                ShipVia = 2,
    //                Freight = 61.02,
    //                ShipName = "Brooks",
    //                ShipAddress = "Odinga Str",
    //                ShipCity = "Kisumu",
    //                ShipRegion = null,
    //                ShipPostalCode = "12209",
    //                ShipCountry = "Kenya"
    //            },
    //            new Order()
    //            {
    //                Id= Guid.NewGuid().ToString(),
    //                OrderDate = new DateTime(2023,10,13),
    //                RequiredDate = new DateTime(2023,11,24),
    //                ShippedDate = new DateTime(2023,10,21),
    //                ShipVia =  1,
    //                Freight = 23.94,
    //                ShipName = "Rovers",
    //                ShipAddress = "Kenyatta ave.",
    //                ShipCity = "Nairobi",
    //                ShipRegion = null,
    //                ShipPostalCode = "12209",
    //                ShipCountry = "Kenya",
    //            }
    //        }
    //    };

    //    wahomeContext.Customers?.Add(customer);
    //    await wahomeContext.SaveChangesAsync();

    //    Console.WriteLine("Customer record inserted successfully...");

    ////#endregion

    //#region Get Employees

    //if (wahomeContext.Employees != null)
    //{
    //    var employees = await wahomeContext.Employees.ToListAsync();
    //    Console.WriteLine("");

    //    foreach (var employee in employees)
    //    {
    //        Console.WriteLine("First Name : " + employee.FirstName);
    //        Console.WriteLine("Last Name : " + employee.LastName);
    //        Console.WriteLine("Hire Date : " + employee.HireDate);
    //        Console.WriteLine("--------------------------------\n");
    //    }
    //}

    //#endregion

    #region Get an Employee

    if (wahomeContext.Employees != null)
    {
        var employee = await wahomeContext.Employees
            .Where(e => e.FirstName == "John")
            .FirstOrDefaultAsync();

        Console.WriteLine("");

        Console.WriteLine("First Name : " + employee?.FirstName);
        Console.WriteLine("Last Name : " + employee?.LastName);
        Console.WriteLine("Hire Date : " + employee?.HireDate);
        Console.WriteLine("--------------------------------\n");
    }

    #endregion

    //#region Update an Employee

    //if (wahomeContext.Employees != null)
    //{
    //    var employee = await wahomeContext.Employees
    //        .Where(e => e.FirstName == "John")
    //        .FirstOrDefaultAsync();

    //    if (employee != null)
    //    {
    //        employee.LastName = "Doe";
    //        employee.HireDate = new DateTime(2002, 12, 01);

    //        await wahomeContext.SaveChangesAsync();

    //        Console.WriteLine("\nRecord has been updated.\n");
    //    }
    //}

    //#endregion

    //#region Delete an Employee

    //if (wahomeContext.Employees != null)
    //{
    //    var employee = await wahomeContext.Employees
    //        .Where(e => e.FirstName == "John")
    //        .FirstOrDefaultAsync();

    //    if (employee != null)
    //    {
    //        wahomeContext.Employees.Remove(employee);
    //        await wahomeContext.SaveChangesAsync();

    //        Console.WriteLine("\nRecord has been deleted.\n");
    //    }
    //}

    //#endregion 

}