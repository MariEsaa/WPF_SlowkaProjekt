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
    /// Logika interakcji dla klasy ProgressBar.xaml
    /// </summary>
    public partial class ProgressBar : Window
    {
        public WordsContext _context = new WordsContext();
        public ProgressBar()
        {
            InitializeComponent();
            double Completed = _context.Words.Where(x => x.IsCompleted == true).ToList().Count();
            double Words = _context.Words.ToList().Count();
            if (Completed > 0)
            {
                QuestionsCountText.Text = "Liczba rozwiązanych pytań: " + Completed;
                double progres = (Completed / Words)*100;
                UserProgressBar.Value = progres;
                RemainingProgressText.Text = "Do ukończenia kurus pozostało: " + Math.Floor(100-progres)+"%";
            }
            else
                UserProgressBar.Value = 0;

        }

        private void GoToMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

    }
}
