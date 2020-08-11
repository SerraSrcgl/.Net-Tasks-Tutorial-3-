using System;
using System.Collections.Generic;
using Tutorial3.Models;

namespace Tutorial3.Services
{
    public interface IDbService
    {
        public IEnumerable<Student> GetStudents();
    }
}
