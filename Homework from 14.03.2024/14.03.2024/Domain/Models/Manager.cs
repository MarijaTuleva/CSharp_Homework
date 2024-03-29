﻿using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Manager : Employee
    {
        public double Bonus { get; set; }

        public Manager(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Bonus = 0;
            Salary = salary;
            Role = Role.Manager;
        }
        public override double GetSalary()
        {
            return Salary + Bonus;
        }

        public void AddBonus(double bonus)
        {
            Bonus += bonus;
        }
    }
}
