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
using VampireOverhaul.data;

namespace VampireOverhaul
{
    class ModMenu
    {
        MenuPool menuPool;
        UIMenu modMenu_main;
        UIMenu modMenu_powerMode;
        AbilityBatFlash abFlash;

        public ModMenu()
        {
            this.InitModMenu();
            abFlash = new AbilityBatFlash();
        }
        
        private void InitModMenu()
        {
            this.menuPool = new MenuPool();

            this.modMenu_main = new UIMenu("Vampire Overhaul", "Choose your settings");
            this.menuPool.Add(modMenu_main);

            this.modMenu_powerMode = menuPool.AddSubMenu(modMenu_main, "Power Mode");
        }


        public void OnTick()
        {
            this.ProcessMenusIfNeeded();
        }

        private void ProcessMenusIfNeeded()
        {
            if (this.modMenu_main.Visible)
            {
                this.menuPool.ProcessMenus();
            }
        }

        public void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L)
            {
                abFlash.PerformAbilityAction();
            }
        }

        public void ToggleMainMenu()
        {
            this.modMenu_main.Visible = !this.modMenu_main.Visible;
        }
        
    }
}
