namespace TodoAPI.Models
{
    /*
     * The TodoItem model class defines the following properties:
     * Id: A unique identifier for each item.
     * Name: A name for the item.
     * IsComplete: A Boolean value that indicates whether the item is complete.
     */
    public class TodoItem
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public bool IsComplete { get; set; }
    }
}
