﻿using BusinessLayer.Concrete;
using DataAccessLayer.Entity_Framework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotification: ViewComponent
    {
        Message2Manager mm = new Message2Manager(new EfMessage2Repository());
        public IViewComponentResult Invoke()
        {
            int id=2;

            var values = mm.GetInboxListByWriter(id);
           
            return View(values);

        }
    }
}

