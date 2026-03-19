using StudentsAppSQL9pro.Models;

namespace StudentsAppSQL9pro.DAO
{
    public interface IStudentDAO
    {
        Student? Insert(Student student);
        
        void Update(Student student);

        void Delete(int id);

        Student? GetById(int id);

        List<Student> GetAll();


    }
}
