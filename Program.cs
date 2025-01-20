using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    using System;
    using System.Collections.Generic;

    
    public class Worker
    {

        public string FullName { get; set; }
        public double Salary { get; set; }


        public Worker(string fullName, double salary)
        {
            FullName = fullName;
            Salary = salary;
        }
        public virtual void Show()
        {
            Console.WriteLine($"Работник: ФИО={FullName}, Зарплата={Salary}");
        }
        public virtual double GetSalary()
        {
            return Salary;
        }
    }
    public class Engineer : Worker
    {
        public string Specialty { get; set; }

        public Engineer(string fullName, double salary, string specialty)
            : base(fullName, salary)
        {
            Specialty = specialty;
        }


        public override void Show()
        {
            Console.WriteLine($"Инженер: ФИО={FullName}, Зарплата={GetSalary()}, Специальность={Specialty}");
        }


        public override double GetSalary()
        {
            return Salary;
        }
    }


    public class Seller : Worker
    {
        public double SalesVolume { get; set; }
        public double CommissionRate { get; set; }

        public Seller(string fullName, double salary, double salesVolume, double commissionRate)
            : base(fullName, salary)
        {
            SalesVolume = salesVolume;
            CommissionRate = commissionRate;
        }


        public override void Show()
        {
            Console.WriteLine($"Продавец: ФИО={FullName}, Зарплата={GetSalary()}");
        }


        public override double GetSalary()
        {
            return Salary + (SalesVolume * CommissionRate);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Worker> workers = new List<Worker>
        {
            new Engineer("Иванов Иван Иванович", 50000, "Системный инженер"),
            new Seller("Петров Петр Петрович", 30000, 150000, 0.1)
        };


            foreach (var worker in workers)
            {
                worker.Show();
                Console.WriteLine();
            }
        }
    }
}