using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_SlowkaProjekt.ClassModel
{
    internal class WordModel
    {
        public string Word { get; set; }
        public string  WordTranslated { get; set; }
        public CategoryModel Category { get; set; }
    }
}
