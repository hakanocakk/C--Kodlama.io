using Kodlamaio.Homework.DataAccess.Abstracts;
using Kodlamaio.Homework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Homework.Business
{
    public class InstructorManager        
    {
        private IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }
        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }
    }
}
