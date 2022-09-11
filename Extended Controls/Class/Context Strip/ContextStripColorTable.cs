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
    public class ContextStripColorTable : ProfessionalColorTable
    {
        //Constructor
        public ContextStripColorTable()
        {

        }

        //MAY NOT NEED!!
        //public override Color MenuStripGradientBegin
        //{
        //    get { return Settings.Default.ContextStrip_MenuBackground; }
        //}


        //Colors the background and borders of the ContextStrip
        #region DropDown Menu List Colors
        //Colors the border of the selected MenuItem
        public override Color MenuItemBorder
        {
            get { return Settings.Default.ContextStrip_MenuItemBorder; }
        }

        //Colors the border of the ContextStrip
        public override Color MenuBorder
        {
            get { return Settings.Default.ContextStrip_MenuBorder; }
        }

        //Colors the sub items in the ContextStrip
        public override Color ToolStripDropDownBackground
        {
            get { return Settings.Default.ContextStrip_MenuBackground; }
        }

        //Colors the background of the selected MenuItem
        public override Color MenuItemSelected
        {
            get { return Settings.Default.ContextStrip_MenuItemSelected; }
        }
        #endregion

        //Colors the ImageMargin of the ContextStrip
        #region Image Back Color
        //Begining of the gradient
        public override Color ImageMarginGradientBegin
        {
            get { return Settings.Default.ContextStrip_ImageMarginGradientBegin; }
        }

        //Middle of the gradient
        public override Color ImageMarginGradientMiddle
        {
            get { return Settings.Default.ContextStrip_ImageMarginGradientMiddle; }
        }

        //End of the gradient
        public override Color ImageMarginGradientEnd
        {
            get { return Settings.Default.ContextStrip_ImageMarginGradientEnd; }
        }
        #endregion

    }
}
