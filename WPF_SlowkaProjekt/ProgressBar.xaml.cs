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
    /// Logika interakcji dla klasy ProgressBar.xaml
    /// </summary>
    public partial class ProgressBar : Window
    {
        private int solvedQuestionsCount = 0; 
        private int maxQuestions = 100;
        private int percent = 6;

        public ProgressBar()
        {
            InitializeComponent(); 
        }

        
        private void AddQuestionButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (solvedQuestionsCount + 10 <= maxQuestions)
            {
                solvedQuestionsCount += percent;

                QuestionsCountText.Text = $"Liczba rozwiązanych pytań: {solvedQuestionsCount}";

                
                UserProgressBar.Value = (double)solvedQuestionsCount / maxQuestions * 100;

                
                double remainingPercentage = 100 - ((double)solvedQuestionsCount / maxQuestions * 100);
                RemainingProgressText.Text = $"Pozostało: {remainingPercentage:0}%"; 
            }
            else
            {
                
                solvedQuestionsCount = maxQuestions;
                QuestionsCountText.Text = $"Liczba rozwiązanych pytań: {solvedQuestionsCount}";

                UserProgressBar.Value = 100; 

                
                RemainingProgressText.Text = $"Pozostało: 0%";

                MessageBox.Show("Osiągnąłeś maksymalny postęp!", "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
