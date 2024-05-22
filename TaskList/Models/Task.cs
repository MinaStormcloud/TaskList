namespace TaskList.Models
{
    public class Task
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
        public string Project { get; set; }
        
    }
}
