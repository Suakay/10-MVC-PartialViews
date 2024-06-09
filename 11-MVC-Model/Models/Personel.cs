using _11_MVC_Model.Views.Enum;

namespace _11_MVC_Model.Models
{
    public class Personel()
    {

    
  
        public int Id { get; set; }
        public string Name { get; set; }    
        public DateTime BirthDate { get; set; }
        public WorkingType WorkingType {  get; set; }
        public int UniversityID {  get; set; }  
        public University University { get; set; }
        public BloodType BloodType { get; set; }    
        public int DepartmentID {  get; set; }
        

        
    }
}
