using Jwt.Models;

namespace Jwt.Constants
{
    public class EmployeeConstants
    {
        public static List<Employee> Employees = new List<Employee>()
        {
            new Employee() {Fullname="Florencia Prados", Email = "fprados@gmail.com"},
            new Employee() {Fullname="Nicole Prandi", Email = "nprandi@gmail.com"}

        };
    }
}
