using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChangeLifestyle.Areas.Identity.Data;
using ChangeLifestyle.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChangeLifestyle.Controllers
{
    [Authorize]
    public class UsersController : Controller
    {
        private readonly ChangeLifestyleContext changeLifestyleContext;

        public UsersController(ChangeLifestyleContext changeLifestyleContext)
        {
            this.changeLifestyleContext = changeLifestyleContext;
        }
        public async Task<IActionResult> Index()
        {
            return View(await changeLifestyleContext.Users.ToListAsync());
        }

        public IActionResult AddOrEdit(string email)
        {
            if (email == null)
                return View(new ChangeLifestyleUser());
            else
                return View(changeLifestyleContext.Users.Find(email));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("Email, Varsta, Inaltime, Greutate, Data")] ChangeLifestyleUser changeLifestyleUser)
        {
            if(ModelState.IsValid)
            {
                if (changeLifestyleUser.Email == null)
                    changeLifestyleContext.Add(changeLifestyleUser);
                else
                    changeLifestyleContext.Update(changeLifestyleUser);
                await changeLifestyleContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(changeLifestyleUser);
        }

        //public async Task<IActionResult> Delete(string? email)
        //{
        //    var changeLifestyleUser = await changeLifestyleContext.FindAsync(email);
        //    changeLifestyleContext.Users.Remove(changeLifestyleUser);
        //    await changeLifestyleContext.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}
    }
}