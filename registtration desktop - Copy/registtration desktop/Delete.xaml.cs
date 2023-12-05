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
    /// Interaction logic for Delete.xaml
    /// </summary>
    public partial class Delete : Page
    {
        Registeration_DesktopEntities db = new Registeration_DesktopEntities();

        public Delete()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            Users user = new Users();
            user = db.Users.FirstOrDefault(x=> x.phonenumber == phone_txt.Text);
            if(user != null)
            {
                db.Users.Remove(user);
                db.SaveChanges();
                MessageBox.Show("Deleted successfully ^_^...");
            }
            else
            {
                MessageBox.Show("Try Again...!!!");
            }

        }
    }
}
