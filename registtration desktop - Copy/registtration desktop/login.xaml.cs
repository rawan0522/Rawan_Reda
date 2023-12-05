using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace registtration_desktop
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Page
    {
        Registeration_DesktopEntities db = new Registeration_DesktopEntities();
        public login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
               int age = int.Parse(agetxtbox.Text);
                if (age >= 18 && age <= 60)
                {
                    Users user = new Users();
                    user = db.Users.First(x => x.username == nametxtbox.Text && x.password == passtxtbox.Text);
                    if (user != null)
                    {
                        MessageBox.Show("Login Successfully ^_^...");
                        profile pro = new profile(user);
                        this.NavigationService.Navigate(pro);
                    }
                   
                }
            else
            {
                MessageBox.Show(" Try Again");
            }
            
        }

        private void signup_Click(object sender, RoutedEventArgs e)
        {
            sign_up sign = new sign_up();
            this.NavigationService.Navigate(sign);
        }

        private void forget_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void forget_Click_1(object sender, RoutedEventArgs e)
        {
            forgetpassword forget = new forgetpassword();
            this.NavigationService.Navigate(forget);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Delete delete= new Delete();
            this.NavigationService.Navigate(delete);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Searsh searsh = new Searsh();
            this.NavigationService.Navigate(searsh);
        }
    }
}
