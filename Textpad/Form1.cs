using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Documents;
using System.Windows.Forms;
using ColorPicker;

namespace Textpadc
{
    public partial class TextPadUI : Form
    {
        FontDialog fontDlg = new FontDialog();
        RTFFontLoader fontLoader;
        RTFList rtfList;
        UserFile userFile;

        public TextPadUI()
        {
            InitializeComponent();

            //Lock the width of the combobox
            const int fontSizeControlWidth = 60;
            cbxFontSize.Width = fontSizeControlWidth;
        }

        private void cbxFonts_Click(object sender, EventArgs e)
        {
            if (redText.SelectionFont != null)
                fontLoader.LoadSelectedFontFamily();
        }

        private void cbxFontSize_Click(object sender, EventArgs e)
        {
            if (redText.SelectionFont != null)
                fontLoader.LoadSelectedFontSizeItem();
        }

        private void cbxFontSize_TextChanged(object sender, EventArgs e)
        {
            if (redText.SelectionFont != null)
                fontLoader.LoadFontSizeText();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redText.Clear();
        }

        private void ctsbColor_Click(object sender, ColorPickerEventArgs e)
        {
            redText.SelectionColor = ctsbColor.Value;
        }

        //Enable only the alpha list type
        private void dbtnAlpha_Click(object sender, EventArgs e)
        {
            if (dbtnAlpha.Checked)
            {
                rtfList.EnableAutoNumbering = false;
                dbtnNumbered.Checked = false;
                tsbBulletList.Checked = false;
                redText.SelectionBullet = false;
                rtfList.EnableAlphaNumbering = true;
            }
            else
            {
                rtfList.EnableAlphaNumbering = false;
            }
        }

        //Enable only the numbered list type
        private void dbtnNumbered_Click(object sender, EventArgs e)
        {
            if (dbtnNumbered.Checked)
            {
                rtfList.EnableAlphaNumbering = false;
                dbtnAlpha.Checked = false;
                tsbBulletList.Checked = false;
                redText.SelectionBullet = false;

                rtfList.EnableAutoNumbering = true;
            }
            else
            {
                rtfList.EnableAutoNumbering = false;
            }
        }

        private void enableDarkModeToolStripMenuItem1_CheckStateChanged(object sender, EventArgs e)
        {
            ThemeRenderer.LoadThemeUI(this, enableDarkModeToolStripMenuItem1.Checked);
        }

        private void frmMainTextpad_FormClosed(object sender, FormClosedEventArgs e)
        {
            redText.Clear();
        }

        private void frmMainTextpad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (redText.Text != "" && redText.Text.Length != 0)
            {
                if (tsbSaveFile.Enabled)
                {
                    if (userFile.SaveFileOnExit(ShowMessage) == DialogResult.Cancel)
                        e.Cancel = true;
                }
                else
                {
                    GC.Collect();
                    rtfList.EnableAlphaNumbering = false;
                    rtfList.EnableAutoNumbering = false;
                    Clipboard.Clear();
                    Close();
                }
            }
        }

        //Perform all methods to load up the editor
        private void frmMainTextpad_Load(object sender, EventArgs e)
        {
            //Start rendering theme 
            ThemeRenderer.LoadThemeUI(this, enableDarkModeToolStripMenuItem1.Checked);
            userFile = new UserFile(this, redText, Text, null);

            //Use fontLoader class to populate all fonts
            fontLoader = new RTFFontLoader(redText, cbxFonts, cbxFontSize);
            fontLoader.LoadWordWrap(wordWrapToolStripMenuItem.Checked);
            fontLoader.LoadAllFont();
            fontLoader.LoadSelectedFontFamily();
            fontLoader.LoadSelectedFontSizeItem();

            //Get the list class for the richtextbox
            rtfList = new RTFList(redText, fontLoader);

            ctsbColor.Value = Color.Black;
            redText.SelectionColor = ctsbColor.Value;
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
                redText.AppendText(Clipboard.GetText());
        }

