namespace EnglishWordStudy
{
    public partial class EnglishWordStudy : Form
    {
        internal WordDictionary wordDictionary;


        public EnglishWordStudy()
        {
            InitializeComponent();
            wordDictionary = new WordDictionary();
            wordDictionary.ReadMainDictionary();
        }


        private void ProposedTranslation_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //PanelWithEnglishWord.
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PanelWithEnglishWord_DoubleClick(object sender, EventArgs e)
        {
            PanelWithEnglishWord.Visible = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBoxForAnswer_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxForAnswer_KeyPress(object sender, KeyPressEventArgs e)
        {

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
                if (TextBoxForAnswer.Text == "Поведение\n")
                {
                    TextBoxForAnswer.Clear();
                    TextBoxForAnswer.Text = "Красавчег";
                }
                else
                {
                    TextBoxForAnswer.Clear();
                    TextBoxForAnswer.Text = "Чел, ты...";
                }
            }
        }

        private void TextBoxForAnswer_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}