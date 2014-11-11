using System.Windows;
using System.Windows.Controls;

namespace TrainingLog.View
{
    /// <summary>
    /// Interaction logic for ChosenDate.xaml
    /// </summary>
    public partial class ChosenDate : UserControl
    {
        public ChosenDate()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty TekstProperty = DependencyProperty.Register(
            "Tekst", typeof(string), typeof(ChosenDate));

        public string Tekst
        {
            get { return (string)this.GetValue(TekstProperty); }
            set { this.SetValue(TekstProperty, value); }
        }
    }
}
