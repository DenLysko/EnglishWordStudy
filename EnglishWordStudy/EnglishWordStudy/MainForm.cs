namespace EnglishWordStudy
{
    public partial class EnglishWordStudy : Form
    {
        internal WordDictionary wordDictionary;
        static string? anotherEnglishWord;
        static Random randomForDictionary;
        static Random randomForTranslations;

        public EnglishWordStudy()
        {
            InitializeComponent();
            wordDictionary = new WordDictionary();
            wordDictionary.ReadMainDictionary();
            randomForDictionary = new Random(42);
            randomForTranslations = new Random(24);
            CheckCurrentWord();
        }

        private void CheckCurrentWord()
        {
            WriteAnotherWord();
        }

        public void WriteAnotherWord()
        {
            int newIntForDictionary = randomForDictionary.Next((wordDictionary.Elements.Count));
            var russianTranslations = wordDictionary.Elements[newIntForDictionary].GetRussianTranslations();
            anotherEnglishWord = wordDictionary.Elements[newIntForDictionary].GetEnglishElement();
            int newIntForTranslations = randomForDictionary.Next((wordDictionary.Elements[newIntForDictionary].GetRussianTranslations().Count));
            labelForEnglishWord.Text = russianTranslations[newIntForTranslations];
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
            TextBoxForAnswer.Text = string.Empty;
            WriteAnotherWord();
        }

        private void SaveProgress_Click(object sender, EventArgs e)
        {
            // To Do: change MainDictionary.txt
        }

        private void CreateNextWord()
        {

        }
    }
}