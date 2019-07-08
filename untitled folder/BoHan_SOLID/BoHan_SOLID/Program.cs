using System;

namespace BoHan_SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Company privateCompany = new PrivateCompany();
            Company publicCompany = new PublicCompany();
            privateCompany.getCompanyDetails();
            publicCompany.getCompanyDetails();
        }
    }
}
