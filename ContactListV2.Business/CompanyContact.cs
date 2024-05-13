using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListV2.Business
{
    public class CompanyContact : Contact
    {
        private string _industry;
        private int _numberOfEmployees;

        public string Industry { get => _industry; set => _industry = value; }
        public int NumberOfEmployees { get => _numberOfEmployees; set => _numberOfEmployees = value; }

        public override string ToString()
        {
            return "Contact Type: Company, " + base.ToString() + ", Industry: " + _industry.ToString() + ", Number of Employees: " + _numberOfEmployees.ToString();
        }

        public CompanyContact() : base()
        {
            _industry = "";
            _numberOfEmployees = 0;
        }
    }
}
