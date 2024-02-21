using Kodlamaio.Homework.DataAccess.Abstracts;
using Kodlamaio.Homework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Homework.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    List<Course> courses;
    public CourseDal()
    {
        Course course1 = new Course
        {
            Id = 1,
            Name = "Senior Yazılım Geliştirici Yetiştirme Kampı (.NET)",
            Description = "Ücretsiz ve profesyonel bir programla, ileri seviye yazılım geliştirme öğreniyoruz.",
            CompletionPercentage = 55,            
            Price = 0
        };
        Course course2 = new Course
        {
            Id = 2,
            Name = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)",
            Description = "2 ay sürecek ücretsiz ve profesyonel bir programla,sıfırdan yazılım geliştirme öğreniyoruz.",
            CompletionPercentage = 95,            
            Price = 0
        };
        Course course3 = new Course
        {
            Id = 3,
            Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı - Python & Selenium",
            Description = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",
            CompletionPercentage = 0,            
            Price = 0
        };
        Course course4 = new Course
        {
            Id = 4,
            Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA",
            Description = "Profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",
            CompletionPercentage = 45,            
            Price = 0
        };
        Course course5 = new Course
        {
            Id = 5,
            Name = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)",
            Description = "1,5 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",
            CompletionPercentage = 65,            
            Price = 0
        };
        Course course6 = new Course
        {
            Id = 6,
            Name = "Yazılım Geliştirici Yetiştirme Kampı (JAVA + REACT)",
            Description = "2 ay sürecek ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",
            CompletionPercentage = 0,            
            Price = 0
        };
        Course course7 = new Course
        {
            Id = 7,
            Name = "2024 Yazılım Geliştirici Yetiştirme Kampı (C#)",
            Description = "Ücretsiz ve profesyonel bir programla, sıfırdan yazılım geliştirme öğreniyoruz.",
            CompletionPercentage = 73,            
            Price = 0
        };
        Course course8 = new Course
        {
            Id = 8,
            Name = "Programlamaya Giriş için Temel Kurs",
            Description = "PYTHON, JAVA, C# gibi tüm programlama dilleri için temel programlama mantığını anlaşılır örneklerle öğrenin.",
            CompletionPercentage = 100,            
            Price = 0
        };
        courses = new List<Course> { course1, course2, course3, course4, course5, course6, course7, course8 };

    }
    public List<Course> GetAll()
    {
        return courses;
    }
    public void Add(Course course)
    {
        courses.Add(course);
    }
    

}
