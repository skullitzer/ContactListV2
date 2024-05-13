using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListV2.Business
{
    public class IndividualContact : Contact
    {
        private float _annualSalary;
        private int _numberOfChildren;

        public float AnnualSalary { get => _annualSalary; set => _annualSalary = value; }
        public int NumberOfChildren { get => _numberOfChildren; set => _numberOfChildren = value; }

        public override string ToString()
        {
            return "Contact Type: Individual, " + base.ToString() + ", Annual Salary: " + _annualSalary.ToString() + ", Number of Children: " + _numberOfChildren.ToString();
        }

        public IndividualContact() : base()
        {
            _annualSalary = 0;
            _numberOfChildren = 0;
        }
    }
}
