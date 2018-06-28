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

namespace VampireOverhaul

{
    /*
    *   Main App
    */
    public class MainClass : Script
    {

        private bool isModActive;
        private ModMenu modMenu;

        public MainClass()
        {
            Tick += OnTick;
            KeyDown += OnKeyDown;

            this.isModActive = false;
            this.modMenu = new ModMenu();
        }

        private void OnTick(object sender, EventArgs e)
        {
            if (!this.isModActive)
            {
                return;
            }

            this.modMenu.OnTick();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F10)
            {
                this.ToggleMod();
            }

            if (this.isModActive)
            {
                this.modMenu.OnKeyDown(e);

            }
        }

        private void ToggleMod()
        {
            if (this.isModActive)
            {
                this.isModActive = false;
                UI.ShowSubtitle("Vampire Mod - disabled");
            }
            else
            {
                this.isModActive = true;
                UI.ShowSubtitle("Vampire Mod - enabled");
            }
        }
    }

}
