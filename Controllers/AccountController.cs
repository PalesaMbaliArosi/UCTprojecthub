using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using UCTprojecthub.Areas.Identity.Data;
using UCTprojecthub.Data;
using UCTprojecthub.IRepository;

namespace UCTprojecthub.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AccountController : Controller
    {

        private readonly iUnitOfWork _unitofWork;

        public AccountController(iUnitOfWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public async Task<IActionResult> Details(string? id)
        {
            throw new Exception();
        }

        public IActionResult Edit(string id)
        {
            return Content(id);
        }

        public async Task<IActionResult> Delete(string? id)
        {
            throw new Exception();
        }

        [HttpGet]
        public IActionResult ListUsers()
        {
            var users = _unitofWork.User.GetUsers();
            return View(users);
        }



    }
}
