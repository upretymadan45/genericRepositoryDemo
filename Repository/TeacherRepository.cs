using genericRepoDemo.Data;
using GenericRepoDemo.GenericRepository;
using genericRepoDemo.Models;

namespace GenericRepoDemo.Repository
{
    public class TeacherRepository : GenericRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(ApplicationDbContext context) 
            : base(context)
        {
        }
    }
}