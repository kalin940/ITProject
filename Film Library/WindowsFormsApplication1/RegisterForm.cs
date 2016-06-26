using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
namespace WindowsFormsApplication1
{

    public partial class RegisterForm : Form
    {
        UsersDBEntities ef= new UsersDBEntities();
        Thread th;
        bool validData = true;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {//When register button is clicked
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(mailtextBox3.Text);
            if (match.Success && !usertextBox1.Text.Contains(" ") && !passtextBox2.Text.Contains(" "))
            {//check if the entered email,username and password are valid
                foreach (var myUser in ef.Users)
                {//go through the Users Table
                    if (myUser.Username.Equals(usertextBox1.Text))
                    {//check if the Username is taken
                        MessageBox.Show("The Username is taken");
                        validData = false;
                        break;
                    }
                    if (myUser.Email.Equals(mailtextBox3.Text))
                    {///check if the Username is taken
                        MessageBox.Show("The Email is taken");
                        validData = false;
                        break;
                    }
                }
                if (validData ==true)
                {//if all the input is valid and not taken,add the user information in the Users Table
                    //(create account)
                    Users user = new Users();
                    user.Username = usertextBox1.Text;
                    user.Password = passtextBox2.Text;
                    user.Email = mailtextBox3.Text;
                    user.UniqueStatus = "user";
                    ef.Users.Add(user);
                    ef.SaveChanges();
                    MessageBox.Show("Successful Register");
                }                 
           }
           else
           {//if the input isn't valid
               MessageBox.Show("Invalid Input");
           }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {////when Back button is clicked create new thread and open Login Form and close current
            this.Close();
            th = new Thread(OpenNewLoginForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        private void OpenNewLoginForm()
        {//open Login form
            Application.Run(new LoginForm());
        }
    }
}
