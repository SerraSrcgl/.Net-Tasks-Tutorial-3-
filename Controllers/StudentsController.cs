using System;
using Microsoft.AspNetCore.Mvc;
using Tutorial3.Models;
using Tutorial3.Services;


//Controllers return answer for request of clients
//it will return some data about students

namespace Tutorial3.Controllers
{
    [ApiController]
    [Route("api.students")]
    public class StudentsController:ControllerBase
    {
        private IDbService _dbService;

        public StudentsController(IDbService dbService)
        {
            this._dbService = dbService;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(_dbService.GetStudents());

        }

        /*   [HttpGet]
        public string GetStudents()
        {
            return "Serra,Zeynep,Zehra";
        }*/



        /*[HttpGet]
     public string GetStudents(string orderby)
        {
            return $"Serra,Zeynep,Zehra sortBy={orderby}";
        }*/

        //pass data by it's attribute

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            if (id == 1)
            {
                return Ok("Zeynep");
            }
            return NotFound("no student found");
        }
        [HttpPost]
        public IActionResult createStudent(Student student)
        {
            student.indexnumber = $"s(new Random().Next(1,20000)";
            return Ok(student);
        }
        Student student = new Student();



        [HttpPut("{id}")]
        public IActionResult PutStudent(int id)
        {
            return Ok("update completed!");
        }
        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            return Ok("Student deleted");
        }
        }
}







