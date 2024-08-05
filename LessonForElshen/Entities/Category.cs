using System.ComponentModel.DataAnnotations;

namespace LessonForElshen.Entities
{
    public class Category:Entiti
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
    }
}
