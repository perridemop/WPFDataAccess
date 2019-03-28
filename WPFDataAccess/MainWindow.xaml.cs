using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Perri Demopulos
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDataAccess
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //https://www.youtube.com/watch?v=RJvKaHPc8Dc
            DB_128040_practiceEntities db = new DB_128040_practiceEntities();

            if ()
            {
                var cust = db.Customers.OrderBy(x => x.FirstName);
            }
            else if ()
            {
                var city = db.Customers.OrderBy(x => x.City);
            }
            

        }
    }
}
