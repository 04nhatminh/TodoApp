using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TodoApp.Application.Services;
using TodoApp.Domain.Entities;
using TodoApp.Domain.Interfaces;
using TodoApp.Infrastructure;
using TodoApp.Web.Models;

namespace TodoApp.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly TodoService _service;

        public HomeController(ITodoRepository repository)
        {
            _service = new TodoService(repository);
        }

        public IActionResult Index()
        {
            //var mockItems = new List<TodoItem>
            //{
            //    new TodoItem { Id = Guid.NewGuid(), Title = "Học C#", IsCompleted = false },
            //    new TodoItem { Id = Guid.NewGuid(), Title = "Làm bài tập Clean Architecture", IsCompleted = true },
            //    new TodoItem { Id = Guid.NewGuid(), Title = "Viết báo cáo", IsCompleted = false },
            //};

            //return View(mockItems);

            var todos = _service.GetAll();
            return View(todos);
        }

        [HttpPost]
        public IActionResult Add(string title)
        {
            if (!string.IsNullOrWhiteSpace(title))
            {
                Debug.WriteLine($"Adding task: {title}");
                _service.Add(title);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Complete(Guid id)
        {
            _service.Complete(id);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Delete(Guid id)
        {
            _service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
