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

namespace WPF_SlowkaProjekt
{
    /// <summary>
    /// Logika interakcji dla klasy ChooseQuizUnitPage.xaml
    /// </summary>
    public partial class ChooseQuizUnitPage : Window
    {
        public ChooseQuizUnitPage()
        {
            InitializeComponent();
        }

        private void Unit1Btn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.PreviousWindow = "ChooseQuizUnitPage";
            QuizPage quizPage = new QuizPage();
            quizPage.Show();
            this.Close();
        }
    }
}
