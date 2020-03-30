﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public interface IEquipName:IGeneric<tabEquipName>
    {
        List<tabEquipName> ListEquipNames(int categoryId, string filter = "");
    }
}
