using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_SlowkaProjekt.ClassModel
{
    internal class CategoryModel
    {
        public string Category { get; set; }
        public List<WordModel> Words { get; set; }
        public int WordID { get; set; }
    }
}
