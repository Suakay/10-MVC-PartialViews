using System.ComponentModel.DataAnnotations;

namespace _11_MVC_Model.Models
{
    public enum WorkingType
    {
        [Display(Name ="Tam zamanlı")]
        FullTime=1,
        [Display(Name ="Yarı Zamanlı")]
        PartTime=2,
        [Display(Name = "Proje Bazlı")]
        ProjectBased=3,
        [Display(Name = "Serbest Zamanlı")]
        Freelance=4,

    }
}
