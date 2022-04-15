using DesignProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignProject.ViewModels
{
    public class PersonsViewModel : IPersonsViewModel
    {
        DatabaseContext _context;

        public PersonsViewModel(DatabaseContext context)
        {
            _context = context;

        }
        public async Task<List<Student>> ListStudent()
        {
            var list = await _context.Students.ToListAsync();
            return list;
        }
        public async Task<List<Employee>> ListEmployee()
        {
            var list = await _context.Employees.ToListAsync();
            return list;
        }
        public async Task<Student> CreateStudent(int ID)
        {
            var selectedRow = await _context.Students.Where(id => id.ID == ID).SingleOrDefaultAsync();
            return selectedRow;
        }
        public async Task<bool> CreateStudent(Student obj)
        {
            if (obj.ID == 0)
            {
                await _context.Students.AddAsync(obj);
                _context.SaveChanges();
                return true;
            }
            else
            {
                var selectedRow = (from p in _context.Students where p.ID == obj.ID select p);
                foreach (var UpdateSelectedRow in selectedRow)
                {
                    UpdateSelectedRow.RegistrationDate = obj.RegistrationDate;
                    UpdateSelectedRow.dateofBirth = obj.dateofBirth;
                    UpdateSelectedRow.FullName = obj.FullName;
                    UpdateSelectedRow.Email = obj.Email;
                    UpdateSelectedRow.Gender = obj.Gender;
                    UpdateSelectedRow.CourseName = obj.CourseName;
                    UpdateSelectedRow.Phone = obj.Phone;
                    UpdateSelectedRow.Mobile = obj.Mobile;
                    UpdateSelectedRow.Notes = obj.Notes;
                }
                _context.SaveChanges();
                return true;
            }
        }
        public async Task<Employee> CreateEmployee(int ID)
        {
            var selectedRow = _context.Employees.Where(id => id.ID == ID).SingleOrDefault();
            return selectedRow;
        }

        public async Task<bool> CreateEmployee(Employee obj)
        {
            if (obj.ID == 0)
            {
                await _context.Employees.AddAsync(obj);
                _context.SaveChanges();
                return true;
            }
            else
            {
                var selectedRow = (from p in _context.Employees where p.ID == obj.ID select p);
                foreach (var UpdateSelectedRow in selectedRow)
                {
                    UpdateSelectedRow.JobTitle = obj.JobTitle;
                    UpdateSelectedRow.dateofBirth = obj.dateofBirth;
                    UpdateSelectedRow.FullName = obj.FullName;
                    UpdateSelectedRow.Email = obj.Email;
                    UpdateSelectedRow.Gender = obj.Gender;
                    UpdateSelectedRow.startingDate = obj.startingDate;
                    UpdateSelectedRow.Phone = obj.Phone;
                    UpdateSelectedRow.Mobile = obj.Mobile;
                    UpdateSelectedRow.Notes = obj.Notes;
                }
                _context.SaveChanges();
                return true;
            }
        }
        public async Task<bool> Delete(int ID)
        {
            var selectedRow = _context.Employees.Where(id => id.ID == ID).SingleOrDefault();
            if (selectedRow != null)
            {
                _context.Remove(selectedRow);
                _context.SaveChanges();
                return true;
            }
            return false;

        }
        public async Task<bool> DeleteStudent(int ID)
        {
            var selectedRow = _context.Students.Where(id => id.ID == ID).SingleOrDefault();
            if (selectedRow != null)
            {
                _context.Remove(selectedRow);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
