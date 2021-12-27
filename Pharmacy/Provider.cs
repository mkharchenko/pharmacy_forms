using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy
{
    public class Provider
    {
        private string provider_title;
        public string title
        {
            get
            {
                return provider_title;
            }
            set
            {
                if (value != "")
                {
                    provider_title = value;
                }
            }
        }
        public Provider() { }
        public Provider(string title)
        {
            this.title = title;
        }
        public override string ToString()
        {
            return title;
        }
    }
}
