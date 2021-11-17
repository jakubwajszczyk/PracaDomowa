using System.ComponentModel.DataAnnotations;



namespace PracaDomowa.Models
{
    public class HomeModel
    {
        [Display(Name = "Imię")]
        public string Name { get; set; }
        [Display(Name = "Ilość powtórzeń (zakres: 1-5)")]
        public int Repeat { get; set; }
    }
}
