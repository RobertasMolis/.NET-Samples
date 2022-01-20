﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Models
{
    public class Student : Entity
    {
        public string Sex { get; set; }
        public int SchoolId { get; set; }
        public School School { get; set; }
    }
}
