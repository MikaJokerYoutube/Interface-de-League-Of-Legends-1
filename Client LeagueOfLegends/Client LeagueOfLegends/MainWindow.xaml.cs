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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Client_LeagueOfLegends
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            //Ajout des différentes régions
            combo_region.Items.Add("EU Ouest");
            combo_region.Items.Add("Japon");
            combo_region.Items.Add("");
            combo_region.Items.Add("");
            //Ajout des différents pays
            combo_pays.Items.Add("Français");
            combo_pays.Items.Add("English");
            combo_pays.Items.Add("Deutsch");
            combo_pays.Items.Add("Espagnol - EU");
            combo_pays.Items.Add("Italiano");
        }





        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void Tb_username_GotFocus(object sender, RoutedEventArgs e)
        {
            ImageBrush mon_background = new ImageBrush();

            mon_background.ImageSource = new BitmapImage(new Uri(@"C:\Users\\YamiPharaon\\source\\repos\\Client LeagueOfLegends\\Client LeagueOfLegends\\ressources\\tb_focused.png"));
            mon_background.AlignmentX = AlignmentX.Left;
            mon_background.Stretch = Stretch.None;

            tb_username.Background = mon_background;
        }

        private void Tb_username_LostFocus(object sender, RoutedEventArgs e)
        {
            tb_username.Background = new SolidColorBrush(Color.FromRgb(0, 3, 6));

        }

        private void Btn_fermer_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();

        }

        private void Motdepasseoublie_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Username_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void Createaccount_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void EtPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            ImageBrush mon_background = new ImageBrush();

            mon_background.ImageSource = new BitmapImage(new Uri(@"C:\Users\\YamiPharaon\\source\\repos\\Client LeagueOfLegends\\Client LeagueOfLegends\\ressources\\tb_focused.png"));
            mon_background.AlignmentX = AlignmentX.Left;
            mon_background.Stretch = Stretch.None;

            etPassword.Background = mon_background;
        }

        private void EtPassword_LostFocus(object sender, RoutedEventArgs e)
        {
           etPassword.Background = new SolidColorBrush(Color.FromRgb(0, 3, 6));
        }
    }
}
