using FS_PROJECT_ASPNETCore_WebTutorQuizzer.Data;
using FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;

namespace FS_PROJECT_ASPNETCore_WebTutorQuizzer.Controllers
{
    public class SubjectController : Controller
    {
        private readonly DataContext dataContext;

        public SubjectController(DataContext dbContext)
        {
            dataContext = dbContext;    
        }

        public IActionResult Welcome(string name, int numTimes = 2)
        {
            ViewData["Message"] = "Hello" + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }

        // GET: SubjectController
        public IActionResult Index()
        {
            var subjects = dataContext.Subject.ToList();
            return View(subjects);
        }

        // GET: SubjectController/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var subject = await dataContext.Subject
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subject == null)
            {
                return NotFound();
            }
            return View(subject);
        }

        // GET: SubjectController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SubjectController/Create
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Title")] SubjectModel subject)
        {
            if (ModelState.IsValid)
            {
                dataContext.Subject.Add(subject);
                await dataContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }
            return View(subject);
        }

        // GET: SubjectController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SubjectController/Edit/5
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
        }

        // GET: SubjectController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SubjectController/Delete/5
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
