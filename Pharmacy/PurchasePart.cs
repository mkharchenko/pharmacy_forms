using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class PurchasePart : Medicine
    {
        public int amount { get; private set; }
        private double discount;
        public double getDiscount
        {
            get
            {
                return discount;
            }
            private set
            {
                discount = value;
            }
        }
        public int Discount
        {
            get
            {
                return Convert.ToInt32(discount * 100);
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    discount = Convert.ToDouble(value) / 100;
                }
            }
        }
        public string prescription_number { get; private set; }
        public PurchasePart(Medicine med, int amount, int discount, string prescription_number)
            : base(med.medicine_title, med.price, med.prescription_needed, med.provider_title, med.LeftOver)
        {
            this.amount = amount;
            Discount = discount;
            this.prescription_number = prescription_number;
        }
        public override string ToString()
        {
            return medicine_title + ", Сумма: " + getSum().ToString() + ", Скидка: " + Discount.ToString();
        }
        public double getSum()
        {
            return price * amount * (1 - discount);
        }
    }
}