        //Create and modify new styles for the text editor
        private void preferencesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fontDlg.ShowColor = true;
            fontDlg.ShowEffects = true;

            if (fontDlg.ShowDialog() != DialogResult.Cancel)
            {
                redText.Font = fontDlg.Font;
                redText.ForeColor = fontDlg.Color;
            }
        }

        //Bind the check butons with the richtextbox selections
        private void redText_SelectionChanged(object sender, EventArgs e)
        {
            if (redText.SelectionFont != null)
            {
                //Lists
                tsbBulletList.Checked = redText.SelectionBullet;
                tsbBold.Checked = redText.SelectionFont.Bold;
                tsbItalic.Checked = redText.SelectionFont.Italic;
                tsbUnderline.Checked = redText.SelectionFont.Underline;

                //Alignment
                switch (redText.SelectionAlignment)
                {
                    case HorizontalAlignment.Left:
                        tsbAlignLeft.Checked = true;
                        break;

                    case HorizontalAlignment.Center:
                        tsbAlignCenter.Checked = true;
                        break;

                    case HorizontalAlignment.Right:
                        tsbAlignRight.Checked = true;
                        break;

                    default:
                        tsbAlignLeft.Checked = false;
                        tsbAlignCenter.Checked = false;
                        tsbAlignRight.Checked = false;
                        break;
                }

                cbxFonts.SelectedItem = redText.SelectionFont.FontFamily.Name;
                cbxFontSize.SelectedItem = redText.SelectionFont.Size.ToString();

                copyToolStripMenuItem.Enabled = 
                    (redText.SelectedText != "") ? true : false;
            }      
        }

        private void redText_TextChanged(object sender, EventArgs e)
        {
            tsbSaveFile.Enabled = true;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redText.SelectAll();
        }

        private DialogResult ShowMessage(string text, string caption)
        {
            DialogResult result = MessageBox.Show(text, caption,
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            return result;
        }

        //Enable Center Alignment on Selected Text
        private void tsbAlignCenter_Click(object sender, EventArgs e)
        {
            tsbAlignRight.Checked = false;
            tsbAlignLeft.Checked = false;

            redText.SelectionAlignment = HorizontalAlignment.Center;
        }

        //Enable Left Alignment on Selected Text
        private void tsbAlignLeft_Click(object sender, EventArgs e)
        {
            tsbAlignCenter.Checked = false;
            tsbAlignRight.Checked = false;

            redText.SelectionAlignment = HorizontalAlignment.Left;
        }

        //Enable Right Alignment on Selected Text
        private void tsbAlignRight_Click(object sender, EventArgs e)
        {
            tsbAlignLeft.Checked = false;
            tsbAlignCenter.Checked = false;

            redText.SelectionAlignment = HorizontalAlignment.Right;
        }

        //Use Bold Font Style if Checked
        private void tsbBold_CheckStateChanged(object sender, EventArgs e)
        {
            if (tsbBold.Checked) fontLoader.SetFontStyle(FontStyle.Bold);
            else fontLoader.SetFontStyle(FontStyle.Regular);
        }

        private void tsbBulletList_Click(object sender, EventArgs e)
        {
            //disable other lists to only allow bullets
            rtfList.EnableAutoNumbering = false;
            rtfList.EnableAlphaNumbering = false;

            //Uncheck any other checked list types
            dbtnAlpha.Checked = false;
            dbtnNumbered.Checked = false;

            redText.SelectionBullet = tsbBulletList.Checked;
        }

        //Select the next font size 
        private void tsbFontSize_Click(object sender, EventArgs e)
        {
            int total = cbxFontSize.Items.Count;

            if (cbxFontSize.SelectedIndex < total - 1)
                cbxFontSize.SelectedIndex++;
            else
                cbxFontSize.SelectedIndex = 0;

        }

        private void tsbFontStyle_Click(object sender, EventArgs e)
        {
            fontDlg.ShowEffects = false;
            fontDlg.ShowColor = false;
            fontDlg.AllowScriptChange = false;

            if (fontDlg.ShowDialog() == DialogResult.OK)
            {
                Font globalFont = new Font(fontDlg.Font.FontFamily, fontDlg.Font.Size, fontDlg.Font.Style);
                cbxFonts.SelectedItem = globalFont.FontFamily.Name;
                cbxFontSize.SelectedItem = globalFont.Size.ToString();

                if (globalFont.Underline) tsbUnderline.PerformClick();
                if (globalFont.Bold) tsbBold.PerformClick();
                if (globalFont.Italic) tsbItalic.PerformClick();
            }
        }

        //Allow heading 1 text
        private void tsbHeading1_Click(object sender, EventArgs e)
        {
            if (redText.SelectionFont != null)
            {
                tsbHeading2.Checked = false;
                tsbHeading3.Checked = false;

                fontLoader.SetFontSize(26);
            }
        }

        //Allow heading 2 text
        private void tsbHeading2_Click(object sender, EventArgs e)
        {
            if (redText.SelectionFont != null)
            {
                tsbHeading1.Checked = false;
                tsbHeading3.Checked = false;

                fontLoader.SetFontSize(20);
            }
        }

        //Allow heading 3 text
        private void tsbHeading3_Click(object sender, EventArgs e)
        {
            if (redText.SelectionFont != null)
            {
                tsbHeading2.Checked = false;
                tsbHeading1.Checked = false;

                fontLoader.SetFontSize(16);
            }
        }

        private void tsbImage_Click(object sender, EventArgs e)
        {
            userFile.InsertImage();
        }

        //Use Italic Font Style if Checked
        private void tsbItalic_CheckStateChanged(object sender, EventArgs e)
        {
            if (tsbItalic.Checked) fontLoader.SetFontStyle(FontStyle.Italic);
            else fontLoader.SetFontStyle(FontStyle.Regular);
        }

        private void tsbNewFile_Click(object sender, EventArgs e)
        {
            userFile.CreateNewFile(ShowMessage);
        }

        private void tsbOpenFile_Click(object sender, EventArgs e)
        {
            userFile.OpenFile(ShowMessage);
        }

        private void tsbSaveFile_Click(object sender, EventArgs e)
        {
            userFile.SaveFile();
        }

        //Use Underline Font Style if Checked
        private void tsbUnderline_CheckStateChanged(object sender, EventArgs e)
        {
            if (tsbUnderline.Checked) fontLoader.SetFontStyle(FontStyle.Underline);
            else fontLoader.SetFontStyle(FontStyle.Regular);
        }



        private void tsbUnderline_Click(object sender, EventArgs e)
        {
           // tsbUnderline.Checked = redText.SelectionFont.Underline;
        }

        private void tsbBold_Click(object sender, EventArgs e)
        {
           // tsbBold.Checked = redText.SelectionFont.Bold;
        }

        private void tsbItalic_Click(object sender, EventArgs e)
        {
            //tsbItalic.Checked = redText.SelectionFont.Italic;
        }

        private void wordWrapToolStripMenuItem_CheckStateChanged(object sender, EventArgs e)
        {
            fontLoader.LoadWordWrap(wordWrapToolStripMenuItem.Checked);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbNewFile.PerformClick();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbOpenFile.PerformClick();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbSaveFile.PerformClick();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbUndo_Click(object sender, EventArgs e)
        {
            redText.Undo();
        }

        private void tsbRedo_Click(object sender, EventArgs e)
        {
            redText.Redo();
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userFile.SaveFileAs();
        }

        private void tsbTheme_Click(object sender, EventArgs e)
        {
            enableDarkModeToolStripMenuItem1.PerformClick();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            redText.WordWrap = (wordWrapToolStripMenuItem.Checked) ?
                true : false;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(redText.SelectedText);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}


