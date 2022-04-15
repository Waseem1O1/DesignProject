using DesignProject.Models;

namespace DesignProject.ViewModels
{
    public interface IPersonsViewModel
    {
        Task<List<Student>> ListStudent();
        Task<List<Employee>> ListEmployee();
        Task<Student> CreateStudent(int ID);
        Task<bool> CreateStudent(Student obj);
        Task<Employee> CreateEmployee(int ID);
        Task<bool> CreateEmployee(Employee obj);
        Task<bool> Delete(int ID);
        Task<bool> DeleteStudent(int ID);
    }
}
