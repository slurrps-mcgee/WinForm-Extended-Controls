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
    class CustomMenuRenderer : ToolStripProfessionalRenderer
    {
        public CustomMenuRenderer() : base(professionalColorTable: new MenuStripColorTable())
        {

        }

        #region OnRenderMenuItemBackground
        //Handles the drawing of the Text Coloring of the Menu Strip
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            base.OnRenderMenuItemBackground(e);

            ////Handles Text Coloring
            if (e.Item.Enabled)
            {
                //Color Selection properly
                //If Item is selected
                //Or if item is selected and dropdown is visible will color both the parent and child selected
                if (e.Item.Selected
                    || (e.Item as ToolStripMenuItem).DropDown.Visible && e.Item.IsOnDropDown == false)
                {
                    e.Item.ForeColor = Settings.Default.MenuStrip_Selected_ForeColor;
                }
                else
                {
                    //Non selected Item
                    e.Item.ForeColor = Settings.Default.MenuStrip_ForeColor;
                }

            }
        }
        #endregion
    }
}
