using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _PersonalWebsite.Models
{
    public class HomePage
    {
        public int ID { get; set; }
		public string HomeName { get; set; }
		public string HomeTitle { get; set; }
		public string Menu1 { get; set; }
		public string Menu2 { get; set; }
		public string Menu3 { get; set; }
		public string MenuContact { get; set; }

	}
}

