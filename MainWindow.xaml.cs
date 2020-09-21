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

namespace CountVowels_ZakGuetter
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int sum = 0; //holds all numbers
            Phrase.Text = Phrase.Text.ToLower(); //i did this instead of creating a new string cause im lazy and what does the user care if it turns his caps into lower
            for (int i = 0; i < Phrase.Text.Length; i++) //runs through Phrase Label and looks for vowels and adds to the sum when it finds one
            {
                if (Phrase.Text[i] == 'a' || Phrase.Text[i] == 'e' || Phrase.Text[i] == 'i' || Phrase.Text[i] == 'o' || Phrase.Text[i] == 'u')
                {
                    sum++;
                }
            }

            NumbVowels.Text = sum.ToString(); //changes the label NumbVowels to the sum of the vowels found in the program
        }
    }
}
