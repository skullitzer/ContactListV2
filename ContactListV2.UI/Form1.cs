using ContactListV2.Business;
using ContactListV2.Data;

namespace ContactListV2.UI
{
    public partial class Form1 : Form
    {
        private List<Contact> listOfContacts = ContactBinaryData.Load();
        public Form1()
        {
            InitializeComponent();
        }

        private bool AllFieldsAreOk()
        {
            if (cbContactType.Text == "")
            {
                MessageBox.Show("Please select a contact type to proceed!");
                return false;
            }
            else if (txtContactNumber.Text == "")
            {
                MessageBox.Show("Please input a contact number to proceed!");
                return false;
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("Please input a name to proceed!");
                    return false;
            }
            else if (txtPhoneNumber.Text == "" || !Validator.ValidatePhoneNumber(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please input a valid phone number to proceed!");
                return false;
            }
            else if (txtEmail.Text == "" || !Validator.ValidateEmail(txtEmail.Text))
            {
                MessageBox.Show("Please input a valid email to proceed!");
                return false;
            }
            else if (txtAnnualSalary.Text == "" || !Validator.ValidateFloat(txtAnnualSalary.Text))
            {
                MessageBox.Show("Please input a valid annual salary to proceed!");
                return false;
            }
            else if (txtNoOfChildren.Text == "" || !Validator.ValidateInt(txtNoOfChildren.Text))
            {
                MessageBox.Show("Please input valid number of children to proceed!");
                return false;
            }
            else if (txtIndustry.Text == "")
            {
                MessageBox.Show("Please input an industry name to proceed!");
                return false;
            }
            else if (txtNoOfEmployees.Text == "" || !Validator.ValidateInt(txtNoOfEmployees.Text))
            {
                MessageBox.Show("Please input valid number of employees to proceed!");
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!AllFieldsAreOk())
                return;

            Contact contactToAdd;
            if (cbContactType.Text == "Individual")
            {
                IndividualContact individualContact = (IndividualContact)cbContactType.SelectedItem;
            }
        }
    }
}