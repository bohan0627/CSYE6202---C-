using System;
namespace BoHan_SOLID
{
    public abstract class AbstractPersonFactory
    {
        public AbstractPersonFactory()
        {
        }

        public abstract AbstractPerson GetObject(int Id, string FirstName, string LastName, int Age, int EmployeeId, decimal Wage);
    }

    public class EmployeeFactory : AbstractPersonFactory
    {
        public override AbstractPerson GetObject(int Id, string FirstName, string LastName, int Age, int EmployeeId, decimal Wage)
        {
            return new Employee(Id, FirstName, LastName, Age, EmployeeId, Wage);
        }
    }
}
