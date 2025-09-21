using Football_Academy_ASPMVC.Data;
using Football_Academy_ASPMVC.Models;
using Football_Academy_ASPMVC.Repository.Base;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace Football_Academy_ASPMVC.Controllers
{
    public class PlayerController : Controller
    {

        private readonly IUnitOfWork _unitOfWork;
        public PlayerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

       
        public IActionResult Index()
        {
            IEnumerable<Player> players = _unitOfWork.players.FindAll();
            return View(players);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Player players) 
        {
            _unitOfWork.players.Add(players);
            _unitOfWork.Save();
            TempData["Add"] = "تم اضافة البيانات بنجاح";
            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var player = _unitOfWork.players.FindById(Id);
            return View(player);
        }

        [HttpPost]
        public IActionResult Edit(Player players)
        {
            _unitOfWork.players.Update(players);
            _unitOfWork.Save();
            TempData["Edit"] = "تم تعديل البيانات بنجاح";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int Id) 
        {
            var player = _unitOfWork.players.FindById(Id);
            return View(player);
        }

        [HttpPost]
        public IActionResult Delete(Player players)
        {
            _unitOfWork.players.Delete(players);
            _unitOfWork.Save();
            TempData["Delete"] = "تم تعديل البيانات بنجاح";
            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public IActionResult Deletepost(int Id)
        //{
        //    var player = _unitOfWork.players.FindById(Id);

        //    _unitOfWork.players.Update(player);
        //    _unitOfWork.Save();
        //    TempData["Add"] = "تم حذف البيانات بنجاح";
        //    return RedirectToAction("Index");
        //}



    }
}
