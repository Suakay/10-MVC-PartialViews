using _11_MVC_Model.Models;
using _11_MVC_Model.Views.Home.VM;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace _11_MVC_Model.Controllers
{
    public class PersonelController : Controller
    {
        public IActionResult Index()
        {
            // Personel ve Departman listeleri oluşturulur
            List<Personel> personeller = new List<Personel>()
        {
            new Personel() { Id = 1, Name = "Mustafa Yılmaz", BirthDate = new DateTime(2000, 6, 12) },
            new Personel() { Id = 2, Name = "Ahmet Yılmaz", BirthDate = new DateTime(1970, 6, 12) },
            new Personel() { Id = 3, Name = "Ayşe Kaya", BirthDate = new DateTime(1980, 6, 12) },
            new Personel() { Id = 4, Name = "Mehmet Öz", BirthDate = new DateTime(2001, 6, 12) }
        };

            List<Department> department = new List<Department>()
        {
            new Department() { Id = 1, DepartmentName = "Satış" },
            new Department() { Id = 2, DepartmentName = "Planlama" },
            new Department() { Id = 3, DepartmentName = "Ar-Ge" },
            new Department() { Id = 4, DepartmentName = "Kalite" },
            new Department() { Id = 5, DepartmentName = "İnsan Kaynakları" }
        };

            // View'a personeller listesini gönderin
            return View(personeller);
        }

        public IActionResult Create()
        {
            ViewBag.Deparment = Department
            return View();
            // departmanlar listesini ViewBag'e aktarı

            return View();
        }
        public IActionResult Edit(int id)
        {
            CreateVM vm = new CreateVM();
            vm.Personel=Personeller.Where(x => x.Id == id).First(); 
            vm.Personel=personeller

            return View();
        }
        [HttpPost]
        public IActionResult Edit(Personel personel)
        {
            int index=personel.FidIndex()    

        }
        public IActionResult Delete(int id)
        {
            int index = Personeller.FidIndex(p => p.ID == id);
            Personel.RemoveAt(index);
            return RedirectToAction("Index",Personel); 
            

        }
        public IActionResult Add(int id)
        {
            int index =University.FidIndex(p => p.ID == id);
            Personel.RemoveAt(index);
            return RedirectToAction("Index", Personel);


        }
        public IActionResult Delete(int id)
        {
            int index = Personeller.FidIndex(p => p.ID == id);
            Personel.RemoveAt(index);
            return RedirectToAction("Index", Personel);


        }

    }








}

