using Extended_Controls.Class;
using Extended_Controls.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extended_Controls.Controls
{
    public partial class ContextStripExtended : ContextMenuStrip
    {
        public enum ControlTheme { Light, Dark, Custom };
        private ControlTheme theme;

        public ContextStripExtended()
        {
            InitializeComponent();

            this.RenderMode = ToolStripRenderMode.Professional;
            //Sets the renderer to a new ProfessionalRenderer giving it the ContextStripExtender
            this.Renderer = new CustomContextRenderer();
        }

        #region Properties
        #region Text Coloring
        /// <summary>
        /// Gets or sets the ForeColor of the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("ContextForeColor")]
        public Color ContextStripForeColor
        {
            get { return Settings.Default.ContextStrip_ForeColor; }
            set
            {
                Settings.Default.ContextStrip_ForeColor = value;
                this.ForeColor = value;
            }
        }

        [Category("Style")]
        [DisplayName("SelectedItemForeColor")]
        public Color ContextStripSelectedForeColor
        {
            get { return Settings.Default.ContextStrip_Selected_ForeColor; }
            set
            {
                Settings.Default.ContextStrip_Selected_ForeColor = value;
                //this.ForeColor = value;
            }
        }
        #endregion

        #region BackColor
        [Category("Style")]
        [DisplayName("ContextStripBackColor")]
        public Color ContextMenuBackgroundColor
        {
            //May just need to alter the backColor
            get { return Settings.Default.ContextStrip_MenuBackground; }
            set
            {
                Settings.Default.ContextStrip_MenuBackground = value;
                this.BackColor = value;
            }
        }
        #endregion

        //Removes the default BackColor
        [Browsable(false)]
        public new Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }

        #region Selected Item Coloring
        /// <summary>
        /// Gets or sets the color used when the menu item is selected in the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("MenuItemSelectedColor")]
        public Color ContextMenuItemSelectedColor
        {
            get { return Settings.Default.ContextStrip_MenuItemSelected; }
            set { Settings.Default.ContextStrip_MenuItemSelected = value; }
        }
        #endregion

        #region Border Coloring
        /// <summary>
        /// Gets or sets the color used when the menu item is selected in the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("MenuBorderColor")]
        public Color ContextMenuBorderColor
        {
            get { return Settings.Default.ContextStrip_MenuBorder; }
            set { Settings.Default.ContextStrip_MenuBorder = value; }
        }

        /// <summary>
        /// Gets or sets the color used when the menu item is selected in the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("MenuItemBorderColor")]
        public Color ContextMenuItemBorderColor
        {
            get { return Settings.Default.ContextStrip_MenuItemBorder; }
            set { Settings.Default.ContextStrip_MenuItemBorder = value; }
        }
        #endregion

        #region Image Coloring
        /// <summary>
        /// Gets or sets the starting color of the gradient used in the image margin of the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("ImageMarginGradientBeginColor")]
        public Color ImageMarginGradientBeginColor
        {
            get { return Settings.Default.ContextStrip_ImageMarginGradientBegin; }
            set { Settings.Default.ContextStrip_ImageMarginGradientBegin = value; }
        }

        /// <summary>
        /// Gets or sets the middle color of the gradient used in the image margin of the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("ImageMarginGradientMiddleColor")]
        public Color ImageMarginGradientMiddleColor
        {
            get { return Settings.Default.ContextStrip_ImageMarginGradientMiddle; }
            set { Settings.Default.ContextStrip_ImageMarginGradientMiddle = value; }
        }

        /// <summary>
        /// Gets or sets the ending color of the gradient used in the image margin of the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("ImageMarginGradientEndColor")]
        public Color ImageMarginGradientEndColor
        {
            get { return Settings.Default.ContextStrip_ImageMarginGradientEnd; }
            set { Settings.Default.ContextStrip_ImageMarginGradientEnd = value; }
        }
        #endregion

        [Category("Theme")]
        [DisplayName("Theme Selection")]
        [Description("Chooses a built in theme or if choosing custom lets you choose the colors from the Style Properties")]
        public ControlTheme Theme
        {
            get { return theme; }
            set
            {
                theme = value;
                ApplyTheme(theme.ToString());
            }
        }

        #endregion

        #region Methods
        private void ApplyTheme(string theme)
        {
            switch (theme)
            {
                case "Dark":
                    ContextStripForeColor = Color.WhiteSmoke;
                    ContextStripSelectedForeColor = Color.FromArgb(45, 45, 45);
                    ContextMenuBackgroundColor = Color.FromArgb(45, 45, 45);
                    ContextMenuItemSelectedColor = Color.LightBlue;
                    ContextMenuBorderColor = Color.LightBlue;
                    ContextMenuItemBorderColor = Color.LightBlue;
                    ImageMarginGradientBeginColor = Color.FromArgb(45, 45, 45);
                    ImageMarginGradientMiddleColor = Color.FromArgb(45, 45, 45);
                    ImageMarginGradientEndColor = Color.FromArgb(45, 45, 45);
                    break;

                case "Light":
                    ContextStripForeColor = Color.Black;
                    ContextStripSelectedForeColor = Color.Black;
                    ContextMenuBackgroundColor = Color.WhiteSmoke;
                    ContextMenuItemSelectedColor = Color.LightBlue;
                    ContextMenuBorderColor = Color.LightBlue;
                    ContextMenuItemBorderColor = Color.LightBlue;
                    ImageMarginGradientBeginColor = Color.WhiteSmoke;
                    ImageMarginGradientMiddleColor = Color.WhiteSmoke;
                    ImageMarginGradientEndColor = Color.WhiteSmoke;
                    break;

                case "Custom":

                    break;
            }
        }
        #endregion
    }
}
