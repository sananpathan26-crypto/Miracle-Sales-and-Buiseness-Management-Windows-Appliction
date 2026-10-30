using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miracle
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }

        // This makes the ListBox or ComboBox show the company name
        public override string ToString()
        {
            return CompanyName;
        }
    }

}
