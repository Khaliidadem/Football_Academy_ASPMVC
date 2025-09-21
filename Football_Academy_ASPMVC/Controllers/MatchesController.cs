using Football_Academy_ASPMVC.Repository.Base;
using Microsoft.AspNetCore.Mvc;
using Football_Academy_ASPMVC.Models;
using Microsoft.Identity.Client;


namespace Football_Academy_ASPMVC.Controllers
{
    public class MatchController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public MatchController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        
        public IActionResult Index()
        {
            IEnumerable<Match> matches =_unitOfWork.matches.FindAll();
            return View(matches);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Match matches) 
        {

            _unitOfWork.matches.Add(matches);
            _unitOfWork.Save();
            TempData["Add"] = "تم اضافة البيانات بنجاح";
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Edit(int Id) 
        {
            var matches = _unitOfWork.matches.FindById(Id);
            return View(matches);
        }
        [HttpPost]
        public IActionResult Edit(Match matches)
        {
            _unitOfWork.matches.Update(matches);
            _unitOfWork.Save();
            TempData["Edit"] = "تم تعديل البيانات بنجاح";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {

            var matches = _unitOfWork.matches.FindById(Id);
            return View(matches);
        }

        [HttpPost]
        public IActionResult Delete(Match matches)
        {
            _unitOfWork.matches.Delete(matches);
            _unitOfWork.Save();
            TempData["Delete"] = "تم تعديل البيانات بنجاح";
            return RedirectToAction("Index");
        }






    }

}
