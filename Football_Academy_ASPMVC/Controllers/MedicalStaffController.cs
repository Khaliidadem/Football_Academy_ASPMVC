using Football_Academy_ASPMVC.Models;
using Football_Academy_ASPMVC.Repository.Base;
using Microsoft.AspNetCore.Mvc;

namespace Football_Academy_ASPMVC.Controllers 
{
    public class MedicalStaffController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public MedicalStaffController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        public IActionResult Index()
        {
            IEnumerable<MedicalStaff> medicalStaffs = _unitOfWork.medicalStaff.FindAll();
            return View(medicalStaffs);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(MedicalStaff medicalStaffs)
        {
            _unitOfWork.medicalStaff.Add(medicalStaffs);
            _unitOfWork.Save();
            TempData["Add"] = "تم اضافة البيانات بنجاح";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            {
                var medicalStaffs = _unitOfWork.medicalStaff.FindById(Id);
                return View(medicalStaffs);
            }
        }

        [HttpPost]
        public IActionResult Edit(MedicalStaff medicalStaffs)
        {
            _unitOfWork.medicalStaff.Update(medicalStaffs);
            _unitOfWork.Save();
            TempData["Edit"] = "تم تعديل البيانات بنجاح";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int Id) 
        {
            var medicalStaffs = _unitOfWork.medicalStaff.FindById(Id);
            return View(medicalStaffs);
        }

        [HttpPost]
        public IActionResult Delete(MedicalStaff medicalStaffs)
        {
            _unitOfWork.medicalStaff.Delete(medicalStaffs);
            _unitOfWork.Save();
            TempData["Delete"] = "تم تعديل البيانات بنجاح";
            return RedirectToAction("Index");
        }
    }
}

    
