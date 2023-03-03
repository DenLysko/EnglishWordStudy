namespace EnglishWordStudy
{
    public partial class EnglishWordStudy : Form
    {
        internal WordDictionary wordDictionary;
        static string? anotherEnglishWord;

        public EnglishWordStudy()
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
            var myRandom = new Random();
            var russianTranslations = wordDictionary.Elements[0].GetRussianTranslations();
            anotherEnglishWord = wordDictionary.Elements[0].GetEnglishElement();
            labelForEnglishWord.Text = russianTranslations[1];
        }


        private void TextBoxForAnswer_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TextBoxForAnswer.Text = TextBoxForAnswer.Text.Substring(0, TextBoxForAnswer.Text.Length - 1).TrimEnd(' ');
                CheckEnteredWord();
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
            DrawResult(TextBoxForAnswer.Text.ToLower() == anotherEnglishWord?.ToLower());
        }

        private void DrawResult(bool resultThatNeedToDraw)
        {
            var result = new Result(resultThatNeedToDraw);
            result.ShowDialog(this);
        }

        private void SaveProgress_Click(object sender, EventArgs e)
        {
            // To Do: change MainDictionary.txt
        }

    }
}