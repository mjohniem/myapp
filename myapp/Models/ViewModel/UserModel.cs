﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myapp.Models.ViewModel
{
    public class UserModel
    {
        public int MessageID { get; set; }
        public int SYSUserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MessageText { get; set; }
        public DateTime? LogDate { get; set; }
    }
}