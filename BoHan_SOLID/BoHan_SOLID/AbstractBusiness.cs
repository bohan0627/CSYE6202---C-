using System;
using System.Collections.Generic;
namespace BoHan_SOLID
{
    public abstract class AbstractBusiness
    {
        public abstract void SortEmployees();
        public abstract void SortClients();
        public abstract void SortItems();
        public AbstractBusiness()
        {
        }
    }

    public class Company : AbstractBusiness {
        public int Id { set; get; }
        public string Name { set; get; }

        private List<AbstractPerson> employees = new List<AbstractPerson>();
        private List<AbstractPerson> clients = new List<AbstractPerson>();
        private List<Product> products = new List<Product>();
    }

    public class IBM : Company {
        public override string ToString()
        {
            return base.ToString();
        }

        public override void SortEmployees()
        {
            throw new NotImplementedException();
        }


    }
}
