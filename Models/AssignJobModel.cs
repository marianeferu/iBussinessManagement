﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iBusinessManagement.Models
{
    public class AssignJobModel
    {
        [Display(Name = "Assignee")]
        public int TaskId { get; set; }

        public string AssigneeId { get; set; }

        public IEnumerable<SelectListItem> MembersSelect { get; set; }
    }
}