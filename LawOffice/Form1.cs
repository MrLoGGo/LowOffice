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
    public partial class Form1 : Form
    {
        int iControl = 0;
        List<Panel> clientList = new List<Panel>();
        Pages pages = new Pages();
        List<Client> clients = new List<Client>();
        DB dataBase = new DB();

        public Form1()
        {
            InitializeComponent();
            pages.Add("MainPage", ref MainPage);
            pages.Add("ClientPage", ref ClientPage);
            pages.Add("CasesPage", ref CasesPage);
            pages.Add("TestPage", ref TestPage);
            pages.OpenPage("MainPage");
        }

        private async void AddClient_ClickAsync(object sender, EventArgs e)
        {

            AddClientForm addClientForm = new AddClientForm();
            addClientForm.ShowDialog();

            while (true)
            {
                await Task.Delay(500);
                if (!addClientForm.Visible && DB.OkClick )
                {
                    //CreateClientPanel(reader.GetString(0));
                    LoadClients();
                    DB.OkClick = false;
                    break;
                }
            }
        }

        private void ClientsBut_Click(object sender, EventArgs e)
        {
            pages.OpenPage("ClientPage");
            LoadClients();
            //pages.OpenPage("TestPage");
        }
        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pages.OpenPage("MainPage");
        }

        private void CasesBut_Click(object sender, EventArgs e)
        {
            pages.OpenPage("CasesPage");
        }

        private void LoadClients()
        {
            ClientComboBox.Items.Clear();
            ClientPanel.Controls.Clear();
            iControl = 0;

            dataBase.OpenConnection();

            SqlDataReader reader = new SqlCommand($"Select * from Clients", dataBase.GetConnection()).ExecuteReader();

            while (reader.Read())
            {
                CreateClientPanel(Convert.ToString(reader["fullName"]), Convert.ToString(reader["passport"]), Convert.ToString(reader["phone"]));
                ClientComboBox.Items.Add(reader["fullName"]);
            }
            dataBase.CloseConnection();
        }

        private void CreateClientPanel(string fullName, string passport, string phone)
        {
            clientList.Add(new Panel()
            {
                Width = 700,
                Height = 100,
                BackColor = Color.Black,
            });
            clientList[iControl].Controls.Add(new PictureBox()
            {
                Image = Image.FromFile("D:\\images\\photo\\ava\\EXXYY3mJjTg.jpg"),
                SizeMode = PictureBoxSizeMode.Zoom,
                Width = 90,
                Height = 90,
                Location = new Point(5, 5)
            });
            clientList[iControl].Controls.Add(new Label()
            {
                Width = 600,
                //BackColor = Color.White,
                ForeColor = Color.White,
                Text = $"Full name: {fullName}",
                Font = new Font("Malgun Gothic Semilight", 13F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Location = new Point(100, 0),
            });
            clientList[iControl].Controls.Add(new Label()
            {
                Width = 600,
                //BackColor = Color.White,
                ForeColor = Color.White,
                Text = $"Passport: {passport}",
                Font = new Font("Malgun Gothic Semilight", 13F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Location = new Point(100, 25),
            });
            clientList[iControl].Controls.Add(new Label()
            {
                Width = 600,
                //BackColor = Color.White,
                ForeColor = Color.White,
                Text = $"Phone: {phone}",
                Font = new Font("Malgun Gothic Semilight", 13F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Location = new Point(100, 50),
            });
            ClientPanel.Controls.Add(clientList[iControl]);
            //ClientPanel.Controls[iControl].Location = new Point(200, ClientPanel.Controls[iControl].Location.Y);
            ClientPanel.Controls[iControl].Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top )
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            iControl++;
        }

        private void ProceduresBut_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "lawOfficeDataSet.Clients". При необходимости она может быть перемещена или удалена.
            //this.clientsTableAdapter.Fill(this.lawOfficeDataSet.Clients);

        }
    }
}
/*clientList.Add(new Panel() { 
                Width = 700,
                Height = 100,
                BackColor = Color.Black,
            });
            clientList[iControl].Controls.Add(new PictureBox()
            {
                Image = Image.FromFile("D:\\images\\photo\\ava\\EXXYY3mJjTg.jpg"),
                SizeMode = PictureBoxSizeMode.Zoom,
                Width = 90,
                Height = 90,
                Location = new Point(5,5)
            });
            clientList[iControl].Controls.Add(new TextBox()
            {
                Width = 600,
                Height = 90,
                BackColor = Color.White,
                Text = "HYU",
                Font = new Font("Malgun Gothic Semilight", 13F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204))),
                Location = new Point(100, 0)
            });
            MainClientPanel.Controls.Add(clientList[iControl]);
            MainClientPanel.Controls[iControl].Location = new Point((740 - 600) / 2, MainClientPanel.Controls[iControl].Location.Y);
            iControl++;*/