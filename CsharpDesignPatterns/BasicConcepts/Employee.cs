using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDesignPatterns.BasicConcepts
{
    class Employee
    {
        // you can either hard code the value
        // or use constructor
        // or use setter method

        public int empId;
        public string empName;
        public int grade;
        public string company;

        IEmail email;
        // only set up the feild will cause null reference error
        // in this case should hard code the value or put it in constructor

        // if a value might be changed frequently, then use setter and getter
        public double salary { set; get; }

        // hard code the value only if the value is constant for this class
        public string sepcies = "Human";

        // absolutey required value or value will be initailized >> should use a constructor
        public Employee(int empId, string empName, IEmail email)
        {
            this.empId = empId;
            this.empName = empName;
            this.email = email;
        }

        public void NotifyEmployee() 
        {
            email.SendMail();
        }
    }

    class TestEmployee 
    {
        static void SubMain() 
        {
            Employee obj = new Employee(100, "John", new GoogleEmail());

            // same concept: super class(interface) object can assign sub class obj
            IEmail email = new OutlookEmail();
            Employee obj2 = new Employee(200, "Antony", email);
        }
    }
}
