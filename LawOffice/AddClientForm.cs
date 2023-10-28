using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawOffice
{
    public partial class AddClientForm : Form
    {
        int passport, phone, id;

        public AddClientForm()
        {
            InitializeComponent();
            IDBox.Text = (DB.idClient.Count).ToString();
        }           
        private void PassportBox_MouseUp(object sender, MouseEventArgs e)
        {
            PassportBox.SelectionStart = 0;
        }

        private void PhoneBox_MouseUp(object sender, MouseEventArgs e)
        {
            PhoneBox.SelectionStart = 0;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            int passport, phone;
            DB dataBase = new DB();
            Client client = new Client();

            int.TryParse(string.Join("", PassportBox.Text.Where(c => char.IsDigit(c))), out passport);
            int.TryParse(string.Join("", PhoneBox.Text.Where(c => char.IsDigit(c))), out phone);

            client.id = int.Parse(IDBox.Text);
            client.fullName = FullNameBox.Text;
            client.passport = PassportBox.Text;
            client.phone = PhoneBox.Text;

            string quertystring = $"insert into Clients(fullName, passport, phone) values('{client.fullName}', '{client.passport}', '{client.phone}')";

            SqlCommand command = new SqlCommand(quertystring, dataBase.GetConnection());

            dataBase.OpenConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                this.Visible = false;
                DB.OkClick = true;
            }
            else {
                MessageBox.Show("Error command", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /*DB.fullName.Add(FullNameBox.Text);
            DB.passport.Add(passport);
            DB.phone.Add(phone);
            DB.idClient.Add(id);*/
            //DB.phone = int.Parse(PhoneBox.Text);
        }
    }
}
