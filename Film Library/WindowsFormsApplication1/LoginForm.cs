using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
namespace WindowsFormsApplication1
{
    public partial class LoginForm : Form
    {
        
        Thread th;
        bool foundUser = false;
        UsersDBEntities ef = new UsersDBEntities();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {//when register button is clicked create new thread and open Registration Form and close current
            this.Close();
            th = new Thread(OpenNewRegisterForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenNewRegisterForm()
        {
            Application.Run(new RegisterForm());
        }

        private void loginButton_Click(object sender, EventArgs e) //when loginButton is clicked
        {
            foreach (var user in ef.Users) // go through the Users Table
            {
                if (user.Username.Equals(usernameBox.Text) && user.Password.Equals(passwordBox.Text))
                {   //Search for user with Username and Password equal to the input in the textboxes
                    MessageBox.Show("Successful Login");  // if the search is successful show message

                    if (user.UniqueStatus.Trim().ToString().Equals("admin")) //check user Status
                    { //if the user has admin status,create new thread and open AdminFormChoice Form and close current
                        foundUser = true;
                        this.Close();
                        th = new Thread(OpenNewAdminFormChoice);
                        th.SetApartmentState(ApartmentState.STA);
                        th.Start();
                        break;
                    }
                    //create new thread and open IntroForm Form and close current
                    foundUser = true;
                    this.Close();
                    th = new Thread(OpenNewIntroForm);
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                    break;
                }
              }
            if (!foundUser) // if there is no match, show message
            {
                MessageBox.Show("Unsuccessful Login");
                
            }
        }

        private void OpenNewAdminFormChoice()
        {
            Application.Run(new AdminFormChoice());
        }

        private void OpenNewIntroForm()
        {
            Application.Run(new IntroForm()); 
        }

        private void usernameBox_Enter(object sender, EventArgs e)
        {//when the username box is entered,clear the text inside
            if (usernameBox.Text=="Username")
            {
                usernameBox.Text = "";
            }
        }

        private void usernameBox_Leave(object sender, EventArgs e)
        {//when the username box is left,enter "Username" inside and change text color
            if (usernameBox.Text == "")
            {
                usernameBox.Text = "Username";
                usernameBox.ForeColor = Color.Gray;
            }
        }

        private void passwordBox_Leave(object sender, EventArgs e)
        {//when the username box is left,enter "Password" inside and change text color
            if (passwordBox.Text == "")
            {
                passwordBox.PasswordChar = '\0';
                passwordBox.Text = "Password";
                passwordBox.ForeColor = Color.Gray;     
            }
        }

        private void passwordBox_Enter(object sender, EventArgs e)
        {//when the password box is entered,clear the text inside
            if (passwordBox.Text == "Password")
            {
                passwordBox.Text = "";
                passwordBox.PasswordChar = '*';
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
