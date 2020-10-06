using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorTasksOnServer.Model
{
    public class TaskModel
    {
        [Key]
        public string TaskId { get; set; }

        [Required]
        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime? DueDate { get; set; }
        
        public bool IsCompleted { get; set; }
    }
}