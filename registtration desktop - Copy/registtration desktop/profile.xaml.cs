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
    /// Interaction logic for profile.xaml
    /// </summary>
    public partial class profile : Page
    {
        Registeration_DesktopEntities db = new Registeration_DesktopEntities();

        public profile( Users user)
        {
            InitializeComponent();
            profile1.Content = user.username + " Profile";
            nametxtbox.Text = user.username;
                phonetxtbox.Text = user.phonenumber;
               passtxtbox.Text = user.password;
             agetxtbox.Text= user.age .ToString();
                citytxtbox.Text = user.city;


            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          
           login log = new login();
            this.NavigationService.Navigate(log);
        }
    }
}
