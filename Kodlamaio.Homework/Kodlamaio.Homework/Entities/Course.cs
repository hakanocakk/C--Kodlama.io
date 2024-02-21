using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Homework.Entities;

public class Course
{
    public int Id { get; set; }       
    public string Name { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public int CompletionPercentage { get; set; }
}
