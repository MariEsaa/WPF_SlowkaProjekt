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
    /// Logika interakcji dla klasy QuizPage.xaml
    /// </summary>
    public partial class QuizPage : Window
    {
        WordsContext _context = new WordsContext();
        Button[] Buttons = new Button[4];
        Random rand = new Random();
        WordModel wordModel = new WordModel();
        bool isCategorySet = false;
        int Category = 0;
        public QuizPage()
        {
            InitializeComponent();
            Buttons[0] = Answer1Btn;
            Buttons[1] = Answer2Btn;
            Buttons[2] = Answer3Btn;
            Buttons[3] = Answer4Btn;
            var allWords = _context.Words.ToList();
            var words = _context.Words.Where(x => x.IsCompleted == false);
            if (words.Count() > 0)
            {
                var word = words.First();
                wordModel = word;
                QuestionTxt.Text = word.Word;
                int legitWord = rand.Next(0, 3);
                for(int i =0;i<4;i++)
                {
                    if(i == legitWord)
                    {
                        Buttons[i].Content = word.WordTranslated;
                    }
                    else
                    {
                        Buttons[i].Content = allWords[rand.Next(0,allWords.Count())].WordTranslated;
                    }
                }
            }
        }
        public QuizPage(int category)
        {
            InitializeComponent();
            isCategorySet = true;
            Category = category;
            Buttons[0] = Answer1Btn;
            Buttons[1] = Answer2Btn;
            Buttons[2] = Answer3Btn;
            Buttons[3] = Answer4Btn;
            var allWords = _context.Words.ToList();
            var words = _context.Words.Where(x => x.IsCompleted == false && x.CategoryID == category);
            if (words.Count() > 0)
            {
                var word = words.First();
                wordModel = word;
                QuestionTxt.Text = word.Word;
                int legitWord = rand.Next(0, 3);
                for (int i = 0; i < 4; i++)
                {
                    if (i == legitWord)
                    {
                        Buttons[i].Content = word.WordTranslated;
                    }
                    else
                    {
                        Buttons[i].Content = allWords[rand.Next(0, allWords.Count())].WordTranslated;
                    }
                }
            }
        }

        private void NextQuestionBtn_Click(object sender, RoutedEventArgs e)
        {
            if(isCategorySet)
            {
                var NewWindow = new QuizPage(Category);
                NewWindow.Show();
                this.Close();
            }
            else
            {
                var NewWindow = new QuizPage();
                NewWindow.Show();
                this.Close();
            }
        }

        private void ReturnToMainWindow(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void ComeBack_Click(object sender, RoutedEventArgs e)
        {
            if (MainWindow.PreviousWindow == "ChooseQuizPage")
            {
                ChooseQuizPage chooseQuizPage = new ChooseQuizPage();
                chooseQuizPage.Show();
                this.Close();
            }
            else if (MainWindow.PreviousWindow == "ChooseQuizUnitPage")
            {
                ChooseQuizUnitPage chooseQuizUnitPage = new ChooseQuizUnitPage();
                chooseQuizUnitPage.Show();
                this.Close();
            }
        }

        private void Answer_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = sender as Button;
            if (wordModel.WordTranslated == clickedButton.Content)
            {
                MessageBox.Show("Poprawna odpowiedz", "Wiadomosc", MessageBoxButton.OK);
                wordModel.IsCompleted = true;
                _context.Update(wordModel);
                _context.SaveChanges();                
                if (isCategorySet)
                {
                    var NewWindow = new QuizPage(Category);
                    NewWindow.Show();
                    this.Close();
                }
                else
                {
                    var NewWindow = new QuizPage();
                    NewWindow.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Nie poprawna odpowiedz", "Wiadomosc", MessageBoxButton.OK);
            }
        }
    }
}
