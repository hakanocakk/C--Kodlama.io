// See https://aka.ms/new-console-template for more information
using Kodlamaio.Homework.Business;
using Kodlamaio.Homework.DataAccess.Abstracts;
using Kodlamaio.Homework.DataAccess.Concretes;
using Kodlamaio.Homework.Entities;

CourseManager courseManager = new(new CourseDal());
List<Course> courses = courseManager.GetAll();


for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Id + " " + courses[i].Name + " " + courses[i].Description + " " + courses[i].CompletionPercentage);
}


CategoryManager categoryManager=new(new CategoryDal());
List<Category> categories = categoryManager.GetAll();

for (int i = 0; i < categories.Count; i++)
{
    Console.WriteLine(categories[i].Id + " " + categories[i].Name);
}


InstructorManager instructorManager=new(new  InstructorDal());
List<Instructor> instructors = instructorManager.GetAll();

for (int i = 0; i < instructors.Count; i++)
{
    Console.WriteLine(instructors[i].Id + " " + instructors[i].FirstName + " " + instructors[i].LastName);
}