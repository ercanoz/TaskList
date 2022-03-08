using System;
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



        #endregion
    }
}
