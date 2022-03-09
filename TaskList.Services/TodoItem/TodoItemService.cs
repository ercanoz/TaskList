using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TaskList.Data;
using TaskList.Core.Domain.TodoItems;

namespace TaskList.Services.TodoItems
{
    public partial class TodoItemService : ITodoItemService
    {
        #region Fields

        private readonly IRepository<TodoItem> _todoItemRepository;

        #endregion

        #region Ctor

        public TodoItemService(IRepository<TodoItem> todoItemRepository)
        {
            _todoItemRepository = todoItemRepository;
        }

        #endregion

        #region Methods

        public virtual async Task<TodoItem> GetTodoItemByIdAsync(long todoItemId)
        {
            return await _todoItemRepository.GetByIdAsync(todoItemId);
        }

        public virtual async Task DeleteTodoItemAsync(TodoItem todoItem)
        {
            await _todoItemRepository.DeleteAsync(todoItem);
        }

        public virtual async Task<IEnumerable<TodoItem>> GetAllTodoItemsAsync()
        {
            return await _todoItemRepository.GetAllAsync();
        }

        public virtual async Task InsertTodoItemAsync(TodoItem todoItem)
        {
            await _todoItemRepository.InsertAsync(todoItem);
        }

        public virtual async Task UpdateTodoItemAsync(TodoItem todoItem)
        {
            await _todoItemRepository.UpdateAsync(todoItem);
        }

        #endregion
    }
}
