using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Interaction logic for sign_up.xaml
    /// </summary>
    public partial class sign_up : Page
    {
        Registeration_DesktopEntities db = new Registeration_DesktopEntities();
        public sign_up()
        {
            InitializeComponent();
            compo.ItemsSource=db.Users.Select(x => x.city).ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Users user = new Users();
            try
            {
                Regex regex = new Regex(passtxtbox.Password = (@"^(?=.*[a-z])(?=.*[A-Z])(?=.*[\d])(?=.*[\w]).+$"));
                if (regex.IsMatch(passtxtbox.Password))
                {
                    user.username = nametxtbox.Text;
                    user.phonenumber = phonetxtbox.Text;
                    user.age = int.Parse(agetxtbox.Text );
                    user.password = passtxtbox.Password;
                    db.Users.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("sign up successfully ^_^...");
                }
                else
                {
                    MessageBox.Show("Try again");
                }
            }
            catch
            {
                MessageBox.Show("Try again");
            }
        }

        private void maleradio_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void login_Click(object sender, RoutedEventArgs e)
        {
            login log = new login();
            this.NavigationService.Navigate(log);
        }
    }
}
