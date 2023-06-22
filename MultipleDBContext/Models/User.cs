namespace MultipleDBContext.Models
{
    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<Character> Characters { get; set; } = new List<Character>();
    }
}
