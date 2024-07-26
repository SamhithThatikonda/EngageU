namespace WebApplication1.Models.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public bool Subscribed { get; set; }
    }
}