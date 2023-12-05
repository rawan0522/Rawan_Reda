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
    /// Interaction logic for Searsh.xaml
    /// </summary>
    public partial class Searsh : Page
    {
        Registeration_DesktopEntities db = new Registeration_DesktopEntities();

        public Searsh()
        {
            InitializeComponent();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            Users users = new Users();
            dg.ItemsSource= db.Users.Where(x => x.city== city_txt.Text).ToList();
            if( users != null )
            {
                dg.ItemsSource = db.Users.Where(x => x.city == city_txt.Text).ToList();

            }

        }
    }
}
