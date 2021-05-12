using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;


namespace BlazorApp.Pages
{
    public class EmployeeBase : ComponentBase
    {
        public IEnumerable<Employee> Employees { get; set; }

        private void LoadEmployees()
        {
            System.Threading.Thread.Sleep(3000);
            Employee e1 = new Employee
            {
                FirstName = "Zhibek",
                LastName = "Abdykalykova",
                Birthday = new DateTime(2000, 02, 04),
            };
            e1.Projekts.Add("Softwareprojekt");
            Employee e2 = new Employee
            {
                FirstName = "Zhibek",
                LastName = "Abdykalykova",
                Birthday = new DateTime(2000, 02, 04)

            };
            e2.Projekts.Add("Softwareprojekt");

            Employee e3 = new Employee
            {
                FirstName = "Zhibek",
                LastName = "Abdykalykova",
                Birthday = new DateTime(2000, 02, 04)
            };
            e3.Projekts.Add("Softwareprojekt");

            Employee e4 = new Employee
            {
                FirstName = "Zhibek",
                LastName = "Abdykalykova",
                Birthday = new DateTime(2000, 02, 04)
            };
            e4.Projekts.Add("Softwareprojekt");

            Employees = new List<Employee> { e1, e2, e3, e4 };
        }


        protected override async Task OnInitializedAsync()
        {
            await Task.Run(LoadEmployees);
        }
    }
}
