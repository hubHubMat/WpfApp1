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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rand = new Random();
        bool whichPlayer = true;
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }

        private void NewGame()
        {
            whichPlayer = true;
            whichPlayerButton.Content = "Gracz 1";
            whichPlayerButton.Background = Brushes.Green;

            button1.Content = string.Empty;
            button2.Content = string.Empty;
            button3.Content = string.Empty;
            button4.Content = string.Empty;
            button5.Content = string.Empty;
            button6.Content = string.Empty;
            button7.Content = string.Empty;
            button8.Content = string.Empty;
            button9.Content = string.Empty;

            button1.IsEnabled = true;
            button2.IsEnabled = true;
            button3.IsEnabled = true;
            button4.IsEnabled = true;
            button5.IsEnabled = true;
            button6.IsEnabled = true;
            button7.IsEnabled = true;
            button8.IsEnabled = true;
            button9.IsEnabled = true;

            button1.Background = Brushes.White;
            button2.Background = Brushes.White;
            button3.Background = Brushes.White;
            button4.Background = Brushes.White;
            button5.Background = Brushes.White;
            button6.Background = Brushes.White;
            button7.Background = Brushes.White;
            button8.Background = Brushes.White;
            button9.Background = Brushes.White;

        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            
            int rInt = rand.Next(0, 9);
           
            var button = sender as Button;

            if (button.IsEnabled == true && whichPlayer == true)
            {
                button.Content = "X";
                button.IsEnabled = false;
                whichPlayer = false;
                whichPlayerButton.Content = "Gracz 2";
                whichPlayerButton.Background = Brushes.Red;
                checkWhichPlayerWon();
            }

            else if (button.IsEnabled == true && whichPlayer == false)
            {
                button.Content = "O";
                button.IsEnabled = false;
                whichPlayer = true;
                whichPlayerButton.Content = "Gracz 1";
                whichPlayerButton.Background = Brushes.Green;
                checkWhichPlayerWon();
            }

            

        }
       
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NewGame();
        }

        private void checkWhichPlayerWon()
        {
            //rows
            if (button1.Content.ToString() != string.Empty && button1.Content == button2.Content && button2.Content == button3.Content)
            {
                if (button2.Content.ToString() == "O")
                    MessageBox.Show("Wygrał Gracz 2");
                else MessageBox.Show("Wygrał gracz 1");
                NewGame();
            }
            if (button4.Content.ToString() != string.Empty && button4.Content == button5.Content && button5.Content == button6.Content)
            {
                if (button4.Content.ToString() == "O")
                    MessageBox.Show("Wygrał Gracz 2");
                else MessageBox.Show("Wygrał gracz 1");
                NewGame();
            }
            if (button7.Content.ToString() != string.Empty && button7.Content == button8.Content && button8.Content == button9.Content)
            {
                if (button7.Content.ToString() == "O")
                    MessageBox.Show("Wygrał Gracz 2");
                else MessageBox.Show("Wygrał gracz 1");
                NewGame();
            }

            //columns
            if (button1.Content.ToString() != string.Empty && button1.Content == button4.Content && button4.Content == button7.Content)
            {
                if (button1.Content.ToString() == "O")
                    MessageBox.Show("Wygrał Gracz 2");
                else MessageBox.Show("Wygrał gracz 1");
                NewGame();
            }
            if (button2.Content.ToString() != string.Empty && button2.Content == button5.Content && button5.Content == button8.Content)
            {
                if (button2.Content.ToString() == "O")
                    MessageBox.Show("Wygrał Gracz 2");
                else MessageBox.Show("Wygrał gracz 1");
                NewGame();
            }
            if (button3.Content.ToString() != string.Empty && button3.Content == button6.Content && button6.Content == button9.Content)
            {
                if (button3.Content.ToString() == "O")
                    MessageBox.Show("Wygrał Gracz 2");
                else MessageBox.Show("Wygrał gracz 1");
                NewGame();
            }

            //else
            if (button1.Content.ToString() != string.Empty && button1.Content == button5.Content && button5.Content == button9.Content)
            {
                if (button1.Content.ToString() == "O")
                    MessageBox.Show("Wygrał Gracz 2");
                else MessageBox.Show("Wygrał gracz 1");
                NewGame();
            }
            if (button3.Content.ToString() != string.Empty && button3.Content == button5.Content && button2.Content == button6.Content)
            {
                if (button3.Content.ToString() == "O")
                    MessageBox.Show("Wygrał Gracz 2");
                else MessageBox.Show("Wygrał gracz 1");
                NewGame();
            }

            else return;

        }
    }
}
