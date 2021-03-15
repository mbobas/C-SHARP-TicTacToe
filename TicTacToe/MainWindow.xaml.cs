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

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool IsPlayer1Turn { get; set; }
        public int Counter { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }

        public void NewGame()
        {
            IsPlayer1Turn = false;
            Counter = 0;

            Button0.Content = string.Empty;
            Button1.Content = string.Empty;
            Button2.Content = string.Empty;
            Button3.Content = string.Empty;
            Button4.Content = string.Empty;
            Button5.Content = string.Empty;
            Button6.Content = string.Empty;
            Button7.Content = string.Empty;
            Button8.Content = string.Empty;

            Button0.Background = Brushes.White;
            Button1.Background = Brushes.White;
            Button2.Background = Brushes.White;
            Button3.Background = Brushes.White;
            Button4.Background = Brushes.White;
            Button5.Background = Brushes.White;
            Button6.Background = Brushes.White;
            Button7.Background = Brushes.White;
            Button8.Background = Brushes.White;

            ButtonNewGame.Content = "NewGame";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //przesuniecie bitowe ^= zamiast 4 linijek if() else() i zmiany flag
            IsPlayer1Turn ^= true;
            Counter++;

            if (Counter > 9)
            {
                NewGame();
                return;
            }


            var button = sender as Button;
            
            if (button == ButtonNewGame)
            {
                NewGame();
            }else
            {
                button.Content = IsPlayer1Turn ? "O" : "X";
                if (CheckIfPlayerWon())
                {
                    Counter = 9;
                }
            }
          
        }


            /// <summary>
            /// 
            /// </summary>
            /// <returns></returns>
            private bool CheckIfPlayerWon() 
            {
               //columns
            if (Button0.Content.ToString() != string.Empty &&
                Button0.Content==Button1.Content && Button0.Content == Button2.Content)
            {
                Button0.Background = Brushes.Green;
                Button1.Background = Brushes.Green;
                Button2.Background = Brushes.Green;
                return true;
            }
            if (Button3.Content.ToString() != string.Empty &&
                Button3.Content == Button4.Content && Button3.Content == Button5.Content)
            {
                Button3.Background = Brushes.Green;
                Button4.Background = Brushes.Green;
                Button5.Background = Brushes.Green;
                return true;
            }
            if (Button6.Content.ToString() != string.Empty &&
                Button6.Content == Button7.Content && Button6.Content == Button8.Content)
            {
                Button6.Background = Brushes.Green;
                Button7.Background = Brushes.Green;
                Button8.Background = Brushes.Green;
                return true;
            }
            //columns
            if (Button0.Content.ToString() != string.Empty &&
                Button0.Content == Button3.Content && Button0.Content == Button6.Content)
            {
                Button0.Background = Brushes.Green;
                Button3.Background = Brushes.Green;
                Button6.Background = Brushes.Green;
                return true;
            }
            if (Button1.Content.ToString() != string.Empty &&
                Button1.Content == Button4.Content && Button1.Content == Button7.Content)
            {
                Button1.Background = Brushes.Green;
                Button4.Background = Brushes.Green;
                Button7.Background = Brushes.Green;
                return true;
            }
            if (Button2.Content.ToString() != string.Empty &&
                Button2.Content == Button5.Content && Button2.Content == Button8.Content)
            {
                Button2.Background = Brushes.Green;
                Button5.Background = Brushes.Green;
                Button8.Background = Brushes.Green;
                return true;
            }
            //diagonal - przekatna
            if (Button0.Content.ToString() != string.Empty &&
                Button0.Content == Button4.Content && Button0.Content == Button8.Content)
            {
                Button0.Background = Brushes.Green;
                Button4.Background = Brushes.Green;
                Button8.Background = Brushes.Green;
                return true;
            }
            if (Button2.Content.ToString() != string.Empty &&
                Button2.Content == Button4.Content && Button2.Content == Button6.Content)
            {
                Button2.Background = Brushes.Green;
                Button4.Background = Brushes.Green;
                Button6.Background = Brushes.Green;
                return true;
            }

            return false;
            }
    }
}
