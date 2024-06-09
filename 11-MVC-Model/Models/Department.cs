namespace _11_MVC_Model.Models
{
    public class Department
    {
        public int Id { get; set; } 
        public string DepartmentName {  get; set; }
        public static List<Department> department { get; } = new List<Department>()
        {
            new Department { Id = 1, DepartmentName = "Satış" },
            new Department { Id = 2, DepartmentName = "Planlama" },
            new Department { Id = 3, DepartmentName = "Ar-Ge" },
            new Department { Id = 4, DepartmentName = "Kalite" },
            new Department { Id = 5, DepartmentName = "İnsan Kaynakları" }
        };

    }
}
