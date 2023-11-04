

using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Models
{
    public class ToDoItem
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool IsComplete { get; set; }

        
    }
}