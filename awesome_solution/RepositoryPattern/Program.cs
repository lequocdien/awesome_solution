using RepositoryPattern.Persistence;

namespace RepositoryPattern
{
    class Program
    {
        private const int _authorId = 1;
        private const int _courseId = 1;
        static void Main(string[] args)
        {
            using (var unitOfWork = new UnitOfWork(new PlutoContext()))
            {
                // Example1
                var course = unitOfWork.Courses.Get(_courseId);

                // Example2
                var courses = unitOfWork.Courses.GetCoursesWithAuthors(1, 4);

                // Example3
                var author = unitOfWork.Authors.GetAuthorWithCourses(_authorId);
                if (author == null)
                {
                    System.Console.WriteLine("Not Found dbo.Authors.Id = {0}", _authorId);
                    return;
                }
                unitOfWork.Courses.RemoveRange(author.Courses);
                unitOfWork.Authors.Remove(author);
                unitOfWork.Complete();
            }
            System.Console.WriteLine("OK");
            System.Console.ReadLine();
        }
    }
}
