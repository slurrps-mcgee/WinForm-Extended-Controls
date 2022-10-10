using Extended_Controls.Class;
using Extended_Controls.Properties;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Extended_Controls.Controls
{
    public partial class MenuControlExtended : MenuStrip
    {
        public enum ControlTheme { Light, Dark, Custom };
        private ControlTheme theme;

        public MenuControlExtended()
        {
            InitializeComponent();

            this.RenderMode = ToolStripRenderMode.Professional;
            this.Renderer = new CustomMenuRenderer();
        }


        #region Properties
        #region Text Coloring
        /// <summary>
        /// Gets or sets the ForeColor of the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("MenuStripForeColor")]
        public Color MenuStripForeColor
        {
            get { return Settings.Default.MenuStrip_ForeColor; }
            set
            {
                Settings.Default.MenuStrip_ForeColor = value;
                this.ForeColor = value;
            }
        }

        [Category("Style")]
        [DisplayName("MenuStripSelectedForeColor")]
        public Color MenuStripSelectedForeColor
        {
            get { return Settings.Default.MenuStrip_Selected_ForeColor; }
            set
            {
                Settings.Default.MenuStrip_Selected_ForeColor = value;
                //this.ForeColor = value;
            }
        }
        #endregion

        #region TitleBar Coloring
        /// <summary>
        /// Gets or sets the start color of the gradient used in the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("MenuStripGradientBegin")]
        [Description("Colors the MenuStripGradientBegin of the titlebar")]
        public Color MenuStripGradientBegin
        {
            get { return Settings.Default.MenuStrip_MenuStripGradientBegin; }
            set { Settings.Default.MenuStrip_MenuStripGradientBegin = value; }
        }

        /// <summary>
        /// Gets or sets the end color of the gradient used in the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("MenuStripGradientEnd")]
        [Description("Colors the MenuStripGradientEnd of the titlebar")]
        public Color MenuStripGradientEnd
        {
            get { return Settings.Default.MenuStrip_MenuStripGradientEnd; }
            set { Settings.Default.MenuStrip_MenuStripGradientEnd = value; }
        }
        #endregion

        #region BackColor
        //Removes the default BackColor
        [Browsable(false)]
        public new Color BackColor
        {
            get => base.BackColor;
            set => base.BackColor = value;
        }
        #endregion

        #region Top level Click Coloring
        /// <summary>
        /// Gets or sets the start color of the gradient used when the top-level menu item is selected in the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("MenuItemPressedGradientBegin")]
        [Description("Colors the MenuItemPressedGradientBegin of the top level Click")]
        public Color MenuItemPressedGradientBegin
        {
            get { return Settings.Default.MenuStrip_MenuItemPressedGradientBegin; }
            set { Settings.Default.MenuStrip_MenuItemPressedGradientBegin = value; }
        }

        ///// <summary>
        ///// Gets or sets the middle color of the gradient used when the top-level menu item is selected in the System.Windows.Forms.MenuStrip control.
        ///// </summary>
        //[Category("Style")]
        //[DisplayName("MenuItemPressedGradientMiddle")]
        //public Color MenuItemPressedGradientMiddle
        //{
        //    get { return Settings.Default.MenuStripGradientEnd; }
        //    set { Settings.Default.MenuStripGradientEnd = value; }
        //}

        /// <summary>
        /// Gets or sets the end color of the gradient used when the top-level menu item is selected in the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("MenuItemPressedGradientEnd")]
        [Description("Colors the MenuItemPressedGradientEnd of the top level Click")]
        public Color MenuItemPressedGradientEnd
        {
            get { return Settings.Default.MenuStrip_MenuItemPressedGradientEnd; }
            set { Settings.Default.MenuStrip_MenuItemPressedGradientEnd = value; }
        }
        #endregion

        #region Top Level Hover Coloring
        /// <summary>
        /// Gets or sets the end color of the gradient used when the menu item is selected in the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("MenuItemSelectedGradientBegin")]
        [Description("Colors the MenuItemSelectedGradientBegin of the top level hover")]
        public Color MenuItemSelectedGradientBegin
        {
            get { return Settings.Default.MenuStrip_MenuItemSelectedGradientBegin; }
            set { Settings.Default.MenuStrip_MenuItemSelectedGradientBegin = value; }
        }

        /// <summary>
        /// Gets or sets the end color of the gradient used when the menu item is selected in the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("MenuItemSelectedGradientEnd")]
        [Description("Colors the MenuItemSelectedGradientEnd of the top level hover")]
        public Color MenuItemSelectedGradientEnd
        {
            get { return Settings.Default.MenuStrip_MenuItemSelectedGradientEnd; }
            set { Settings.Default.MenuStrip_MenuItemSelectedGradientEnd = value; }
        }
        #endregion

        #region Selected Item Coloring
        /// <summary>
        /// Gets or sets the color used when the menu item is selected in the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("MenuItemSelected")]
        [Description("Colors the menu item that is selected in the drop down menu")]
        public Color MenuItemSelected
        {
            get { return Settings.Default.MenuStrip_MenuItemSelected; }
            set { Settings.Default.MenuStrip_MenuItemSelected = value; }
        }
        #endregion

        #region Border Coloring
        /// <summary>
        /// Gets or sets the color used when the menu item is selected in the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("MenuBorder")]
        [Description("Colors the MenuBorder around the drop down menu")]
        public Color MenuBorder
        {
            get { return Settings.Default.MenuStrip_MenuBorder; }
            set { Settings.Default.MenuStrip_MenuBorder = value; }
        }

        /// <summary>
        /// Gets or sets the color used when the menu item is selected in the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("MenuItemBorder")]
        [Description("Colors the MenuItemBorder which is the top level items hover border")]
        public Color MenuItemBorder
        {
            get { return Settings.Default.MenuStrip_MenuItemBorder; }
            set { Settings.Default.MenuStrip_MenuItemBorder = value; }
        }
        #endregion

        #region Image Coloring
        /// <summary>
        /// Gets or sets the starting color of the gradient used in the image margin of the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("ImageMarginGradientBegin")]
        [Description("Colors the GradientBegin of the Image on the left of the text")]
        public Color ImageMarginGradientBegin
        {
            get { return Settings.Default.MenuStrip_ImageMarginGradientBegin; }
            set { Settings.Default.MenuStrip_ImageMarginGradientBegin = value; }
        }

        /// <summary>
        /// Gets or sets the middle color of the gradient used in the image margin of the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("ImageMarginGradientMiddle")]
        [Description("Colors the GradientMiddle of the Image on the left of the text")]
        public Color ImageMarginGradientMiddle
        {
            get { return Settings.Default.MenuStrip_ImageMarginGradientMiddle; }
            set { Settings.Default.MenuStrip_ImageMarginGradientMiddle = value; }
        }

        /// <summary>
        /// Gets or sets the ending color of the gradient used in the image margin of the System.Windows.Forms.MenuStrip control.
        /// </summary>
        [Category("Style")]
        [DisplayName("ImageMarginGradientEnd")]
        [Description("Colors the GradientEnd of the Image on the left of the text")]
        public Color ImageMarginGradientEnd
        {
            get { return Settings.Default.MenuStrip_ImageMarginGradientEnd; }
            set { Settings.Default.MenuStrip_ImageMarginGradientEnd = value; }
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
                    MenuStripForeColor = Color.WhiteSmoke;
                    MenuStripSelectedForeColor = Color.FromArgb(45, 45, 45);
                    MenuStripGradientBegin = Color.FromArgb(45, 45, 45);
                    MenuStripGradientEnd = Color.FromArgb(45, 45, 45);
                    MenuItemPressedGradientBegin = Color.LightBlue;
                    MenuItemPressedGradientEnd = Color.FromArgb(125, Color.LightBlue);
                    MenuItemSelectedGradientBegin = Color.LightBlue;
                    MenuItemSelectedGradientEnd = Color.LightBlue;
                    MenuItemSelected = Color.LightBlue;
                    MenuBorder = Color.LightBlue;
                    MenuItemBorder = Color.LightBlue;
                    ImageMarginGradientBegin = Color.FromArgb(45, 45, 45);
                    ImageMarginGradientMiddle = Color.FromArgb(45, 45, 45);
                    ImageMarginGradientEnd = Color.FromArgb(45, 45, 45);
                    break;

                case "Light":
                    MenuStripForeColor = Color.Black;
                    MenuStripSelectedForeColor = Color.Black;
                    MenuStripGradientBegin = Color.WhiteSmoke;
                    MenuStripGradientEnd = Color.WhiteSmoke;
                    MenuItemPressedGradientBegin = Color.LightBlue;
                    MenuItemPressedGradientEnd = Color.WhiteSmoke;
                    MenuItemSelectedGradientBegin = Color.LightBlue;
                    MenuItemSelectedGradientEnd = Color.LightBlue;
                    MenuItemSelected = Color.LightBlue;
                    MenuBorder = Color.LightBlue;
                    MenuItemBorder = Color.LightBlue;
                    ImageMarginGradientBegin = Color.WhiteSmoke;
                    ImageMarginGradientMiddle = Color.WhiteSmoke;
                    ImageMarginGradientEnd = Color.WhiteSmoke;
                    break;

                case "Custom":

                    break;
            }
        }
        #endregion

    }
}
