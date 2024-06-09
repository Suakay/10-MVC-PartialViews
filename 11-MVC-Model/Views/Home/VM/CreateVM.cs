using _11_MVC_Model.Models;

namespace _11_MVC_Model.Views.Home.VM
{
    public class CreateVM
    {
        public Personel Personel { get; set; }
        public List<Department> Departments { get; set; }
        public List<University> Universities { get; set;}
    }
}
