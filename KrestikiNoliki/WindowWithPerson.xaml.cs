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

namespace KrestikiNoliki
{
    /// <summary>
    /// Логика взаимодействия для WindowWithPerson.xaml
    /// </summary>
    public partial class WindowWithPerson : Window
    {
        string a = null;
        public WindowWithPerson()
        {
            InitializeComponent();
        }
        string Proverka(string b)
        {
            if (((LefU.Content == b) && (LefB.Content == b) && (LefM.Content == b)) || ((LefU.Content == b) && (RigB.Content == b) && (MidM.Content == b)) || ((RigU.Content == b) && (RigB.Content == b) && (RigM.Content == b)) || ((MidU.Content == b) && (MidB.Content == b) && (MidM.Content == b)) || ((LefB.Content == b) && (RigU.Content == b) && (MidM.Content == b)) || ((LefB.Content == b) && (RigB.Content == b) && (MidB.Content == b)) || ((LefU.Content == b) && (RigU.Content == b) && (MidU.Content == b)) || ((LefM.Content == b) && (RigM.Content == b) && (MidM.Content == b)))
            {
                LefB.IsEnabled = false;
                LefM.IsEnabled = false;
                LefU.IsEnabled = false;
                MidB.IsEnabled = false;
                MidM.IsEnabled = false;
                MidU.IsEnabled = false;
                RigB.IsEnabled = false;
                RigM.IsEnabled = false;
                RigU.IsEnabled = false;
                return "Победа";
            }
            else if ((LefB.IsEnabled == false) && (LefM.IsEnabled == false) && (LefU.IsEnabled == false) && (MidB.IsEnabled == false) && (MidM.IsEnabled == false) && (MidU.IsEnabled == false) && (RigB.IsEnabled == false) && (RigM.IsEnabled == false) && (RigU.IsEnabled == false))
            {
                return "Ничья";
            }
            else { return "Нет"; }
        }
        void Player1()
        {
            a = "X";
        }

        private void Player2()
        {
            a = "O";
        }

        private void LefU_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).Content = a;
            (sender as Button).IsEnabled = false;
            if (Proverka(a) == "Ничья")
            {
                Result.Text = "Ничья";
                StartGame.IsEnabled = true;
                ExitGame.IsEnabled = true;
            }
            else if (Proverka(a) == "Победа")
            {
                Result.Text = "Победа за " + a;
                StartGame.IsEnabled = true;
                ExitGame.IsEnabled = true;

            }
            else {
                if (a == "X") { Player2(); }
                else { Player1();}
            }
        }

        private void StartGame_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = "";
            (sender as Button).IsEnabled = false;
            ExitGame.IsEnabled = false;
            LefB.IsEnabled = true;
            LefB.Content = "";
            LefM.IsEnabled = true;
            LefM.Content = "";
            LefU.IsEnabled = true;
            LefU.Content = "";
            MidB.IsEnabled = true;
            MidB.Content = "";
            MidM.IsEnabled = true;
            MidM.Content = "";
            MidU.IsEnabled = true;
            MidU.Content = "";
            RigB.IsEnabled = true;
            RigB.Content = "";
            RigM.IsEnabled = true;
            RigM.Content = "";
            RigU.IsEnabled = true;
            RigU.Content = "";
            Player1();
        }

        private void ExitGame_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }
    }
}
