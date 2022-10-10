

namespace User_App
{
    public partial class Form1 : Form
    {
        int sira = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listView.View = View.Details;
            listView.Columns.Add("No:", 45, HorizontalAlignment.Left);
            listView.Columns.Add("username",90, HorizontalAlignment.Left);
            listView.Columns.Add("password",90, HorizontalAlignment.Left);
        }

        private void login_Click(object sender, EventArgs e)
        {
            
            Daxil_ol1 d = new Daxil_ol1();
            d.sisteme_gir(sira,user_name.Text, password.Text);
            int i = listView.Items.Count;
            
            if(d.Get_password().Length > 5)
            {
                listView.Items.Add(sira.ToString());
                listView.Items[i].SubItems.Add(d.Get_username());
                listView.Items[i].SubItems.Add((d.Get_password()));
                sira++;
                user_name.Text = "";
                password.Text = "";
                MessageBox.Show("Process is successfully!");
            }
            else
            {
                MessageBox.Show("the length of the password cannot be less than 5!");
                password.Text = "";
            }
            
        }

        private void user_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            password.MaxLength = 10;
            
            password.ForeColor = Color.Black;

            password.PasswordChar = '*';
        }
    }

    interface Daxil_ol
    {
        public void sisteme_gir(int no, string username, string password);
    }

    class Daxil_ol1 : Daxil_ol
    {
        private string username;
        private string password;
        public void sisteme_gir(int no,string username, string password)
        {
            this.username = username;           
            this.password = password;   
        }

        public string Get_username()
        {
            return this.username;
        }
        public string Get_password()
        {
            return this.password;
        }
    }
}