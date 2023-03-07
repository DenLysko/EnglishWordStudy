namespace EnglishWordStudy
{
    public partial class MainForm : Form
    {
        internal WordDictionary wordDictionary;
        static string? anotherEnglishWord;

        public MainForm()
        {
            InitializeComponent();
            wordDictionary = new WordDictionary();
            wordDictionary.ReadMainDictionary();
            CheckAnotherWord();
        }

        private void CheckAnotherWord()
        {
            WriteAnotherWord();

        }

        public void WriteAnotherWord()
        {
            var russianWord = wordDictionary.dic["Dog"];
            anotherEnglishWord = "Dog";
            labelForEnglishWord.Text = russianWord;
        }


        private void PanelWithEnglishWord_DoubleClick(object sender, EventArgs e)
        {
            PanelWithEnglishWord.Visible = false;
        }



        private void EnglishWordStudy_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (TextBoxForAnswer.Text == "Поведение")
            //    {
            //        TextBoxForAnswer.Clear();
            //        TextBoxForAnswer.Text = "Красавчег";
            //    }
            //    else
            //    {
            //        TextBoxForAnswer.Clear();
            //        TextBoxForAnswer.Text = "Чел, ты...";
            //    }
            //}
        }

        private void TextBoxForAnswer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBoxForAnswer.Text = TextBoxForAnswer.Text.Substring(0, TextBoxForAnswer.Text.Length - 1);
                TextBoxForAnswer.Text = TextBoxForAnswer.Text.TrimEnd(' ');
                CheckEnteredWord();
                //if (TextBoxForAnswer.Text == "Поведение\n")
                //{
                //    TextBoxForAnswer.Clear();
                //    TextBoxForAnswer.Text = "Красавчег";
                //}
                //else
                //{
                //    TextBoxForAnswer.Clear();
                //    TextBoxForAnswer.Text = "Чел, ты...";
                //}
            }
        }

        private void addVocabularyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1_FileOk(sender, new System.ComponentModel.CancelEventArgs());
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Импорт из Excel",
                ShowHelp = false,
                ValidateNames = true
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var a = new StreamReader(openFileDialog.FileName);
                var b = a.ReadToEnd();
                string[] strings = b.Split(' ');
                wordDictionary.FillDictionary(strings);
            }
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            CheckEnteredWord();
        }

        private void CheckEnteredWord()
        {
            //anotherEnglishWord = anotherEnglishWord.Substring(0, anotherEnglishWord.Length - 2);
            DrawResult(TextBoxForAnswer.Text.ToLower() == anotherEnglishWord.ToLower());
        }

        private void DrawResult(bool resultThatNeedToDraw)
        {
            var result = new Result(resultThatNeedToDraw);
            result.ShowDialog(this);
        }
    }
}