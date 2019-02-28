using GenericRepoDemo.GenericRepository;
using genericRepoDemo.Models;

namespace GenericRepoDemo.Repository
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        
    }
}