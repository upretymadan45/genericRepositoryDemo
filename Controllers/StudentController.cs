using System;
using System.IO;
using System.Threading.Tasks;
using genericRepoDemo.Controllers;
using genericRepoDemo.Models;
using GenericRepoDemo.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepoDemo.Controllers
{
    public class StudentController : BaseController<Student>
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IActionResult Index(int page = 1)
        {
            var students = _studentRepository.FindAll();

            var paginatedResult = PaginatedResult(students, page, 10);

            return View(paginatedResult);
        }

        public IActionResult Details(int id){
            var student = _studentRepository.FindSingle(x=>x.Id == id);
            return View(student);
        }

        [HttpGet]
        public IActionResult New()
        {
            return View(new Student());
        }

        [HttpPost]
        public IActionResult New(Student student, IFormFile file)
        {
            try{
            _studentRepository.Create(student);

            UploadFile(file,student.Id);

            }catch(Exception){
                return Content("Could not create student...");
            }
            return RedirectToAction(nameof(Index));
        }

        public void UploadFile(IFormFile file, int studentId){
            var fileName = file.FileName;
            var path = Path.Combine(Directory.GetCurrentDirectory(),"wwwroot/images",fileName);
            using(var fileStream = new FileStream(path,FileMode.Create)){
                file.CopyTo(fileStream);
            }

            var student = _studentRepository.FindSingle(x=>x.Id == studentId);
            student.ImageUrl = fileName;
            _studentRepository.Update(student);
        }
    }
}