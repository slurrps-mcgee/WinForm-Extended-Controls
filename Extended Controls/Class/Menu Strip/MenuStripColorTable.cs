using Extended_Controls.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extended_Controls.Class
{
    class MenuStripColorTable : ProfessionalColorTable
    {
        #region Menu BackColor
        public override Color MenuStripGradientBegin
        {
            get { return Settings.Default.MenuStrip_MenuStripGradientBegin; }
        }

        public override Color MenuStripGradientEnd
        {
            get { return Settings.Default.MenuStrip_MenuStripGradientEnd; }
        }
        #endregion

        #region Top Level Menu Unpressed Item Color
        //border of top level menu items
        public override Color MenuItemBorder
        {
            get { return Settings.Default.MenuStrip_MenuItemBorder; }
        }
        //Selected Item hover on top menu
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Settings.Default.MenuStrip_MenuItemSelectedGradientBegin; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Settings.Default.MenuStrip_MenuItemSelectedGradientEnd; }
        }
        #endregion

        #region Top Level Menu Pressed Item Color
        //Pressed Item
        public override Color MenuItemPressedGradientBegin
        {
            get { return Settings.Default.MenuStrip_MenuItemPressedGradientBegin; }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get { return Settings.Default.MenuStrip_MenuItemPressedGradientEnd; }
        }
        #endregion

        #region DropDown Menu List Colors
        //border of menu dropdown List
        public override Color MenuBorder
        {
            get { return Settings.Default.MenuStrip_MenuBorder; }
        }
        //DropDown List Background Color Keep same as MenuStripGradientBegin
        public override Color ToolStripDropDownBackground
        {
            get { return Settings.Default.MenuStrip_MenuStripGradientBegin; }
        }
        //DropDown List selected hover
        public override Color MenuItemSelected
        {
            get { return Settings.Default.MenuStrip_MenuItemSelected; }
        }
        #endregion

        #region Image Back Color
        //Image back color
        public override Color ImageMarginGradientBegin
        {
            get { return Settings.Default.MenuStrip_ImageMarginGradientBegin; }
        }

        public override Color ImageMarginGradientMiddle
        {
            get { return Settings.Default.MenuStrip_ImageMarginGradientMiddle; }
        }

        public override Color ImageMarginGradientEnd
        {
            get { return Settings.Default.MenuStrip_ImageMarginGradientEnd; }
        }
        #endregion
    }
}
