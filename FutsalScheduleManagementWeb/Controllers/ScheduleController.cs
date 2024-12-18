﻿using FutsalScheduleManagementWeb.Data;
using FutsalScheduleManagementWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FutsalScheduleManagementWeb.Controllers
{
    public class ScheduleController : Controller
    {
        //request the applcationdb object to read the data from dataabase
        private readonly ApplicationDbContext _db;
        //we need to tell the application that we need the implementatin of this applicationDbContext wherer the connecton to database is already made
        //and we can retrive the record right away
        //todo that we need to have constructor
        //so inside the constructor we can get the implementation of that

        public ScheduleController(ApplicationDbContext db)
        {
            _db = db;  //populating the local db object(_db) whth this db

        }
        //public IActionResult Index()
        //{
        //    //then we can use this _db to retrive the schedule
        //    //for this
        //    //we create a var
        //    IEnumerable<Schedule> objScheduleList = _db.Schedules.ToList();//no sql codding required

        //    return View(objScheduleList); //this need to capture in view
        //}
        public IActionResult Calendar()
        {
            IEnumerable<Schedule> objScheduleList = _db.Schedules.ToList();
            return View(objScheduleList);
        }
    }
}
