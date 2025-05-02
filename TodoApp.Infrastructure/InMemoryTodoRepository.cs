using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public void Add(TodoItem item)
        {
            Debug.WriteLine($"Adding task in Repo: {item.Title}");
            _items.Add(item);
        }

        public IEnumerable<TodoItem> GetAll()
        {
            return _items;
        }
        public void MarkCompleted(Guid id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                item.IsCompleted = true;
            }
        }

        public void Delete(Guid id)
        {
            var item = _items.FirstOrDefault(x => x.Id == id);
            if (item != null)
            {
                _items.Remove(item);
            }
        }
    }
}
