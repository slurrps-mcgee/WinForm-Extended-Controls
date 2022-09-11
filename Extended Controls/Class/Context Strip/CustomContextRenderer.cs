using Extended_Controls.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extended_Controls.Class
{
    class CustomContextRenderer : ToolStripProfessionalRenderer
    {
        public CustomContextRenderer() : base(professionalColorTable: new ContextStripColorTable())
        {

        }

        //Handles the coloring of the Text in the ContextStrip
        #region Events
        //On the rendering of a MenuItem Background
        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            base.OnRenderMenuItemBackground(e);
            //If item is enabled
            if (e.Item.Enabled)
            {
                //If item is not on a dropdown and it is selected
                if (e.Item.IsOnDropDown == false && e.Item.Selected)
                {
                    //Color the Text with the Selected ForeColor
                    e.Item.ForeColor = Settings.Default.ContextStrip_Selected_ForeColor;
                }
                else
                {
                    //Color the Text with the regular ForeColor
                    e.Item.ForeColor = Settings.Default.ContextStrip_ForeColor;
                }

                //Handles the Sub Items in the ContextStrip
                //If item is on dropdown and it is selected
                if (e.Item.IsOnDropDown && e.Item.Selected)
                {
                    //Color the Text with the Selected ForeColor
                    e.Item.ForeColor = Settings.Default.ContextStrip_Selected_ForeColor;
                }

                ////Handles Pressed Item for a sub menu
                ////If item is a dropdown and visible and item is not on dropdown
                //if ((e.Item as ToolStripMenuItem).DropDown.Visible && e.Item.IsOnDropDown == false)
                //{
                //    //Color the Text with the Selected ForeColor
                //    e.Item.ForeColor = Settings.Default.ContextStrip_Selected_ForeColor;
                //}
            }
        }

        #endregion

    }
}
