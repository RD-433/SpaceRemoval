using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpaceRemoval.Properties;

namespace SpaceRemoval
{
    public partial class Form1 : Form
    {

        List<string> LegalChars = new List<string>()
        {
            "ა", "ბ", "გ", "დ", "ე", "ვ", "ზ",
            "თ", "ი", "კ", "ლ", "მ", "ნ", "ო",
            "პ", "ჟ", "რ", "ს", "ტ", "უ", "ფ",
            "ქ", "ღ", "ყ", "შ", "ჩ", "ც", "ძ",
            "წ", "ჭ", "ხ", "ჯ", "ჰ",

            "A", "B", "C", "D", "E", "F", "G",
            "H", "I", "J", "K", "L", "M", "N",
            "O", "P", "Q", "R", "S", "T", "U",
            "V", "W", "X", "Y", "Z",

            "a", "b", "c", "d", "e", "f", "g",
            "h", "i", "j", "k", "l", "m", "n",
            "o", "p", "q", "r", "s", "t", "u",
            "v", "w", "x", "y", "z",

            "А", "Б", "В", "Г", "Д", "Е", "Ё",
            "Ж", "З", "И", "Й", "К", "Л", "М",
            "Н", "О", "П", "Р", "С", "Т", "У",
            "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ",
            "Ы", "Ь", "Э", "Ю", "Я",

            "а", "б", "в", "г", "д", "е", "ё",
            "ж", "з", "и", "й", "к", "л", "м",
            "н", "о", "п", "р", "с", "т", "у",
            "ф", "х", "ц", "ч", "ш", "щ", "ъ",
            "ы", "ь", "э", "ю", "я",

            "0", "1", "2", "3", "4", "5", "6",
            "7", "8", "9",

            "\r", "\n","\t",

            " ", "!", "\"", "#", "$", "%", "&", "\'", "(",
            ")", "*", "+", ",", "-",".", "/",

            ":", ";", "<", "=", ">", "?", "@",

            "[", "\\", "]", "^", "_", "`",

            "{", "|", "}", "~",

            "’", ",", "“", "„", "”"

        };



        public Form1()
        {
            InitializeComponent();

            buttonCopy.Text = "Copy as Unicode";
            buttonPaste.Text = "Paste as Unicode";

            //this.Icon = Resources.tsu_logo;
            this.Icon = Resources.autorun;
            this.Text = "Space Removal v1.0.3";


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form1_SizeChanged(sender, e);
            checkBoxContPar_CheckedChanged(sender, e);
            checkBoxDot.Checked = true;
            checkBoxSemicolon.Checked = true;
        }

        private void Convert()
        {
            StringBuilder sb = new StringBuilder();

            string endString = "";
            int badCharCount = 0;

            //string[] splitted = richTextBoxIn.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] splitted = richTextBoxIn.Text.Split(new char[] { ' ' }, StringSplitOptions.None);

            foreach (string s in splitted)
            {
                //sb.Append(s.Trim());
                bool badChar = false;
                if (checkBoxRemoveIllegal.Checked)
                {
                    foreach (char s1 in s)
                    {
                        if (!LegalChars.Contains(s1.ToString()))
                        {
                            badChar = true;
                            break;
                        }
                    }
                }

                if (badChar)
                {
                    // rebuild string s = replace illegal chars with ""
                    StringBuilder sb1 = new StringBuilder();
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (LegalChars.Contains(s[i].ToString()))
                        {
                            sb1.Append(s[i]);
                        }
                        else
                        {
                            // ""
                            badCharCount++;
                        }
                    }
                    sb1.Append(' ');
                    sb.Append(sb1.ToString());

                }
                else
                {
                    sb.Append(s);
                    sb.Append(' ');
                }

                if (sb.Length > 60000)
                {
                    endString += sb.ToString();
                    sb.Clear();
                }
            }
            endString += sb.ToString();
            //richTextBoxOut.Text = sb.ToString();


            int continuedPar = 0;

