using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KrestikiNoliki
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

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as Button).Name == "StartGameWithPerson")
            {
                WindowWithPerson window = new WindowWithPerson();
                window.Show();
                Close();
            }
            else
            {
                WindowWithRobot window = new WindowWithRobot();
                window.Show();
                Close();
            }
        }
    }
}