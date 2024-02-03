using System.ComponentModel.DataAnnotations;

namespace EduHome.Models
{
    public class Footer
    {
        public int Id { get; set; }
        public string FacebookUrl { get; set; }
        public string VcontactUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string PinterestUrl { get; set; }
        public string Adress { get; set; }
        public string FooterNumber1 { get; set; }
        public string FooterNumber2 { get; set; }
        public string Description { get; set; }
        public string FooterLogo { get; set; }
        public string InfoSite { get; set; }
        [Required(ErrorMessage = "Boş saxlanıla Bilməz!"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string SubscribeTitle { get; set; }
        public string SubscribeSubTitle { get; set; }

    }
}
