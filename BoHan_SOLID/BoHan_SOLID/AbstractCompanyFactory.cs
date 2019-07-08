using System;
namespace BoHan_SOLID
{
    public abstract class AbstractCompanyFactory
    {
        public AbstractCompanyFactory()
        {
        }

        public abstract AbstractBusiness GetObject();
    }

    public class IbmFactory : AbstractCompanyFactory
    {
        public override AbstractBusiness GetObject()
        {
            return new Company();
        }
    }
}
