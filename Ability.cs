using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VampireOverhaul.data
{
    abstract class Ability
    {
        private bool isPassiveAbility { get; set; }

        public abstract void PerformAbilityAction();
    }
}
