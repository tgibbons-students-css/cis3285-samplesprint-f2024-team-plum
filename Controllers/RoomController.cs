using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CIS3285_Unit3Sample_2024.Controllers
{
    public class RoomController : Controller
    {
        // GET: RoomController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RoomController/Details/5
        public ActionResult Details(int id)
        {
            return View();
            // Changes Sprint 1 --As a message posting user, I want to create rooms for categorizing conversations -- Omar Sami
        }

        // GET: RoomController/Create
        public ActionResult Create()
        {
            return View();
            // Changes Sprint 1 --As a message posting user, I want to create rooms for categorizing conversations -- Omar Sami
        }

        // POST: RoomController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
            // Changes Sprint 1 -- As a system admin, I want to be able to set a limit to the number of users in any one room -- Tom Gibbons
        }

        // GET: RoomController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
            // Changes Sprint 1 --As a message posting user, I want to create rooms for categorizing conversations -- Omar Sami
        }

        // POST: RoomController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
            // Changes Sprint 1 -- As a system admin, I want to be able to set a limit to the number of users in any one room -- Tom Gibbons

        }

        // GET: RoomController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
            // Changes Sprint 1 --As a message posting user, I want to create rooms for categorizing conversations -- Omar Sami
        }

        // POST: RoomController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
