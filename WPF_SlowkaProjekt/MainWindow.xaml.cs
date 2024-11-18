using System.Diagnostics;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_SlowkaProjekt.ClassModel;

namespace WPF_SlowkaProjekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string PreviousWindow = string.Empty;
        WordsContext _context = new WordsContext();
        public MainWindow()
        {
            InitializeComponent();
            var list = _context.Words.ToList();
            Debug.WriteLine("ESA");
        }

        private void ChooseQuizPageBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UserPageBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}