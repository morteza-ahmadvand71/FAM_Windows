﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class Shift:Generic<tabShifts>,IShift
    {
        public Shift(DbContext db) : base(db)
        {
        }
    }
}
