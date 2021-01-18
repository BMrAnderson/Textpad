using System;
using System.Windows.Forms;
using System.Drawing;
using System.Windows.Shapes;

namespace Textpadc
{
    public class RTFList
    {
        #region Different List Types

        //Line count when user press Enter 
        private int letterCount = -1;
        private int lineCount  = 0;

        private bool isAlphaNumbered = false;
        private bool isAutoNumbered = false;

        private RTFFontLoader FontLoader { get; }
        private RichTextBox RTFLTextBox { get; }

        public RTFList(RichTextBox RTFLTextBox, RTFFontLoader fontLoader)
        {
            this.RTFLTextBox = RTFLTextBox;
            this.FontLoader = fontLoader;
        }

        // A-Z Numbering
        public bool EnableAlphaNumbering
        {
            get
            {
                return isAlphaNumbered;
            }
            set
            {
                if (value)
                {
                    RTFLTextBox.KeyDown -= RedText_KeyDown_Numbering;
                    RTFLTextBox.KeyDown += RedText_KeyDown_Alpha;
                }
                else
                {
                    RTFLTextBox.KeyDown -= RedText_KeyDown_Alpha;
                    letterCount = -1;
                }

                isAlphaNumbered = value;
            }
        }

        //1,2,3... Numbering
        public bool EnableAutoNumbering
        {
            get
            {
                return isAutoNumbered;
            }
            set
            {
                if (value)
                {
                    RTFLTextBox.KeyDown -= RedText_KeyDown_Alpha;
                    RTFLTextBox.KeyDown += RedText_KeyDown_Numbering;
                }
                else
                {
                    RTFLTextBox.KeyDown -= RedText_KeyDown_Numbering;
                    lineCount = 0;
                }

                isAutoNumbered = value;
            }
        }

        //Selects the new Entered Line and add to the RichTextBox
        private void AddNewSelectedLine(string currentLine)
        {
            RTFLTextBox.AppendText("\n" + currentLine);

            int pos = RTFLTextBox.Text.IndexOf(currentLine);
            RTFLTextBox.Select(pos - 1, 2);

            FontLoader.LoadSelectedFontFamily();
            FontLoader.LoadFontSizeText();

            SendCaretToLastPos();
        }

        private void RedText_KeyDown_Alpha(object sender, KeyEventArgs e)
        {
            char[] alphaArray = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    //If line count reach Z in Alphabet 
                    if (letterCount == 25)
                    {
                        //Start Again From A
                        letterCount = -1;
                    }
                    else
                    {
                        letterCount += 1;
                        string newLine = ("  " + alphaArray[letterCount].ToString() + ".");
                        AddNewSelectedLine(newLine); //Add to text area                      
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void RedText_KeyDown_Numbering(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    if (lineCount == 500)
                    {
                        lineCount = 0;
                    }
                    else
                    {
                        lineCount++;
                        string newLine = ("  " + lineCount.ToString() + ".");
                        AddNewSelectedLine(newLine); //Add to text area
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Puts the caret after the numbers 
        private void SendCaretToLastPos()
        {
            for (int i = 0; i < 3; i++)
                SendKeys.Send("{RIGHT}");
        }
        #endregion
    }

    /*
     * Roman Numbers
     I
    II
   III 
     */
}
