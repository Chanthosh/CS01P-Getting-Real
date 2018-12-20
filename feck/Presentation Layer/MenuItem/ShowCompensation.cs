﻿using Domain_Layer;
using Domain_Layer.Appendices;
using Domain_Layer.Compensations;
using Presentation_Layer.MenuItem;
using SmartMenuLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation_Layer
{
    class ShowCompensation : IMenuItem
    {
        private Compensation Compensation;

        public ShowCompensation(Compensation compensation)
        {
            Compensation = compensation;
        }

        public bool Activate(SmartMenu smartMenu)
        {
            SmartMenu sm = new SmartMenu(ToString(), "Tilbage");

            foreach (Appendix appendix in Compensation.GetExpenses())
            {
                sm.Attach(new ShowExpense(appendix));
            }

            sm.Activate();

            return false;
        }

        public override string ToString() => Compensation.Title;
    }
}
