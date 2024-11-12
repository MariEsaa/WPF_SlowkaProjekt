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
        public ProgressBar()
        {
            InitializeComponent();
        }

        private void IncreaseProgress(object sender, RoutedEventArgs e)
        {
            if (UserProgressBar.Value < UserProgressBar.Maximum)
            {
                UserProgressBar.Value += 5; 
                ProgressText.Text = $"{UserProgressBar.Value}% ukończono";
            }
        }

        private void ResetProgress(object sender, RoutedEventArgs e)
        {
            UserProgressBar.Value = 0; 
            ProgressText.Text = "0% ukończono";
        }
    }
}
