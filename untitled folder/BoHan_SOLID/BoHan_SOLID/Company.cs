using System;
namespace BoHan_SOLID
{
    //This is for demonstrating Single Responsibility Principle
    //Company class is taking one responsibility
    public class Company
    {
        public Company() { 
        }

        public virtual void getCompanyDetails() {
            Console.WriteLine("General Company Type");
        }
    }

    //This is for demonstrating Liskov Substitution Principle
    //The getCompanyDetails method should be overridden, not called from its parent class
    public class PrivateCompany: Company {
        public override void getCompanyDetails()
        {
            Console.WriteLine("Private Company");
        }
    }

    public class PublicCompany: Company {
        public override void getCompanyDetails()
        {
            Console.WriteLine("Public Company");
        }
    }

    //This is for demonstrating Interface Segregation Principle,
    //If we have an inteface for adding and reading company revenue
    //Then we should split it into two interfaces, because someone only needs to add revenue
    //And the same to getting revenue
    public interface IAddCompanyRevenue {
        void AddCompanyRevenue();
    }

    public interface IGetCompanyRevenue {
        void GetCompanyRevenue();
    }
}
