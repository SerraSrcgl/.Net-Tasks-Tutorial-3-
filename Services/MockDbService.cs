using System;
using System.Collections.Generic;
using Tutorial3.Models;

namespace Tutorial3.Services
{
    public class MockDbService:IDbService
    {
        private static IEnumerable<Student> _students;

        static MockDbService()
        {
            _students = new List<Student>
            {
                new Student{IdStudent=1,fname="Serra",lname="Saracoglu",indexnumber="123"},
                                new Student{IdStudent=1,fname="Zeynep",lname="Saracoglu",indexnumber="124"},

                                                new Student{IdStudent=1,fname="Zehra",lname="Saracoglu",indexnumber="125"}


            };
        }

        public IEnumerable<Student> GetStudents()
        {
            return _students;

        }
    }
}
