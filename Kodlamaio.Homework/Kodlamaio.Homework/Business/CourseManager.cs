using Kodlamaio.Homework.DataAccess.Abstracts;
using Kodlamaio.Homework.DataAccess.Concretes;
using Kodlamaio.Homework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Homework.Business;

public class CourseManager
{
    private ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
    public List<Course> GetAll()
    {
        return _courseDal.GetAll();
    }
}
