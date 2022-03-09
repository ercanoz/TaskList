using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskList.Core.Domain.TodoItems;

namespace TaskList.Services.TodoItems
{
    public partial interface ITodoItemService
    {
        Task<TodoItem> GetTodoItemByIdAsync(long todoItemId);

        Task DeleteTodoItemAsync(TodoItem todoItem);

        Task<IEnumerable<TodoItem>> GetAllTodoItemsAsync();

        Task InsertTodoItemAsync(TodoItem todoItem);

        Task UpdateTodoItemAsync(TodoItem todoItem);
    }
}
