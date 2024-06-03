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
        [Authorize] 
        public IActionResult MyEvents()
        {
            return View(_eventAppService.GetEventByHost(HostId));
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
            if (!ModelState.IsValid) return View(eventViewModel);

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
            if (ValidateAuthorEvent(eventViewModel))
            {
                return RedirectToAction("MyEvents", _eventAppService.GetEventByHost(HostId));
            }
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
            if (ValidateAuthorEvent(eventViewModel))
            {
                return RedirectToAction("MyEvents", _eventAppService.GetEventByHost(HostId));
            }
            if (!ModelState.IsValid) return View(eventViewModel);

            eventViewModel.HostId = HostId;
            _eventAppService.Update(eventViewModel);

            ViewBag.PostReturn = ValidOperation() ? "success,Event updated!" : "error,Event was not updated verify the messages!";

            if (_eventAppService.GetById(eventViewModel.Id).Online) {
                eventViewModel.Address = null;
            }
            else
            {
                eventViewModel = _eventAppService.GetById(eventViewModel.Id);
            }
                

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
            
            if (ValidateAuthorEvent(eventViewModel))
            {
                return RedirectToAction("MyEvents", _eventAppService.GetEventByHost(HostId));
            }

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
            if (ValidateAuthorEvent(_eventAppService.GetById(id)))
            {
                return RedirectToAction("MyEvents", _eventAppService.GetEventByHost(HostId));
            }
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
        public IActionResult UpdateAddress(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var eventViewModel = _eventAppService.GetById(id.Value);
            return PartialView("_UpdateAddress", eventViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult IncludeAddress(EventViewModel eventViewModel)
        {
            ModelState.Clear();
            eventViewModel.Address.EventId = eventViewModel.Id;
            _eventAppService.AddAddress(eventViewModel.Address);

            if (ValidOperation())
            {
                string url = Url.Action("GetAddress", "Events", new { id = eventViewModel.Id });
                return Json(new { success = true, url = url });
            }
            return PartialView("_IncludeAddress", eventViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateAddress(EventViewModel eventViewModel)
        {
            ModelState.Clear();
            _eventAppService.UpdateAddress(eventViewModel.Address);

            if (ValidOperation())
            {
                string url = Url.Action("GetAddress", "Events", new { id = eventViewModel.Id });
                return Json(new { success = true, url = url });
            }
            return PartialView("_UpdateAddress", eventViewModel);
        }
        public IActionResult GetAddress(Guid id)
        {
            return PartialView("_DetailsAddress", _eventAppService.GetById(id));
        }
        private bool ValidateAuthorEvent(EventViewModel eventViewModel)
        {
            return eventViewModel.HostId != HostId;
        }
    }
}