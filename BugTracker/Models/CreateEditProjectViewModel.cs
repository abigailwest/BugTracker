﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BugTracker.Models
{
    public class CreateEditProjectViewModel
    {
        public Project Project { get; set; }
        //public int ProjectManagerId { get; set; }
        public SelectList ProjectManagers { get; set; }

    }
}