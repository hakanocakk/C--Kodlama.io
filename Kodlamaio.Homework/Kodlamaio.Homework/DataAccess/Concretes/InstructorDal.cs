using Kodlamaio.Homework.DataAccess.Abstracts;
using Kodlamaio.Homework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Homework.DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> instructors;
        public InstructorDal()
        {
            Instructor instructor1 = new Instructor { Id = 1, FirstName = "Engin", LastName = "Demiroğ" };
            Instructor instructor2 = new Instructor { Id = 2, FirstName = "Halit Enes", LastName = "Kalaycı" };
            instructors = new List<Instructor> { instructor1, instructor2 };
        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }
    }
}
