using System.Windows;
using System.Windows.Input;

namespace TrainingLog.TrialandError
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow1 : Window
    {
        public MainWindow1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Test!");
        }

        private void Header_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
        
        private void windowSjoerd_Click(object sender, RoutedEventArgs e)
        {
            Sjoerd wnd = new Sjoerd();
            wnd.Show();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void windowSander_Click(object sender, RoutedEventArgs e)
        {
            Sander wnd = new Sander();
            wnd.Show();
        }
    }
}
