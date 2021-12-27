using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class Purchase
    {
        public List<PurchasePart> purchases;
        public int purchase_id { get; private set; }
        private Employee pharmacist;
        private DateTime purchase_date;
        private double sum;
        public Purchase()
        {
            purchases = new List<PurchasePart>();
        }
        public Purchase(int purchase_id, Employee pharmacist, DateTime purchase_date, double sum)
        {
            purchases = new List<PurchasePart>();
            this.purchase_id = purchase_id;
            this.pharmacist = pharmacist;
            this.purchase_date = purchase_date;
            this.sum = sum;
        }
        public double getSum()
        {
            double sum = 0;
            foreach (var p in purchases)
            {
                sum += p.getSum();
            }
            return sum;
        }
        public void DeletePurchasePart(PurchasePart pp)
        {
            foreach (var p in purchases.ToList())
            {
                if (p == pp)
                {
                    purchases.Remove(p);
                }
            }
        }
        public void CommitPurchase(Employee pharmacist)
        {
            DBConnection.getInstance().AddPurchase(pharmacist);
            int purchase_id = DBConnection.getInstance().FindLastPurchase(pharmacist);
            foreach (var p in purchases)
            {
                DBConnection.getInstance().AddPurchasePart(p, purchase_id);
            }
        }
        public bool isInPurchase(Medicine m)
        {
            foreach (var p in purchases)
            {
                if (p.medicine_title == m.medicine_title && p.price == m.price && p.provider_title == m.provider_title)
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            return purchase_date.ToString() + ", Фармацевт: " + pharmacist.ToString() + ", Сумма: " + sum.ToString();
        }
        public Employee getPharmacist()
        {
            return pharmacist;
        }
    }
}
