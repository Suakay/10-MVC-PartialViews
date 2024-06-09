using System.ComponentModel.DataAnnotations;

namespace _11_MVC_Model.Views.Enum
{
    public class BloodType
    {
        [Display(Name ="A RH+")]
        ARHP=1,
        [Display(Name = "A RH-")]
        ARHN,
        [Display(Name = "B RH+")]
        BRHN,
        [Display(Name = "B RH-")]

    }
}
