using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    ///
    public partial class ProgressBar : Window
    {
        WordsContext _context = new WordsContext();
        public ProgressBar()
        {
            InitializeComponent();
        }
    }
}
