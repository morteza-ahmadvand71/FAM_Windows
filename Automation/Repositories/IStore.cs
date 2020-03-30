﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public interface IStore : IGeneric<tabStores>
    {
        List<tabStores> ListStores(string filter = "");
    }
}
