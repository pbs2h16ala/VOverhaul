using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VampireOverhaul.data
{
    enum enAbilityMode
    {
        Default,
        Stealth
    }

    abstract class AbilityMode
    {
        private double maxHealth { get; set; }
        private double sprintSpeed { get; set; }
        private double walkSpeed { get; set; }

        private double meeleDamage { get; set; }
        private double meelePower { get; set; }

        private double armor { get; set; }

        public AbilityMode()
        {
        }

    }
}
