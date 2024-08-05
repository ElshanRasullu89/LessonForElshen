using LessonForElshen.Entities;
using LessonForElshen.Repository.CategoryRepository;

namespace LessonForElshen.Repository.EntitiRepository
{
    public class EntitiRepository :Repository<Entiti>,IEntitiRepository
    {
        public EntitiRepository(ApplicationDbContext context) : base(context)
        {
        }
            
    }
        
}
