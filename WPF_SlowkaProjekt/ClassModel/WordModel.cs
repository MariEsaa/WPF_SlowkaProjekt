using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_SlowkaProjekt.ClassModel
{
    public class WordModel
    {
        [Key]
        public int Word_ID { get; set; }
        public string Word { get; set; }
        public string WordTranslated { get; set; }
        public bool IsCompleted { get; set; }
        public virtual CategoryModel Category { get; set; }
        public int CategoryID { get; set; }
    }
}