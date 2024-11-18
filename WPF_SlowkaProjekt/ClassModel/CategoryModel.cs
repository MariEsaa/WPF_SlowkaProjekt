using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_SlowkaProjekt.ClassModel
{
    public class CategoryModel
    {
        [Key]
        public int Category_ID { get; set; }
        public string Category { get; set; }
        public List<WordModel> Words { get; set; } = new List<WordModel>();
    }
}