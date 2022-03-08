using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskList.Core.Domain.TodoItems
{
    public class TodoItem : BaseEntity
    {
        public string Name { get; set; }
        public byte Status { get; set; }
        public long? MainTodoItemId { get; set; }
        public long? ProjectId { get; set; }
        public long? AssignedUserId { get; set; }
        public long CreatedUserId { get; set; }
        public DateTime CreatedAt { get; set; }      
        public bool Deleted { get; set; }
    }
}
