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

            
            //string output = $"{Customer.FirstName}/{Customer.LastName}/{Customer.ID}";

            if (int.TryParse(txtBoxInput.Text, out int CustomerID) == true)
            {
                int custID = Convert.ToInt32(txtBoxInput.Text);

                List<Customer> c = new List<Customer>();
                foreach(var x in db.Customers)
                {
                    if (x.CustomerID == custID)
                    {
                        listBoxCustomer.Items.Add(x);
                    }
                }

            }
            else
            {
                string city = txtBoxInput.Text;
                //listBoxCustomer.Items.Add(output);
            }
            

        }
    }
}
