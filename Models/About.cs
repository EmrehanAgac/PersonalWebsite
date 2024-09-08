using System.ComponentModel.DataAnnotations.Schema;

namespace _PersonalWebsite.Models
{
    public class About
    {
        public int ID { get; set; }
        public string AboutText { get; set; }
        public string AboutText2 { get; set; }
    }
}

