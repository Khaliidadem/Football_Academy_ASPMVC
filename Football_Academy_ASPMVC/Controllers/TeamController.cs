using Football_Academy_ASPMVC.Data;
using Football_Academy_ASPMVC.Models;
using Football_Academy_ASPMVC.Repository.Base;
using Microsoft.AspNetCore.Mvc;

namespace Football_Academy_ASPMVC.Controllers
{
    public class TeamController : Controller
    {
       private readonly IUnitOfWork _unitOfWork;
        public TeamController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        
        }


        public IActionResult Index()
        {
            IEnumerable<Team> teams = _unitOfWork.teams.FindAll();
            return View(teams);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Team teams)
        {
            _unitOfWork.teams.Add(teams);
            _unitOfWork.Save();
            TempData["Add"] = "تم اضافة البيانات بنجاح";
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var teams = _unitOfWork.teams.FindById(Id);
            return View(teams);
        }

        [HttpPost]
        public IActionResult Edit(Team teams)
        {
            _unitOfWork.teams.Update(teams);
            _unitOfWork.Save();
            TempData["Edit"] = "تم تعديل البيانات بنجاح";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int Id)
        {
            var teams = _unitOfWork.teams.FindById(Id);
            return View(teams);
        }

        [HttpPost]
        public IActionResult Delete(Team teams)
        {
            _unitOfWork.teams.Delete(teams);
            _unitOfWork.Save();
            TempData["Delete"] = "تم تعديل البيانات بنجاح";
            return RedirectToAction("Index");
        }
    }
}
