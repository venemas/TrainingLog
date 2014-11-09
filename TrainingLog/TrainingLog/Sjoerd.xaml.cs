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
    /// Interaction logic for Sjoerd.xaml
    /// </summary>
    public partial class Sjoerd : Window
    {
        public Sjoerd()
        {
            InitializeComponent();
        }
        private void Header_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sjoerd is de man!");
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sander is de man!");
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


    }
}
