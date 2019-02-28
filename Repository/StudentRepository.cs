using genericRepoDemo.Data;
using GenericRepoDemo.GenericRepository;
using genericRepoDemo.Models;

namespace GenericRepoDemo.Repository
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(ApplicationDbContext context)
            :base(context)
        {
            
        }
    }
}