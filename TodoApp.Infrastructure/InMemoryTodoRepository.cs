using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domain.Entities;
using TodoApp.Domain.Interfaces;

namespace TodoApp.Infrastructure
{
    public class InMemoryTodoRepository : ITodoRepository
    {
        private readonly List<TodoItem> _items = new List<TodoItem>();

        public void Add(TodoItem item) => _items.Add(item);
        public IEnumerable<TodoItem> GetAll() => _items;
        public void MarkCompleted(Guid id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item != null) item.IsCompleted = true;
        }
        public void Delete(Guid id) => _items.RemoveAll(x => x.Id == id);
    }
}
