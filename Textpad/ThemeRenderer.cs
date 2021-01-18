using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Textpadc
{
    public class ThemeRenderer
    {
        #region Theme Render Class For Dark Mode
        //Dark Mode Renderer Class 
        //Access the ToolStripProfessionalRender Class to override the Menus UI
        private class DarkModeRendererEnabled : ToolStripProfessionalRenderer
        {      
            public DarkModeRendererEnabled() : base(new DarkModeRenderer()) { }

            protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
            {
                e.TextColor = Color.White;
                base.OnRenderItemText(e);
            }

            protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
            {
                if (!e.Item.Selected)
                base.OnRenderButtonBackground(e);
                else
                {
                    Rectangle rect = new Rectangle(0, 0, e.Item.Size.Width - 1, e.Item.Size.Height - 1);
                    var darkBrush = new SolidBrush(Color.FromArgb(50, 50, 50));
                    var darkPen = new Pen(Color.FromArgb(50, 50, 50));
                    e.Graphics.FillRectangle(darkBrush, rect);
                    e.Graphics.DrawRectangle(darkPen, rect);
                }

                var btn = e.Item as ToolStripButton;
                if (btn != null && btn.CheckOnClick && btn.Checked)
                {
                    SolidBrush darkBrush = new SolidBrush(Color.FromArgb(41, 41, 41));
                    Rectangle bounds = new Rectangle(Point.Empty, e.Item.Size);
                    e.Graphics.FillRectangle(darkBrush, bounds);
                }
            }
            protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e) { }
        }


        //Creates the DarkMode Colors for The MenuTool
        private class DarkModeRenderer : ProfessionalColorTable
        {
            public override Color MenuBorder => Color.Black;

            public override Color MenuItemBorder => Color.FromArgb(41, 41, 41);

            public override Color SeparatorDark => Color.Black;

            public override Color MenuItemPressedGradientBegin => Color.FromArgb(65, 65, 65);

            public override Color MenuItemPressedGradientMiddle => Color.FromArgb(65, 65, 65);

            public override Color MenuItemPressedGradientEnd => Color.FromArgb(65, 65, 65);

            public override Color MenuItemSelectedGradientBegin => Color.FromArgb(65, 65, 65);

            public override Color MenuItemSelectedGradientEnd => Color.FromArgb(65, 65, 65);

            public override Color MenuStripGradientBegin => Color.FromArgb(65, 65, 65);

            public override Color MenuStripGradientEnd => Color.FromArgb(65, 65, 65);

            public override Color ImageMarginGradientBegin => Color.FromArgb(65, 65, 65);

            public override Color ImageMarginGradientMiddle => Color.FromArgb(65, 65, 65);

            public override Color ImageMarginGradientEnd => Color.FromArgb(65, 65, 65);

            public override Color ToolStripDropDownBackground => Color.FromArgb(65, 65, 65);

            public override Color MenuItemSelected => Color.FromArgb(41, 41, 41);

        }
        #endregion

        #region Enable or Disable Dark Mode Methods

        //Run through every character and change it to a new color if it have a specific color
        private static void ChangeRTFForeColor(RichTextBox richTextBox, Color oldColor, Color newColor)
        {
            if (richTextBox.Text.Length != 0 && richTextBox.Text != "")
                try
                {
                    for (int i = 0; i < richTextBox.TextLength; i++)
                    {
                        richTextBox.Select(i, 1);
                        if (richTextBox.SelectionColor == oldColor)
                        {
                            richTextBox.SelectionColor = newColor;
                        }
                    }
                    richTextBox.DeselectAll();
                    SendKeys.Send("{RIGHT}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error");
                }
        }

        private static void EnableDarkMode(TextPadUI mainForm)
        {
            //Create a dark rgb Color
            Color darkColor = (Color.FromArgb(65, 65, 65));

            //Change menu color to dark
            mainForm.mnuEditor.Renderer = new DarkModeRendererEnabled();
            mainForm.tlsEditor.Renderer = new DarkModeRendererEnabled();

            mainForm.mnuEditor.BackColor = darkColor;
            mainForm.tlsEditor.BackColor = darkColor;

            //Loads the Light colors for the font buttons in toolstrip to achieve contrast
            mainForm.tsbFontStyle.Image = Bitmap.FromFile("Controls_img\\font_style_formatting_light_20px.png");
            mainForm.tsbFontSize.Image = Bitmap.FromFile("Controls_img\\increase_font_light_20px.png");
            mainForm.tsbUnderline.Image = Bitmap.FromFile("Controls_img\\underline_light_20px.png");
            mainForm.tsbItalic.Image = Bitmap.FromFile("Controls_img\\italic_light_20px.png");
            mainForm.tsbBold.Image = Bitmap.FromFile("Controls_img\\bold_light_20px.png");

            //First Menu Item Color (Bug) Changes to White when Dark Mode is On 
            mainForm.fileToolStripMenuItem.BackColor = darkColor;
            mainForm.pnlAdvancedEditor.BackColor = darkColor;
            mainForm.ctsbColor.BackColor = darkColor;

            mainForm.dbtnAlpha.BackColor = darkColor;
            mainForm.dbtnNumbered.BackColor = darkColor;
            mainForm.dbtnAlpha.ForeColor = Color.Black;
            mainForm.dbtnNumbered.ForeColor = Color.Black;

            //Text Area Color to dark
            ChangeRTFForeColor(mainForm.redText,Color.Black, Color.White);
            mainForm.redText.BackColor = Color.FromArgb(41, 41, 41);
            mainForm.BackColor = darkColor;
        }

        private static void DisableDarkMode(TextPadUI padUI)
        {
            //Create a light color
            Color lightColor = (Color.FromKnownColor(KnownColor.Control));

            //Remove the DarkMode Renderer class from the menu/toolstip   
            padUI.mnuEditor.Renderer = null;
            padUI.tlsEditor.Renderer = null;
            padUI.mnuEditor.BackColor = lightColor;
            padUI.tlsEditor.BackColor = lightColor;

            //Loads the Dark colors for the font buttons in toolstrip to achieve contrast
            padUI.tsbFontStyle.Image = Bitmap.FromFile("Controls_img\\font_style_formatting_dark_20px.png");
            padUI.tsbFontSize.Image = Bitmap.FromFile("Controls_img\\increase_font_dark_20px.png");
            padUI.tsbUnderline.Image = Bitmap.FromFile("Controls_img\\underline_dark_20px.png");
            padUI.tsbItalic.Image = Bitmap.FromFile("Controls_img\\italic_dark_20px.png");
            padUI.tsbBold.Image = Bitmap.FromFile("Controls_img\\bold_dark_20px.png");

            //Changes menu backcolors back to light
            padUI.fileToolStripMenuItem.BackColor = lightColor;
            padUI.pnlAdvancedEditor.BackColor = lightColor;
            padUI.ctsbColor.BackColor = lightColor;

            padUI.dbtnAlpha.BackColor = lightColor;
            padUI.dbtnNumbered.BackColor = lightColor;
            padUI.dbtnAlpha.ForeColor = Color.Black;
            padUI.dbtnNumbered.ForeColor = Color.Black;

            //Text area color to light         
            ChangeRTFForeColor(padUI.redText,Color.White, Color.Black);
            padUI.redText.BackColor = Color.White;
            padUI.BackColor = Color.White;
        }

        //Disable/Enable DarkMode based on its checked state
        public static void LoadThemeUI(TextPadUI padUI, bool selectedTheme)
        {
            switch (selectedTheme)
            {
                case true:
                    EnableDarkMode(padUI);
                    break;
                case false:
                    DisableDarkMode(padUI);
                    break;
                default:
                    DisableDarkMode(padUI);
                    break;
            }
        }
        #endregion 
    }
}
