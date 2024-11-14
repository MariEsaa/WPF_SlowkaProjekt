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
    /// Logika interakcji dla klasy QuizPage.xaml
    /// </summary>
    public partial class QuizPage : Window
    {
        public QuizPage()
        {
            InitializeComponent();
        }

        private void NextQuestionBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ReturnToMainWindow(object sender, RoutedEventArgs e) 
        { 
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
