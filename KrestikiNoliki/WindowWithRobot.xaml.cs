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
    /// Логика взаимодействия для WindowWithRobot.xaml
    /// </summary>
    public partial class WindowWithRobot : Window
    {
        string a = null;
        Random random = new Random();
        public WindowWithRobot()
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
        private bool CheckBtn()
        {
            if ((LefM.IsEnabled == false) && (LefU.IsEnabled == false) && (MidB.IsEnabled == false) && (MidM.IsEnabled == false) && (MidU.IsEnabled == false) && (RigB.IsEnabled == false) && (RigM.IsEnabled == false) && (RigU.IsEnabled == false))
            {
                LefB.IsEnabled = false;
                LefB.Content = a;
                return false;
            }
            else if ((LefB.IsEnabled == false) && (LefU.IsEnabled == false) && (MidB.IsEnabled == false) && (MidM.IsEnabled == false) && (MidU.IsEnabled == false) && (RigB.IsEnabled == false) && (RigM.IsEnabled == false) && (RigU.IsEnabled == false))
            {
                LefM.IsEnabled = false;
                LefM.Content = a;
                return false;
            }
            else if ((LefB.IsEnabled == false) && (LefM.IsEnabled == false) && (MidB.IsEnabled == false) && (MidM.IsEnabled == false) && (MidU.IsEnabled == false) && (RigB.IsEnabled == false) && (RigM.IsEnabled == false) && (RigU.IsEnabled == false))
            {
                LefU.IsEnabled = false;
                LefU.Content = a;
                return false;
            }
            else if ((LefB.IsEnabled == false) && (LefM.IsEnabled == false) && (LefU.IsEnabled == false) && (MidM.IsEnabled == false) && (MidU.IsEnabled == false) && (RigB.IsEnabled == false) && (RigM.IsEnabled == false) && (RigU.IsEnabled == false))
            {
                MidB.IsEnabled = false;
                MidB.Content = a;
                return false;
            }
            else if ((LefB.IsEnabled == false) && (LefM.IsEnabled == false) && (LefU.IsEnabled == false) && (MidB.IsEnabled == false) && (MidU.IsEnabled == false) && (RigB.IsEnabled == false) && (RigM.IsEnabled == false) && (RigU.IsEnabled == false))
            {
                MidM.IsEnabled = false;
                MidM.Content = a;
                return false;
            }
            else if ((LefB.IsEnabled == false) && (LefM.IsEnabled == false) && (LefU.IsEnabled == false) && (MidB.IsEnabled == false) && (MidM.IsEnabled == false) && (RigB.IsEnabled == false) && (RigM.IsEnabled == false) && (RigU.IsEnabled == false))
            {
                MidU.IsEnabled = false;
                MidU.Content = a;
                return false;
            }
            else if ((LefB.IsEnabled == false) && (LefM.IsEnabled == false) && (LefU.IsEnabled == false) && (MidB.IsEnabled == false) && (MidM.IsEnabled == false) && (MidU.IsEnabled == false) && (RigM.IsEnabled == false) && (RigU.IsEnabled == false))
            {
                RigB.IsEnabled = false;
                RigB.Content = a;
                return false;
            }
            else if ((LefB.IsEnabled == false) && (LefM.IsEnabled == false) && (LefU.IsEnabled == false) && (MidB.IsEnabled == false) && (MidM.IsEnabled == false) && (MidU.IsEnabled == false) && (RigB.IsEnabled == false) && (RigU.IsEnabled == false))
            {
                RigM.IsEnabled = false;
                RigM.Content = a;
                return false;
            }
            else if ((LefB.IsEnabled == false) && (LefM.IsEnabled == false) && (LefU.IsEnabled == false) && (MidB.IsEnabled == false) && (MidM.IsEnabled == false) && (MidU.IsEnabled == false) && (RigB.IsEnabled == false) && (RigM.IsEnabled == false))
            {
                RigU.IsEnabled = false;
                RigU.Content = a;
                return false;
            }
            else
            {
                return true;
            }
        }

        void Robot()
        {
            a = "X";
            int rnd = random.Next(1, 9);
            if (CheckBtn() == false)
            {
                int v = 1;
            }
            else
            {
                switch (rnd)
                {
                    case 1:
                        {
                            if (LefU.IsEnabled == true)
                            {
                                LefU.IsEnabled = false;
                                LefU.Content = a;
                            }
                            else
                            {
                                Robot();
                            }
                            break;
                        }
                    case 2:
                        {
                            if (MidU.IsEnabled == true)
                            {
                                MidU.IsEnabled = false;
                                MidU.Content = a;
                            }
                            else
                            {
                                Robot();
                            }
                            break;
                        }
                    case 3:
                        {
                            if (RigU.IsEnabled == true)
                            {
                                RigU.IsEnabled = false;
                                RigU.Content = a;
                            }
                            else
                            {
                                Robot();
                            }
                            break;
                        }
                    case 4:
                        {
                            if (LefB.IsEnabled == true)
                            {
                                LefB.IsEnabled = false;
                                LefB.Content = a;
                            }
                            else
                            {
                                Robot();
                            }
                            break;
                        }
                    case 5:
                        {
                            if (MidB.IsEnabled == true)
                            {
                                MidB.IsEnabled = false;
                                MidB.Content = a;
                            }
                            else
                            {
                                Robot();
                            }
                            break;
                        }
                    case 6:
                        {
                            if (RigB.IsEnabled == true)
                            {
                                RigB.IsEnabled = false;
                                RigB.Content = a;
                            }
                            else
                            {
                                Robot();
                            }
                            break;
                        }
                    case 7:
                        {
                            if (LefM.IsEnabled == true)
                            {
                                LefM.IsEnabled = false;
                                LefM.Content = a;
                            }
                            else
                            {
                                Robot();
                            }
                            break;
                        }
                    case 8:
                        {
                            if (MidM.IsEnabled == true)
                            {
                                MidM.IsEnabled = false;
                                MidM.Content = a;
                            }
                            else
                            {
                                Robot();
                            }
                            break;
                        }
                    case 9:
                        {
                            if (RigM.IsEnabled == true)
                            {
                                RigM.IsEnabled = false;
                                RigM.Content = a;
                            }
                            else
                            {
                                Robot();
                            }
                            break;
                        }
                }
            }
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
            else
            {
                Player();
            }
        }

        private void Player()
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
            else { Robot(); }
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
            Robot();
        }
        private void ExitGame_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }
    }
}
