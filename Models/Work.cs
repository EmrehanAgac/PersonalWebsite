using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _PersonalWebsite.Models
{
    public class Work
    {
        public int ID { get; set; }
        public string WorkText { get; set; }
        public string WorkText2 { get; set; }
    }
}
