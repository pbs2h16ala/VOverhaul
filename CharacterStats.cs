using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTA;
using GTA.Native;
using GTA.Math;
using NativeUI;

namespace VampireOverhaul.data
{
    class CharacterStats
    {
        private double maxHealth { get; set; }
        private double maxStamina { get; set; }
        private double maxMana { get; set; }
        private double armor { get; set; }

        private double sprintSpeed { get; set; }
        private double walkSpeed { get; set; }

        private double meeleDamage { get; set; }
        private double meelePower { get; set; }

        private double lightRsistance { get; set; }
        private double silverResistance { get; set; }
        private double fireResistance { get; set; }
    }
}
