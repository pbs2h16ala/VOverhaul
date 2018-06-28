using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GTA;
using GTA.Native;
using GTA.Math;

namespace VampireOverhaul.data
{
    abstract class CharacterClass
    {
        private CharacterStats characterStats { get; set; }
        private List<Ability> listOfAbilities { get; set; }
        private AbilityMode currentAbillityMode { get; set; }

        private bool canTransform { get; set;}
        private bool isTransformed { get; set; }
        private Model transformationModel { get; set; }

    }
}
