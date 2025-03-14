using Microsoft.AspNetCore.Mvc;

using TPLOCAL1.Models;

//Subject is found at the root of the project and the logo in the wwwroot/ressources folders of the solution
//--------------------------------------------------------------------------------------
//Careful, the MVC model is a so-called convention model instead of configuration,
//The controller must imperatively be named with "Controller" at the end !!!
namespace TPLOCAL1.Controllers
{
    public class HomeController : Controller
    {
               //methode "naturally" called by router
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                //return to the Index view (see routing in Program.cs)
                return View();
            else
            {
                //Call different pages, according to the id pass as parameter
                switch (id)
                {
                    case "OpinionList":

                        var listeAvis = new OpinionList();
                        
                        ViewBag.ListeAvis = listeAvis.GetAvis("XlmFile/DataAvis.xml");
                        return View(id);
                    
                    case "Form":
                        //TODO : call the Form view with data model empty
                        return View(id);
                    
                    default:
                        //return to the Index view (see routing in Program.cs)
                        return View();
                }
            }
        }


        //methode to send datas from form to validation page
        //[HttpPost]
        public ActionResult ValidationFormulaire(Formulaire model)
        {
            //TODO : test if model's fields are set
            //if not, display an error message and stay on the form page
            //else, call ValidationForm with the datas set by the user
                     
            ViewBag.Formulaire = model;

            return View();

        }
    }
}