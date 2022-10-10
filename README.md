# Extended Controls

Extension of Winform controls MenuStrip and ContextMenuStrip may include other controls over time.

# Usage
Add dll to your program and then add the controls to the control library by selecting the dll. Once done you will see both ContextStripExtended and MenuStripExtended added to the controls. Once there you will be able to edit the colors of the control by setting the theme to either dark, light, or custom. Once set to custom you will be able to edit any of the colors in the style section. It will render in real time the new theme you create.

# Code Explenation
Please feel free to fork this repository and add controls that you wish to see extended in the winforms controls.

# Menu Strip Extended Control #

Extension of the WinForm Control MenuStrip providing a custom renderer so that the control can be re-colored. This custom renderer includes a new ProfessionalColorTable which changes the following items.

### MenuStripColorTable Class (Custom ProfessionalColorTable) ###
- #### Methods ####
    Top Level MenuItem Unpressed Color
    - MenuItemPressedGradientBegin 
    - MenuItemPressedGradientEnd
    - MenuItemBorder

    Top Level MenuItem Pressed Color
    - MenuItemSelectedGradientBegin 
    - MenuItemSelectedGradientEnd

    Sub MenuItems background and highlight Colors
    - MenuBorder
    - ToolStripDropDownBackground
    - MenuItemSelected

    Image background colors
    - ImageMarginGradientBegin
    - ImageMarginGradientMiddle
    - ImageMarginGradientEnd

### CustomMenuRenderer Class (ToolStripProfessionalRenderer) ###
#### (Inherits :base(professionalColorTable: new MenuStripColorTable)) ####
- #### Methods ####
    - OnRenderMenuItemBackground - Handles drawing of the text coloring on the menu strip main and sub menus

### MenuStrip Style Properties ###
- ##### Image Color Properties #####
    - ImageMarginGradientBegin
    - ImageMarginGradientEnd
    - ImageMarginGradientMiddle

- ##### Border Properties #####
    - MenuBorder
    - MenuItemBorder

- ##### Top Level Pressed item properties #####
    - MenuItemPressedGradientBegin
    - MenuItemPressedGradientEnd

- ##### Item selection properties #####
    - MenuItemSelected
    - MenuItemSelectedGradientBegin
    - MenuItemSelectedGradientEnd

- ##### ForeColor #####
    - MenuStripForeColor

- ##### Selected Item ForeColor #####
    - MenuStripSelectedForeColor

- ##### BackColor #####
    - MenuStripGradientBegin
    - MenuStripGradientEnd
 

### Themes ###
 - Light - Sets the theme to the default light color scheme
 - Dark - Sets the theme to the default dark color scheme
 - Custom - Allows the user to select custom colors from the Style properties

# Context Menu Strip Extended Control #

Extension of the WinForm Control ContextMenu providing the same custom renderer as the MenuStrip to keep consistency as well as the same properties and method to load the custom colors.

### ContextStripColorTable Class (Custom ProfessionalColorTable) ###
- #### Methods ####
    Top Level MenuItem Unpressed Color
    - MenuItemBorder

    Sub MenuItems background and highlight Colors
    - MenuBorder
    - ToolStripDropDownBackground
    - MenuItemSelected

    Image background colors
    - ImageMarginGradientBegin
    - ImageMarginGradientMiddle
    - ImageMarginGradientEnd

### CustomContextRenderer Class (ToolStripProfessionalRenderer) ###
#### (Inherits :base(professionalColorTable: new MenuStripColorTable)) ####
- #### Methods ####
    - OnRenderMenuItemBackground - Handles drawing of the text coloring on the context strip main and sub menus

#### Context Menu Style Properties ####
- ##### Image Color Properties #####
    - ImageMarginGradientBegin
    - ImageMarginGradientEnd
    - ImageMarginGradientMiddle

- ##### Border Properties #####
    - MenuBorderColor
    - MenuItemBorderColor

- ##### Item selection properties #####
    - MenuItemSelectedColor

- ##### ForeColor #####
    - ContextForeColor

- ##### Selected Item ForeColor #####
    - SelectedItemForeColor

- ##### BackColor #####
    - ContextStripBackColor

### Themes ###
 - Light - Sets the theme to the default light color scheme
 - Dark - Sets the theme to the default dark color scheme
 - Custom - Allows the user to select custom colors from the Style properties
 
## Note ##
#### In order to use custom colors you must first select Custom from the theme selection in either control ####

 All of these take in the appropriate Settings.Default variables from the project to draw the control. These properties are tied to settings inside the program. Changing these properties will change the colors of the ProfessionalColorTable and how the MenuStrip and context menu are drawn. Both contain support for realtime rendering support. Font is linked directly and changes in the designer in realtime.
