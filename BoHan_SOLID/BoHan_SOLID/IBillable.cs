using System;
namespace BoHan_SOLID
{
    public interface IBillable
    {
        int GetUsage();
        decimal GetCharges(int multiplier, decimal fees);
    }

    public class CustomerOffering : Product, IBillable {

    }

    public class ServiceProduct : CustomerOffering {

    }

    public class LicensedProduct : CustomerOffering {

    }
}
