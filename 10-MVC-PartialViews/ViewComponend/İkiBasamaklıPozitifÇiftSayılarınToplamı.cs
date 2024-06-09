using Microsoft.AspNetCore.Mvc;

namespace _10_MVC_PartialViews.ViewComponend
{
    public class İkiBasamaklıPozitifÇiftSayılarınToplamı : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<int> liste = new List<int>();
            for(int i =10;i<100;i++)
            {
                liste.Add(i);
            }
            return View (liste); 
            
        }
    }
   
}
