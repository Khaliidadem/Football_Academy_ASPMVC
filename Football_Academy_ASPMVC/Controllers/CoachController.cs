using Football_Academy_ASPMVC.Data;
using Football_Academy_ASPMVC.Models;
using Football_Academy_ASPMVC.Repository.Base;
using Microsoft.AspNetCore.Mvc;

namespace Football_Academy_ASPMVC.Controllers
{
    public class CoachController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CoachController(IUnitOfWork unitOfWork )
        {
           _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            IEnumerable<Coach> coachs = _unitOfWork.coachs.FindAll(); 
            return View(coachs);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Coach coachs)
        {
            _unitOfWork.coachs.Add(coachs);
            _unitOfWork.Save();
            TempData["Add"] = "تم اضافة البيانات بنجاح";
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var Coachs = _unitOfWork.coachs.FindById(Id);
            return View(Coachs);
        }

        [HttpPost]
        public IActionResult Edit(Coach coachs)
        {
            _unitOfWork.coachs.Update(coachs);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var coachs = _unitOfWork.coachs.FindById(Id);
            return View(coachs);
        }
        [HttpPost]
        public IActionResult Delete(Coach coachs)
        {
            _unitOfWork.coachs.Delete(coachs);
            _unitOfWork.Save();
            return RedirectToAction("Index");
        }
    }
}
