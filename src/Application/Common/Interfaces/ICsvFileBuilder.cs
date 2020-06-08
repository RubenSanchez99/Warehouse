using Warehouse.Application.TodoLists.Queries.ExportTodos;
using System.Collections.Generic;

namespace Warehouse.Application.Common.Interfaces
{
    public interface ICsvFileBuilder
    {
        byte[] BuildTodoItemsFile(IEnumerable<TodoItemRecord> records);
    }
}
