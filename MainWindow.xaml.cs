using System.Windows;
using System.Windows.Media;

namespace tic_tac_toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int counter = 0;

        private bool X = false;
        private bool O = false;

        int zeroZ = 0; int oneZ = 0; int twoZ = 0; // first row
        int zeroO = 0; int oneO = 0; int twoO = 0; // second row 
        int zeroT = 0; int oneT = 0; int twoT = 0; // third row

        int black = 0;
        int red = 0;

        bool blocker00 = false; bool blocker01 = false; bool blocker02 = false; // first row
        bool blocker10 = false; bool blocker11 = false; bool blocker12 = false; // second row
        bool blocker20 = false; bool blocker21 = false; bool blocker22 = false; // third row

        bool vinnerX = false;
        bool vinnerO = false;

        string[] desk = new string[9]; // this array going to right and down + right. >2<0↓


        public MainWindow()
        {
            InitializeComponent();
            MessageBox.Show("@haha4un is maker© 2021. \r 'X' always goes first.");
        }

        // start clicks
        private void zeroZero_Click(object sender, RoutedEventArgs e)
        {
            counter += 1;

            zeroZ += 1;
            counterBiggest();
            caser();
        }

        private void zeroOne_Click(object sender, RoutedEventArgs e)
        {
            counter += 1;

            zeroO += 1;
            counterBiggest();
            caser();
        }

        private void zeroTwo_Click(object sender, RoutedEventArgs e)
        {
            counter += 1;

            zeroT += 1;
            counterBiggest();
            caser();
        }

        private void oneZero_Click(object sender, RoutedEventArgs e)
        {
            counter += 1;

            oneZ += 1;
            counterBiggest();
            caser();
        }

        private void oneOne_Click(object sender, RoutedEventArgs e)
        {
            counter += 1;

            oneO += 1;
            counterBiggest();
            caser();
        }

        private void oneTwo_Click(object sender, RoutedEventArgs e)
        {
            counter += 1;

            oneT += 1;
            counterBiggest();
            caser();
        }

        private void twoZero_Click(object sender, RoutedEventArgs e)
        {
            counter += 1;

            twoZ += 1;
            counterBiggest();
            caser();
        }

        private void twoOne_Click(object sender, RoutedEventArgs e)
        {
            counter += 1;

            twoO += 1;
            counterBiggest();
            caser();
        }

        private void twoTwo_Click(object sender, RoutedEventArgs e)
        {
            counter += 1;

            twoT += 1;
            counterBiggest();
            caser();
        }
        // end clicks


        // cheker and coloring
        private void caser()
        {
            switch (zeroZ)
            {
                case 1:
                    if (counter == 1 & blocker00 == false)
                    {
                        zeroZero.Background = Brushes.Black;
                        blocker00 = true;
                        desk[0] = "x";
                        zeroZ = 0;
                    }
                    else if (counter == 2 & blocker00 == false)
                    {
                        zeroZero.Background = Brushes.Red;
                        blocker00 = true;
                        desk[0] = "o";
                        zeroZ = 0;
                    }
                    else if (counter == 3 & blocker00 == false)
                    {
                        zeroZero.Background = Brushes.Black;
                        counter = 1;
                        blocker00 = true;
                        desk[0] = "x";
                        zeroZ = 0;
                    }
                    whoIsWinner();
                    break;
            }
            switch (zeroO)
            {
                case 1:
                    if (counter == 1 & blocker01 == false)
                    {
                        zeroOne.Background = Brushes.Black;
                        blocker01 = true;
                        desk[1] = "x";
                        zeroO = 0;
                    }
                    else if (counter == 2 & blocker01 == false)
                    {
                        zeroOne.Background = Brushes.Red;
                        blocker01 = true;
                        desk[1] = "o";
                        zeroO = 0;
                    }
                    else if (counter == 3 & blocker01 == false)
                    {
                        zeroOne.Background = Brushes.Black;
                        counter = 1;
                        blocker01 = true;
                        desk[1] = "x";
                        zeroO = 0;
                    }
                    whoIsWinner();
                    break;
            }
            switch (zeroT)
            {
                case 1:
                    if (counter == 1 & blocker02 == false)
                    {
                        zeroTwo.Background = Brushes.Black;
                        blocker02 = true;
                        desk[2] = "x";
                        zeroT = 0;
                    }
                    else if (counter == 2 & blocker02 == false)
                    {
                        zeroTwo.Background = Brushes.Red;
                        blocker02 = true;
                        desk[2] = "o";
                        zeroT = 0;
                    }
                    else if (counter == 3 & blocker02 == false)
                    {
                        zeroTwo.Background = Brushes.Black;
                        counter = 1;
                        blocker02 = true;
                        desk[2] = "x";
                        zeroT = 0;
                    }
                    whoIsWinner();
                    break;
            }
            switch (oneZ)
            {
                case 1:
                    if (counter == 1 & blocker10 == false)
                    {
                        oneZero.Background = Brushes.Black;
                        blocker10 = true;
                        desk[3] = "x";
                        oneZ = 0;
                    }
                    else if (counter == 2 & blocker10 == false)
                    {
                        oneZero.Background = Brushes.Red;
                        blocker10 = true;
                        desk[3] = "o";
                        oneZ = 0;
                    }
                    else if (counter == 3 & blocker10 == false)
                    {
                        oneZero.Background = Brushes.Black;
                        counter = 1;
                        blocker10 = true;
                        desk[3] = "x";
                        oneZ = 0;
                    }
                    whoIsWinner();
                    break;
            }
            switch (oneO)
            {
                case 1:
                    if (counter == 1 & blocker11 == false)
                    {
                        oneOne.Background = Brushes.Black;
                        blocker11 = true;
                        desk[4] = "x";
                        oneO = 0;
                    }
                    else if (counter == 2 & blocker11 == false)
                    {
                        oneOne.Background = Brushes.Red;
                        blocker11 = true;
                        desk[4] = "o";
                        oneO = 0;
                    }
                    else if (counter == 3 & blocker11 == false)
                    {
                        oneOne.Background = Brushes.Black;
                        counter = 1;
                        blocker11 = true;
                        desk[4] = "x";
                        oneO = 0;
                    }
                    whoIsWinner();
                    break;
            }
            switch (oneT)
            {
                case 1:
                    if (counter == 1 & blocker12 == false)
                    {
                        oneTwo.Background = Brushes.Black;
                        blocker12 = true;
                        desk[5] = "x";
                        oneT = 0;
                    }
                    else if (counter == 2 & blocker12 == false)
                    {
                        oneTwo.Background = Brushes.Red;
                        blocker12 = true;
                        desk[5] = "o";
                        oneT = 0;
                    }
                    else if (counter == 3 & blocker12 == false)
                    {
                        oneTwo.Background = Brushes.Black;
                        counter = 1;
                        blocker12 = true;
                        desk[5] = "x";
                        oneT = 0;
                    }
                    whoIsWinner();
                    break;
            }
            switch (twoZ)
            {
                case 1:
                    if (counter == 1 & blocker20 == false)
                    {
                        twoZero.Background = Brushes.Black;
                        blocker20 = true;
                        desk[6] = "x";
                        twoZ = 0;
                    }
                    else if (counter == 2 & blocker20 == false)
                    {
                        twoZero.Background = Brushes.Red;
                        blocker20 = true;
                        desk[6] = "o";
                        twoZ = 0;
                    }
                    else if (counter == 3 & blocker20 == false)
                    {
                        twoZero.Background = Brushes.Black;
                        counter = 1;
                        blocker20 = true;
                        desk[6] = "x";
                        twoZ = 0;
                    }
                    whoIsWinner();
                    break;
            }
            switch (twoO)
            {
                case 1:
                    if (counter == 1 & blocker21 == false)
                    {
                        twoOne.Background = Brushes.Black;
                        blocker21 = true;
                        desk[7] = "x";
                        twoO = 0;
                    }
                    else if (counter == 2 & blocker21 == false)
                    {
                        twoOne.Background = Brushes.Red;
                        blocker21 = true;
                        desk[7] = "o";
                        twoO = 0;
                    }
                    else if (counter == 3 & blocker21 == false)
                    {
                        twoOne.Background = Brushes.Black;
                        counter = 1;
                        blocker21 = true;
                        desk[7] = "x";
                        twoO = 0;
                    }
                    whoIsWinner();
                    break;
            }
            switch (twoT)
            {
                case 1:
                    if (counter == 1 & blocker22 == false)
                    {
                        twoTwo.Background = Brushes.Black;
                        blocker22 = true;
                        desk[8] = "x";
                        twoT = 0;
                    }
                    else if (counter == 2 & blocker22 == false)
                    {
                        twoTwo.Background = Brushes.Red;
                        blocker22 = true;
                        desk[8] = "o";
                        twoT = 0;
                    }
                    else if (counter == 3 & blocker22 == false)
                    {
                        twoTwo.Background = Brushes.Black;
                        counter = 1;
                        blocker22 = true;
                        desk[8] = "x";
                        twoT = 0;
                    }
                    whoIsWinner();
                    break;
            }
        }

        // if counter > 4 = 
        private void counterBiggest()
        {
            if (counter >= 4)
            {
                counter = 1;
            }
        }

        private void whoIsWinner()
        {
            if (desk[0] == "x" & desk[1] == "x" & desk[2] == "x" ||
                desk[0] == "x" & desk[4] == "x" & desk[8] == "x" ||
                desk[0] == "x" & desk[3] == "x" & desk[6] == "x" ||
                desk[1] == "x" & desk[4] == "x" & desk[7] == "x" ||
                desk[2] == "x" & desk[5] == "x" & desk[8] == "x" ||
                desk[3] == "x" & desk[4] == "x" & desk[5] == "x" ||
                desk[6] == "x" & desk[7] == "x" & desk[8] == "x" ||
                desk[2] == "x" & desk[4] == "x" & desk[6] == "x")
            {
                MessageBox.Show("'X' is winner!");
                allBlocked();
            }
            else if (desk[0] == "o" & desk[1] == "o" & desk[2] == "o" ||
              desk[0] == "o" & desk[4] == "o" & desk[8] == "o" ||
              desk[0] == "o" & desk[3] == "o" & desk[6] == "o" ||
              desk[1] == "o" & desk[4] == "o" & desk[7] == "o" ||
              desk[2] == "o" & desk[5] == "o" & desk[8] == "o" ||
              desk[3] == "o" & desk[4] == "o" & desk[5] == "o" ||
              desk[6] == "o" & desk[7] == "o" & desk[8] == "o" ||
              desk[2] == "o" & desk[4] == "o" & desk[6] == "o")
            {
                MessageBox.Show("'O' is winner!");
                allBlocked();
            }
        }

        private void allBlocked()
        {
            blocker00 = true; blocker01 = true; blocker02 = true;
            blocker10 = true; blocker11 = true; blocker12 = true;
            blocker20 = true; blocker21 = true; blocker22 = true;
        }
    }
}
