﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace iBusinessManagement.Models
{
    public class ProjectMembersModel
    {
        [Display(Name = "User")]
        public int ProjectId { get; set; }

        public string SelectedUserId { get; set; }

        public IEnumerable<SelectListItem> UsersSelect { get; set; }
    }
}