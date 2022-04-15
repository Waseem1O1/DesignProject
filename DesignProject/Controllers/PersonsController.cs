using DesignProject.Models;
using DesignProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DesignProject.Controllers
{
    public class PersonsController : Controller
    {
        public IPersonsViewModel _PersonViewModel { get; }
        public PersonsController(DatabaseContext context, IPersonsViewModel PersonViewModel)
        {
            _PersonViewModel = PersonViewModel;
        }
        public async Task<IActionResult> ListStudent()
        {
            var list = await _PersonViewModel.ListStudent();
            return View(list);
        }
        public async Task<IActionResult> ListEmployee()
        {
            var list = await _PersonViewModel.ListEmployee();
            return View(list);
        }


        [HttpGet]
        public async Task<IActionResult> CreateStudent(int ID)
        {
            var SelectedRow = await _PersonViewModel.CreateStudent(ID);
            return View(SelectedRow);
        }
        [HttpPost]
        public async Task<IActionResult> CreateStudent(Student obj)
        {
            bool CheckIfDatabaseHit = await _PersonViewModel.CreateStudent(obj);
            if (CheckIfDatabaseHit)
            {
                return RedirectToAction("ListStudent");
            }
            return View();

        }
        [HttpGet]
        public async Task<IActionResult> CreateEmployee(int ID)
        {
            var selectedRow =await _PersonViewModel.CreateEmployee(ID);
            return View(selectedRow);
        }
        [HttpPost]
        public async Task<IActionResult> CreateEmployee(Employee obj)
        {
            var IsDataHit = await _PersonViewModel.CreateEmployee(obj);
            if (IsDataHit)
            {
                return RedirectToAction("ListEmployee");
            }
            return View();
            
        }
        [HttpGet]
        public async Task<IActionResult> Delete(int ID)
        {
            var IsDeleted = await _PersonViewModel.DeleteStudent(ID);
            if (IsDeleted)
            {
                return RedirectToAction("ListStudent");
            }
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> DeleteEmployee(int ID)
        {
            var IsDeleted = await _PersonViewModel.Delete(ID);
            if(IsDeleted)
            {
                return RedirectToAction("ListEmployee");
            }
            return View();
            
        }
    }
}