            if (checkBoxContPar.Checked)
            {
                splitted = endString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                sb.Clear();
                endString = "";

                List<char> endChars = new List<char>();

                if (checkBoxDot.Checked)
                    endChars.Add('.');

                if (checkBoxComma.Checked)
                    endChars.Add(',');

                if (checkBoxColon.Checked)
                    endChars.Add(':');

                if (checkBoxSemicolon.Checked)
                    endChars.Add(';');

                if (endChars.Count < 1)
                {
                    MessageBox.Show("Selecte at least 1 (one) char!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //bool skipNext = false;

                //foreach (string s in splitted)
                for (int i = 0; i < splitted.Length; i++)
                {

                    if (splitted[i].EndsWith("\n") || splitted[i].EndsWith("\r"))
                    {
                        if (splitted[i].Equals("\n") || splitted[i].Equals("\r"))
                        {
                            sb.Append(splitted[i]);
                            sb.Append(' ');
                            continue;
                        }


                        if (endChars.Contains(splitted[i][splitted[i].Length - 2]))
                        {
                            // end of sentence, new paragraph allowed
                            sb.Append(splitted[i]);
                            sb.Append(' ');
                        }
                        else
                        {
                            // end of paragraph, but no end of sentence ! Remove next CRLF !
                            //if (splitted[i + 1].Equals("\n") || splitted[i + 1].Equals("\r"))
                            //{
                            //    //skipNext = true;
                            //}
                            sb.Append(splitted[i].Substring(0, splitted[i].Length - 1));
                            sb.Append(' ');
                            continuedPar++;
                        }
                    }
                    //else if (splitted[i].EndsWith("\r\n"))
                    //{
                    //    if (splitted[i].Equals("\r\n"))
                    //    {
                    //        sb.Append(splitted[i]);
                    //        sb.Append(' ');
                    //        continue;
                    //    }

                    //    if (endChars.Contains(splitted[i][splitted[i].Length - 3]))
                    //    {
                    //        sb.Append(splitted[i]);
                    //        sb.Append(' ');
                    //    }
                    //    else
                    //    {
                    //        //if (splitted[i + 1].Equals("\r\n"))
                    //        //{
                    //        //    //skipNext = true;
                    //        //}
                    //        sb.Append(splitted[i].Substring(0, splitted[i].Length - 2));
                    //        sb.Append(' ');
                    //        continuedPar++;
                    //    }
                    //}
                    else
                    {
                        if (i == 30)
                        {
                            i = i;
                        }
                        if (splitted[i].Contains("\n"))
                        {
                            var splitted2 = splitted[i].Split('\n');

                            //foreach (var s in splitted2)
                            //{
                            //    if (s.Length <= 1)
                            //    {
                            //        sb.Append('\n');
                            //        continue;
                            //    }
                            //    if (endChars.Contains(s[s.Length - 1]))
                            //    {
                            //        sb.Append(s);
                            //        sb.Append('\n');
                            //    }
                            //    else
                            //    {
                            //        sb.Append(s);
                            //        sb.Append(' ');
                            //        continuedPar++;
                            //    }
                            //}

                            //foreach (var s in splitted2)
                            for (int j = 0; j < splitted2.Length - 1; j++)
                            {
                                if (splitted2[j].Length <= 1)
                                {
                                    sb.Append('\n');
                                    continue;
                                }
                                if (endChars.Contains(splitted2[j][splitted2[j].Length - 1]))
                                {
                                    sb.Append(splitted2[j]);
                                    sb.Append('\n');
                                }
                                else
                                {
                                    sb.Append(splitted2[j]);
                                    sb.Append(' ');
                                    continuedPar++;
                                }
                            }
                            sb.Append(splitted2[splitted2.Length - 1]);
                            sb.Append(' ');
                        }
                        //else if (splitted[i].Contains("\r"))
                        //{
                        //    var splitted2 = splitted[i].Split('\r');

                        //    foreach (var s in splitted2)
                        //    {
                        //        if (s.Length <= 1)
                        //        {
                        //            sb.Append('\r');
                        //            continue;
                        //        }
                        //        if (endChars.Contains(s[s.Length - 1]))
                        //        {
                        //            sb.Append(s);
                        //            sb.Append('\r');
                        //        }
                        //        else
                        //        {
                        //            sb.Append(s);
                        //            sb.Append(' ');
                        //            continuedPar++;
                        //        }
                        //    }
                        //}
                        //else if (splitted[i].Contains("\r\n"))
                        //{
                        //    var splitted2 = splitted[i].Split(new char[] { '\r', '\n' });

                        //    foreach (var s in splitted2)
                        //    {
                        //        if (s.Length <= 1)
                        //        {
                        //            sb.Append("\r\n");
                        //            continue;
                        //        }
                        //        if (endChars.Contains(s[s.Length - 1]))
                        //        {
                        //            sb.Append(s);
                        //            sb.Append("\r\n");
                        //        }
                        //        else
                        //        {
                        //            sb.Append(s);
                        //            sb.Append(' ');
                        //            continuedPar++;
                        //        }
                        //    }
                        //}
                        else
                        {
                            sb.Append(splitted[i]);
                            sb.Append(' ');
                        }
                    }

                    if (sb.Length > 60000)
                    {
                        endString += sb.ToString();
                        sb.Clear();
                    }

                }

                endString += sb.ToString();
            }


            richTextBoxOut.Text = endString;

            if (badCharCount > 0 || continuedPar > 0)
            {
                if (badCharCount > 0 && continuedPar == 0)
                {
                    MessageBox.Show($"{badCharCount} bad chars was removed!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (badCharCount == 0 && continuedPar > 0)
                {
                    MessageBox.Show($"{continuedPar} paragraphs continued!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"{badCharCount} bad chars was removed!\n{continuedPar} paragraphs continued!", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void buttonPaste_Click(object sender, EventArgs e)
        {
            richTextBoxIn.Text = Clipboard.GetText(TextDataFormat.UnicodeText);
        }

        private void buttonPCC_Click(object sender, EventArgs e)
        {
            richTextBoxIn.Text = Clipboard.GetText(TextDataFormat.UnicodeText);
            Convert();
            Clipboard.SetText(richTextBoxOut.Text, TextDataFormat.UnicodeText);
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richTextBoxOut.Text))
            {
                Clipboard.SetText(richTextBoxOut.Text, TextDataFormat.UnicodeText);
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            Convert();
        }

        private async void Form1_SizeChanged(object sender, EventArgs e)
        {

            int tbxWidth = (this.Width - 80) / 2;
            int tbxHeight = this.Height - 200;

            buttonConvert.Location = new Point(this.Width / 2 - buttonConvert.Width / 2, 20);
            buttonCopy.Location = new Point(this.Width / 2 - buttonCopy.Width / 2 + 100, 20);
            buttonPaste.Location = new Point(this.Width / 2 - buttonPaste.Width / 2 - 100, 20);

            buttonPCC.Location = new Point(this.Width - buttonPaste.Width - buttonPaste.Width / 2, 20);

            richTextBoxIn.Location = new Point(20, 150);
            richTextBoxIn.Size = new Size(tbxWidth, tbxHeight);
            richTextBoxOut.Location = new Point(20 + tbxWidth + 20, 150);
            richTextBoxOut.Size = new Size(tbxWidth, tbxHeight);

            await Task.Delay(10);
        }

        private void checkBoxContPar_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxDot.Enabled = checkBoxComma.Enabled = checkBoxColon.Enabled = checkBoxSemicolon.Enabled = checkBoxContPar.Checked;
        }
    }
}
