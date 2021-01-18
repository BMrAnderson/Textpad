using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Textpadc
{
    public class RTFFontLoader
    {
        #region Load All Formatting

        public RTFFontLoader(RichTextBox textBox, ToolStripComboBox fontFamilyBox,
            ToolStripComboBox fontSizeBox)
        {
            RTFFTextBox = textBox;
            FontFamilyCBX = fontFamilyBox;
            FontSizeCBX = fontSizeBox;
        }

        public ToolStripComboBox FontFamilyCBX { get; set; }
        public ToolStripComboBox FontSizeCBX { get; set; }
        public RichTextBox RTFFTextBox { get; set; }
        //Populate all family fonts into the combobox from Start of program
        public void LoadAllFont()
        {
            foreach (FontFamily fontFamily in FontFamily.Families)
            {
                FontFamilyCBX.Items.Add(fontFamily.Name);
            }
            FontFamilyCBX.SelectedItem = "Arial";
            FontSizeCBX.SelectedItem = "10";

            LoadFontSizeText();
        }

        //!!!REDECLARED METHOD
        public void LoadFontSizeText()
        {
            float fontSize;
            Font selectedFont = RTFFTextBox.SelectionFont;
            float.TryParse(FontSizeCBX.Text, out fontSize);
            RTFFTextBox.SelectionFont = new Font(selectedFont.FontFamily, fontSize, selectedFont.Style);
        }

        public void LoadSelectedFontFamily()
        {
            Font selectedFont = RTFFTextBox.SelectionFont;
            FontFamily selectedFamily = new FontFamily(FontFamilyCBX.SelectedItem.ToString());
            RTFFTextBox.SelectionFont = new Font(selectedFamily, selectedFont.Size, selectedFont.Style);
        }

        //Load the selected Item from cbxFontSize
        public void LoadSelectedFontSizeItem()
        {
            Font selectedFont = RTFFTextBox.SelectionFont;
            float fontSize = float.Parse(FontSizeCBX.SelectedItem.ToString());
            RTFFTextBox.SelectionFont = new Font(selectedFont.FontFamily, fontSize, selectedFont.Style);
        }

        //Enable/Disable the Word Wrap based on its checked state
        public void LoadWordWrap(bool checkedState)
        {
            switch (checkedState)
            {
                case true:
                    RTFFTextBox.WordWrap = true;
                    break;
                case false:
                    RTFFTextBox.WordWrap = false;
                    break;
                default:
                    RTFFTextBox.WordWrap = true;
                    break;
            }
        }
        public void SetFontSize(float size)
        {
            try
            {
                FontSizeCBX.SelectedItem = size.ToString();
                RTFFTextBox.SelectionFont = new Font(RTFFTextBox.SelectionFont.FontFamily,
                    size, RTFFTextBox.SelectionFont.Style);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetFontStyle(FontStyle style)
        {
            try
            {
                FontFamily font = new FontFamily(FontFamilyCBX.SelectedItem.ToString());
                RTFFTextBox.SelectionFont = new Font(font, float.Parse(FontSizeCBX.SelectedItem.ToString()));

                FontFamily currentFont = RTFFTextBox.SelectionFont.FontFamily;
                FontStyle newStyle = RTFFTextBox.SelectionFont.Style;
                float currentSize = RTFFTextBox.SelectionFont.Size;

                switch (style)
                {
                    case FontStyle.Underline:
                        newStyle = RTFFTextBox.SelectionFont.Style ^ FontStyle.Underline;
                        RTFFTextBox.SelectionFont = new Font(currentFont, currentSize, newStyle);
                        break;
                    case FontStyle.Italic:
                        newStyle = RTFFTextBox.SelectionFont.Style ^ FontStyle.Italic;
                        RTFFTextBox.SelectionFont = new Font(currentFont, currentSize, newStyle);
                        break;
                    case FontStyle.Bold:
                        newStyle = RTFFTextBox.SelectionFont.Style ^ FontStyle.Bold;
                        RTFFTextBox.SelectionFont = new Font(currentFont, currentSize, newStyle);
                        break;
                    default:
                        newStyle = RTFFTextBox.SelectionFont.Style ^ FontStyle.Regular;
                        RTFFTextBox.SelectionFont = new Font(currentFont, currentSize, newStyle);
                        break;
                }

                RTFFTextBox.SelectionFont = new Font(currentFont, currentSize, newStyle);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Error");
            }
        }
        #endregion

    }


}
