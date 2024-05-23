using Events.IO.Application.Interfaces;
using Events.IO.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Events.IO.Site.Controllers
{
    public class EventsController : Controller
    {
        private readonly IEventAppService _eventAppService;

        public EventsController(IEventAppService eventAppService)
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

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EventViewModel eventViewModel)
        {
            if (!ModelState.IsValid) return View(eventViewModel);

            _eventAppService.Registry(eventViewModel);


            return View(eventViewModel);
        }

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EventViewModel eventViewModel)
        {

            if (!ModelState.IsValid) return View(eventViewModel);

            _eventAppService.Update(eventViewModel);

            return View(eventViewModel);
        }

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

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            _eventAppService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}