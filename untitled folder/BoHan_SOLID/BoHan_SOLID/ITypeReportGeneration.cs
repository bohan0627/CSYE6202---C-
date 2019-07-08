using System;
namespace BoHan_SOLID
{
    //This is for demonstrating Open Closed Principle
    //ITypeReportGeneration is open for extension, but closed for modification
    public class ITypeReportGeneration
    {
        public ITypeReportGeneration()
        {
        }

        public virtual void GenerateCompanyTypeReport(Company co) {
            Console.WriteLine("General Report Generated");
        }
    }

    public class WordGeneration: ITypeReportGeneration { 
        public override void GenerateCompanyTypeReport(Company co) {
            Console.WriteLine("Word Report Generated");
        }
    }

    public class PdfGeneration: ITypeReportGeneration {
        public override void GenerateCompanyTypeReport(Company co)
        {
            Console.WriteLine("PDF Report Generated");
        }
    }
}
