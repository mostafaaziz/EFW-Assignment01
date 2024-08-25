using EFW_Assignment01.Context;
using Microsoft.EntityFrameworkCore;

namespace EFW_Assignment01
{
    internal class Program
    {
        static void Main(string[] args, DbContext dbContext)
        {
           CoursesDbContext coursesDbContext = new CoursesDbContext();
            coursesDbContext.Students.Where(S => S.Id == 1);
            //dbContext.Database.Migrate();

        }
    }
}
