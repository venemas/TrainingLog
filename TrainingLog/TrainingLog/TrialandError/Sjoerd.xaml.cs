using System;
using System.Windows;
using System.Windows.Input;

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
            for (int i = 2015; i > 1900; i--)
            {
                cbxYear.Items.Add(i.ToString());
            }
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
            this.Close();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(DtePicker.Text);
            try
            {
                DateTime dte = new DateTime(2014, 1, 31);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ongeldige Datum");
            }
        }


    }
}
