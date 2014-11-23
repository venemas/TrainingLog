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
using System.Windows.Shapes;

namespace TrainingLog
{
    /// <summary>
    /// Interaction logic for NewUser.xaml
    /// </summary>
    public partial class NewUser : Window
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void Header_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btn_Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime dte = new DateTime(Convert.ToInt32(birthdayYear.Text), Convert.ToInt32(birthdayMonth.Text), Convert.ToInt32(birthdayDay.Text));
                if (dte > DateTime.Now)
                {
                    MessageBox.Show("Invalid date of birth");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid date of birth");
            }
        }

        private void btn_Cancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
                
        private void userNameBox_GotMouseCapture(object sender, MouseEventArgs e)
        {
            userNameBox.SelectAll();
        }

        private void birthdayDay_GotMouseCapture(object sender, MouseEventArgs e)
        {
            birthdayDay.SelectAll();
        }

        private void birthdayMonth_GotMouseCapture(object sender, MouseEventArgs e)
        {
            birthdayMonth.SelectAll();
        }

        private void birthdayYear_GotMouseCapture(object sender, MouseEventArgs e)
        {
            birthdayYear.SelectAll();
        }

        private void lenghthBox_GotMouseCapture(object sender, MouseEventArgs e)
        {
            lenghthBox.SelectAll();
        }
        
        private void birthdayDay_GotFocus(object sender, RoutedEventArgs e)
        {
            birthdayDay.SelectAll();
        }

        private void birthdayMonth_GotFocus(object sender, RoutedEventArgs e)
        {
            birthdayMonth.SelectAll();
        }

        private void birthdayYear_GotFocus(object sender, RoutedEventArgs e)
        {
            birthdayYear.SelectAll();
        }

        private void userNameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            userNameBox.SelectAll();
        }

        private void lenghthBox_GotFocus(object sender, RoutedEventArgs e)
        {
            lenghthBox.SelectAll();
        }
    }
}
