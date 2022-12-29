﻿using Microsoft.AspNetCore.Mvc;
using Project_G06.Data;
using Project_G06.Models;
using System.Security.Cryptography;

namespace Project_G06.Controllers
{
    public class NewController : Controller
    {

        private readonly CategoryDbContext _categoryDbContext;

        public NewController(CategoryDbContext categoryDbContext)
        {
            _categoryDbContext = categoryDbContext; 

        }

   



        public IActionResult Index()
        {
            IEnumerable<Category> objCategoryList = _categoryDbContext.categories;   
            return View(objCategoryList);
        }

        //took values already in the dtabase. the values are sent from the databse throguh the categorydbcontexy
        //the degrree details are in the uniprofiledbcontext 
        //Get


        public IActionResult Create()
        {
            return View();
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category university)
        {
            if (ModelState.IsValid)
            {
                /*new part
                CreateHash(university.Password, out byte[] passwordHash, out byte[] passwordSalt);
                university.PasswordHash = Convert.ToBase64String(passwordHash);
                university.PasswordSalt = Convert.ToBase64String(passwordSalt);



                /*new part ends*/


                _categoryDbContext.categories.Add(university);
                _categoryDbContext.SaveChanges();//date goes to the database
                return RedirectToAction("Index");
            }
            return View(university);
        }

        /*new part 

        private void CreateHash(string password , out byte[] passwordHash , out byte[] passwordSalt)
        {
            using(var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }




        //new part ends*/







        //get

        public IActionResult Edit(int? id )
        {
            if (id== null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _categoryDbContext.categories.Find(id);
           // var categoryFromDbFirst = _categoryDbContext.categories.FirstOrDefault(u => u.Id == id); 
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category university)
        {
            if (ModelState.IsValid)
            {
                _categoryDbContext.categories.Update(university);
                _categoryDbContext.SaveChanges();//date goes to the database
                return RedirectToAction("Index");
            }
            return View(university);
        }




        //get
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _categoryDbContext.categories.Find(id);
            // var categoryFromDbFirst = _categoryDbContext.categories.FirstOrDefault(u => u.Id == id); 
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }



        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _categoryDbContext.categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
            
            _categoryDbContext.categories.Remove(obj);
            _categoryDbContext.SaveChanges();
            return RedirectToAction("Index");
        }














    }
    
}
