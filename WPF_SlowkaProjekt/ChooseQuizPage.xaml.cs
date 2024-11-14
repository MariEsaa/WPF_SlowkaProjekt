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

namespace WPF_SlowkaProjekt
{
    /// <summary>
    /// Logika interakcji dla klasy ChooseQuizPage.xaml
    /// </summary>
    public partial class ChooseQuizPage : Window
    {
        public ChooseQuizPage()
        {
            InitializeComponent();
        }
        private void ChooseUnit_Click(object sender, RoutedEventArgs e)
        {
            ChooseQuizUnitPage chooseQuizUnitPage = new ChooseQuizUnitPage();   
            chooseQuizUnitPage.Show();  
            this.Close();   
        }

        private void RandomUnit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.PreviousWindow = "ChooseQuizPage";
            QuizPage quizPage = new QuizPage();
            quizPage.Show();
            this.Close();
        }

        private void ComeBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();   
            mainWindow.Show();  
            this.Close();
        }
    }
}
