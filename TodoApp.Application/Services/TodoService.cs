using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Entities;
using TodoApp.Domain.Interfaces;

namespace TodoApp.Application.Services
{
    public class TodoService
    {
        private readonly ITodoRepository _repository;

        public TodoService(ITodoRepository repository)
        {
            _repository = repository;
        }

        public void Add(string title)
        {
            var item = new TodoItem { Title = title };
            _repository.Add(item);
        }

        public IEnumerable<TodoItem> GetAll() => _repository.GetAll();

        public void Complete(Guid id) => _repository.MarkCompleted(id);

        public void Delete(Guid id) => _repository.Delete(id);
    }
}
