﻿using FS_PROJECT_ASPNETCore_WebTutorQuizzer.Data;
using FS_PROJECT_ASPNETCore_WebTutorQuizzer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FS_PROJECT_ASPNETCore_WebTutorQuizzer.Controllers
{
    public class QuizController : Controller
    {
        // GET: QuizController
        private readonly DataContext dbContext;
        public QuizController(DataContext _dbContext)
        {
            dbContext = _dbContext;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var quiz = dbContext.Quiz.ToList();
            return View(quiz);
        }

        // GET: QuizController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: QuizController/Create
        public IActionResult Create()
        {
            ViewBag.Subject = dbContext.Subject.ToList();
            return View();
           
        }

        // POST: QuizController/Create
        [HttpPost]

        public async Task<IActionResult> Create([Bind("Name", "IsDone", "SubjectId", "DateTime")]QuizModel quiz)
        {
           dbContext.Quiz.Add(quiz);
           await dbContext.SaveChangesAsync();
           return RedirectToAction("Index");
        }

        // GET: QuizController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: QuizController/Edit/5
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

        // GET: QuizController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: QuizController/Delete/5
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