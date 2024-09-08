using _PersonalWebsite.Models;

namespace _PersonalWebsite.ViewModels
{
    public class IndexVM
    {
        public HomePage HomePage { get; set; }
        public Intro Intro { get; set; }
        public Work Work { get; set; }
        public About About { get; set; }
        public SocialMedia SocialMedia { get; set; }
    }
}
