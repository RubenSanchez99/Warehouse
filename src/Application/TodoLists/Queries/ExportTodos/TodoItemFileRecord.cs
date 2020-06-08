using Warehouse.Application.Common.Mappings;
using Warehouse.Domain.Entities;

namespace Warehouse.Application.TodoLists.Queries.ExportTodos
{
    public class TodoItemRecord : IMapFrom<TodoItem>
    {
        public string Title { get; set; }

        public bool Done { get; set; }
    }
}
