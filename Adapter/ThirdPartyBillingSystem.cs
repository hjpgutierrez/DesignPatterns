﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ThirdPartyBillingSystem
    {
        //ThirdPartyBillingSystem accepts employees information as a List to process each employee salary
        public void ProcessSalary(List<Employee> listEmployee)
        {
            foreach (Employee employee in listEmployee)
            {
                Console.WriteLine("Rs." + employee.Salary + " Salary Credited to " + employee.Name + " Account");
            }
        }
    }
}
