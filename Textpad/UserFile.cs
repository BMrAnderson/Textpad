using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Textpadc
{
    public class UserFile
    {
        //Send Two Strings to a MessageBox when FileIO occurs
        public delegate DialogResult SendMessage(string text, string caption);

        //Gets the new opened FilePath FileName, FileExtension
        private TextPadUI MainUI { get; set; }
        private RichTextBox TextBox { get; set; }
        private string FilePath { get; set; }
        private string FileName { get; set; }
        private string FullFileName { get; set; }

        public UserFile(TextPadUI mainUI ,RichTextBox textBox, string fileName, string filePath = null)
        {
            this.TextBox = textBox;
            this.FileName = fileName;
            this.FilePath = filePath;
            this.MainUI = mainUI;
        }

        /* Retrieve File Path Directory 
         * Retrieve File Name with Extension
         * Retrieve only the Name of the file */
        private void SetNewFileName(string filePath)
        {
            FilePath = filePath;
            FullFileName = Path.GetFileName(filePath);
            FileName = Path.GetFileNameWithoutExtension(filePath);

            //Sets the form's text to the filename
            MainUI.Text = FileName;
        }

        //Save the contents from the RichTextBox to the file
        private void SaveFileFromRtb(string filePath)
        {
            switch(Path.GetExtension(filePath))
            {
                case ".rtf":
                    TextBox.SaveFile(filePath, RichTextBoxStreamType.RichText);
                    break;

                case ".txt":
                    TextBox.SaveFile(filePath, RichTextBoxStreamType.PlainText);
                    break;
            }
        }

        //Load the contents of specified file to RichTextBox
        private void LoadFileToRtb(string filePath)
        {
            switch (Path.GetExtension(filePath))
            {
                case ".rtf":
                    TextBox.LoadFile(filePath, RichTextBoxStreamType.RichText);
                    break;

                case ".txt":
                    TextBox.LoadFile(filePath, RichTextBoxStreamType.PlainText);
                    break;
            }
        }

        //Open up a new file
        private void Open()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "RTF Files|*.rtf|Txt Files|*.txt";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                openFile.FileName = openFile.FileName;
                if (openFile.CheckFileExists)
                {
                    LoadFileToRtb(openFile.FileName);
                    SetNewFileName(openFile.FileName);
                }
            }
        }

        //Save as a new file or overwrite existing file
        public void SaveFile()
        {
            if (!File.Exists(FilePath))
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "RTF Files|*.rtf|Txt Files|*.txt";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    SaveFileFromRtb(saveFile.FileName);
                    SetNewFileName(saveFile.FileName);
                }
            }
             else
            {
                SaveFileFromRtb(FilePath);
            }
        }

        public void SaveFileAs()
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "All Files|*.*|RTF File|*.rtf|Txt File|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                SaveFileFromRtb(saveFile.FileName);
                SetNewFileName(saveFile.FileName);
            }
        }

        public DialogResult SaveFileOnExit(SendMessage message)
        {
            switch(message($"Save changes to {MainUI.Text}","Textpadc"))
            {
                case DialogResult.Yes:
                    SaveFile(); TextBox.Clear(); MainUI.Close();
                    return DialogResult.Yes;

                case DialogResult.No:
                    TextBox.Clear(); MainUI.Close();
                    return DialogResult.No;

                case DialogResult.Cancel:
                    return DialogResult.Cancel;

                default:
                    return DialogResult.Cancel;
            }
        }

        //Clear the text area if text is found and save it if requested
        public void CreateNewFile(SendMessage message)
        {
            if (TextBox.Text.Length != 0 && TextBox.Text != "")
            {
                //Send this delegate to a message box to return a dialog result
                switch (message($"Save changes to {MainUI.Text}", "Textpadc"))
                {
                    case DialogResult.Yes:
                        SaveFile(); TextBox.Clear();
                        MainUI.Text = "-Unnamed";
                        break;

                    case DialogResult.No:
                        TextBox.Clear();
                        MainUI.Text = "-Unnamed";
                        break;
                }
            }
        }

        //Save the current file, clear the text area and open a new file if requested
        public void OpenFile(SendMessage message)
        {
            if (TextBox.Text.Length != 0 && TextBox.Text != "")
            {
                //Send this delegate to a message box to return a dialog result
                switch (message($"Save changes to {MainUI.Text}", "Textpadc"))
                {
                    case DialogResult.Yes:
                        SaveFile(); TextBox.Clear(); Open();
                        break;

                    case DialogResult.No:
                        TextBox.Clear(); Open();
                        break;
                }
            }
            else
                Open();
        }
        
        public void InsertImage()
        {
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.Filter = "PNG Images|*.png|JPEG Images|*.jpg";
            openImage.Title = "Browse Images";

            if (openImage.ShowDialog() == DialogResult.OK)
            {
                openImage.FileName = openImage.FileName;
                Clipboard.SetImage(Image.FromFile(openImage.FileName));
                TextBox.Paste();
            }
        }
    }
}
