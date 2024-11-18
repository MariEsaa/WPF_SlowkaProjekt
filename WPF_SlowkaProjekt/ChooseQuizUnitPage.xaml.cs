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
using WPF_SlowkaProjekt.ClassModel;

namespace WPF_SlowkaProjekt
{
    /// <summary>
    /// Logika interakcji dla klasy ChooseQuizUnitPage.xaml
    /// </summary>
    public partial class ChooseQuizUnitPage : Window
    {
        WordsContext _context = new WordsContext();
        Button[] buttons = new Button[10];
        public ChooseQuizUnitPage()
        {
            InitializeComponent();
            buttons[0] = Unit1Btn;
            buttons[1] = Unit2Btn;
            buttons[2] = Unit3Btn;
            buttons[3] = Unit4Btn;
            buttons[4] = Unit5Btn;
            buttons[5] = Unit6Btn;
            buttons[6] = Unit7Btn;
            buttons[7] = Unit8Btn;
            buttons[8] = Unit9Btn;
            buttons[9] = Unit10Btn;
            var Categoies = _context.Categories.ToList();
            for (int i = 0; i < 10; i++)
            {
                if (i < Categoies.Count())
                {
                    buttons[i].Content = Categoies[i].Category;
                    buttons[i].CommandParameter = Categoies[i].Category_ID;
                }
                else
                {
                    buttons[i].Visibility = Visibility.Collapsed;
                }
            }

        }

        private void UnitBtn_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                var NewWindow = new QuizPage((int)button.CommandParameter);
                NewWindow.Show();
                this.Close();
            }
        }
    }
}
