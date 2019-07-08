using System;
namespace BoHan_SOLID
{
    public abstract class AbstractCustomerOfferingFactory
    {
        public AbstractCustomerOfferingFactory()
        {
        }

        public abstract Company GetObject(string csvData);
    }

    public class LicencedProductFactory : AbstractCustomerOfferingFactory
    {
        public override Company GetObject(string csvData)
        {
            return Company
        }
    }

    public class ServiceProductFactory : AbstractCustomerOfferingFactory
    {
        public override Company GetObject(string csvData)
        {
            throw new NotImplementedException();
        }
    }
}
