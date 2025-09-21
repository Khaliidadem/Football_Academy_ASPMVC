using Football_Academy_ASPMVC.Models;
using Football_Academy_ASPMVC.Repository.Base;
using Microsoft.AspNetCore.Mvc;

namespace Football_Academy_ASPMVC.Controllers
{
    public class SubscriptionController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public SubscriptionController(IUnitOfWork unitOfWork)   
        {
            _unitOfWork = unitOfWork;
        }

        //public IActionResult Index()
        //{
        //    var Subscription = _unitOfWork.subscriptions.Include(s => s.Player);

        //    return View(subscriptions.ToList());
        //}
    }
}
