using System;
namespace BoHan_SOLID
{
    public abstract class AbstractPerson
    {
        public int Id { set; get; }
        public int Age { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public AbstractPerson()
        {
        }
    }

    public class Person : AbstractPerson {
        public Boolean IsEmployed { set; get; }
    }

    public class Employee : Person, IComparable<Employee> {
        public int EmployeeId { set; get; }
        public decimal Wage { set; get; }

        public Employee() {

        }

        public Employee(int Id, string FirstName, string LastName, int Age, int EmployeeId, decimal Wage) {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.EmployeeId = EmployeeId;
            this.Wage = Wage;
        }

        public int CompareTo(Employee other)
        {
            return string.Compare(this.LastName, other.LastName);
        }

        public int CompareById(Employee e1, Employee e2) {
            return e1.Id.CompareTo(e2.Id);
        }

        public int CompareByAge(Employee e1, Employee e2) {
            return e1.Age.CompareTo(e2.Age);
        }

        public int CompareByFirstName(Employee e1, Employee e2) {
            return string.Compare(e1.FirstName, e2.FirstName);
        }

        public int CompareByLastName(Employee e1, Employee e2)
        {
            return string.Compare(e1.LastName, e2.LastName);
        }
    }
}
