using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for forgetpassword.xaml
    /// </summary>
    public partial class forgetpassword : Page
    {
        Registeration_DesktopEntities db = new Registeration_DesktopEntities();

        public forgetpassword()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Users user= new Users();
            if (newpasstxtbox.Text == confirmtxtbox.Text)
            {
                login log = new login();
                this.NavigationService.Navigate(log);
                  db.Users.Select(x => x.phonenumber);
                user.phonenumber = phonetxtbox.Text;
                user.password = newpasstxtbox.Text;
                user.password = confirmtxtbox.Text;
                db.Users.AddOrUpdate(user);
                db.SaveChanges();

                

                MessageBox.Show("Updated successfully");
                
            }
            else 
            {
                MessageBox.Show("Erorrrrrr!!!!!");
            }

        }
    }
}
