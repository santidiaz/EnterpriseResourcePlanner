﻿using CoreEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameworkCommon.MethodParameters
{
    public class ModifyStudentInput
    {
        public int StudentNumber { get; set; }
        public string NewName { get; set; }
        public string NewLastName { get; set; }
        public List<Subject> NewSubjects { get; set; }
        public Location NewLocation { get; set; }
        public bool HavePickupService { get; set; } = false;
        public decimal NewFeeAmount { get; set; } = -1;
    }
}
