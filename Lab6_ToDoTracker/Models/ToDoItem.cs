namespace Lab6_ToDoTracker.Models
{
    public class ToDoItem
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime DueDate { get; set; }
        public string Priority { get; set; }
    }
}
