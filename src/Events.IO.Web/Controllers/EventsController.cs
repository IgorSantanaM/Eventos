using Events.IO.Application.Interfaces;
using Events.IO.Application.ViewModels;
using Events.IO.Domain.Core.Notifications;
using Events.IO.Domain.Interface;
using Events.IO.Web.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Events.IO.Site.Controllers
{
    public class EventsController : BaseController
    {
        private readonly IEventAppService _eventAppService;

        public EventsController(IEventAppService eventAppService,
            IDomainNotificationHandler<DomainNotification> notifications, IUser user) : base(notifications, user)
        {
            _eventAppService = eventAppService;
        }

        public IActionResult Index()
        {
            return View(_eventAppService.GetAll());
        }

        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventViewModel = _eventAppService.GetById(id.Value);
            if (eventViewModel == null)
            {
                return NotFound();
            }

            return View(eventViewModel);
        }
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EventViewModel eventViewModel)
        {
            //if (!ModelState.IsValid) return View(eventViewModel);

            eventViewModel.HostId = HostId;
            _eventAppService.Registry(eventViewModel);

            ViewBag.PostReturn = ValidOperation() ? "success,Event registred!" : "error,Event was not registred verify the messages!";

            return View(eventViewModel);
        }
        [Authorize]
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventViewModel = _eventAppService.GetById(id.Value);
            if (eventViewModel == null)
            {
                return NotFound();
            }
            return View(eventViewModel);
        }
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EventViewModel eventViewModel)
        {

            if (!ModelState.IsValid) return View(eventViewModel);

            _eventAppService.Update(eventViewModel);

            ViewBag.PostReturn = ValidOperation() ? "success,Event updated!" : "error,Event was not updated verify the messages!";


            return View(eventViewModel);
        }
        [Authorize]
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventViewModel = _eventAppService.GetById(id.Value);

            if (eventViewModel == null)
            {
                return NotFound();
            }

            return View(eventViewModel);
        }
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _eventAppService.Delete(id);
            return RedirectToAction("Index");
        }
        public IActionResult IncludeAddress(Guid? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var eventViewModel = _eventAppService.GetById(id.Value);
            return PartialView("_IncludeAddress", eventViewModel);
        }
    }
}