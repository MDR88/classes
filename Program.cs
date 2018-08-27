using System;
using System.Collections.Generic;
namespace Company
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company newCompany = new Company("My Name", new DateTime(2018, 12, 1));

            Employee mike = new Employee()
            {
                firstName = "Mike",
                lastName = "Roberts",
                title = "Software Developer",
                startDate = new DateTime(2018, 5, 21)

            };
            Employee adelaide = new Employee()
            {
                firstName = "Adelaide",
                lastName = "Yoder",
                title = "Software Developer",
                startDate = new DateTime(2018, 5, 21)

            };
            Employee aaron = new Employee()
            {
                firstName = "Aaron",
                lastName = "Miller",
                title = "Software Developer",
                startDate = new DateTime(2018, 5, 21)

            };
            string returnStatement = newCompany.Hire(mike);
            System.Console.WriteLine(returnStatement);
            newCompany.Hire(adelaide);
            newCompany.Hire(aaron);



            foreach (Employee person in newCompany.currentEmployees)
            {
                System.Console.WriteLine($" We hired {person.firstName}");
            }
        }
    }
    // Create three employees


    // Assign the employees to the company

    /*
        Iterate the company's employee list and generate the
        simple report shown above
    */
}