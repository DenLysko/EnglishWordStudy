namespace EnglishWordStudy
{
    partial class EnglishWordStudy
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TextBoxForAnswer = new RichTextBox();
            asdfToolStripMenuItem = new ToolStripMenuItem();
            selectDictionaryToolStripMenuItem = new ToolStripMenuItem();
            editCurrentDictionaryToolStripMenuItem = new ToolStripMenuItem();
            takeToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            addVocabularyToolStripMenuItem = new ToolStripMenuItem();
            CheckButton = new Button();
            panel2 = new Panel();
            label1 = new Label();
            labelForEnglishWord = new Label();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxForAnswer
            // 
            TextBoxForAnswer.Cursor = Cursors.IBeam;
            TextBoxForAnswer.Location = new Point(5, 206);
            TextBoxForAnswer.Margin = new Padding(2);
            TextBoxForAnswer.Name = "TextBoxForAnswer";
            TextBoxForAnswer.Size = new Size(554, 202);
            TextBoxForAnswer.TabIndex = 11;
            TextBoxForAnswer.Text = "Type your answer";
            TextBoxForAnswer.KeyUp += TextBoxForAnswer_KeyUp;
            // 
            // asdfToolStripMenuItem
            // 
            asdfToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { selectDictionaryToolStripMenuItem });
            asdfToolStripMenuItem.Name = "asdfToolStripMenuItem";
            asdfToolStripMenuItem.Size = new Size(50, 20);
            asdfToolStripMenuItem.Text = "Menu";
            // 
            // selectDictionaryToolStripMenuItem
            // 
            selectDictionaryToolStripMenuItem.Name = "selectDictionaryToolStripMenuItem";
            selectDictionaryToolStripMenuItem.Size = new Size(162, 22);
            selectDictionaryToolStripMenuItem.Text = "Select Dictionary";
            // 
            // editCurrentDictionaryToolStripMenuItem
            // 
            editCurrentDictionaryToolStripMenuItem.Name = "editCurrentDictionaryToolStripMenuItem";
            editCurrentDictionaryToolStripMenuItem.Size = new Size(139, 20);
            editCurrentDictionaryToolStripMenuItem.Text = "Edit Current Dictionary";
            // 
            // takeToolStripMenuItem
            // 
            takeToolStripMenuItem.Name = "takeToolStripMenuItem";
            takeToolStripMenuItem.Size = new Size(63, 20);
            takeToolStripMenuItem.Text = "Get Hint";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { asdfToolStripMenuItem, editCurrentDictionaryToolStripMenuItem, takeToolStripMenuItem, addVocabularyToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 2, 0, 2);
            menuStrip1.Size = new Size(565, 24);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // addVocabularyToolStripMenuItem
            // 
            addVocabularyToolStripMenuItem.Name = "addVocabularyToolStripMenuItem";
            addVocabularyToolStripMenuItem.Size = new Size(102, 20);
            addVocabularyToolStripMenuItem.Text = "Add Vocabulary";
            addVocabularyToolStripMenuItem.Click += addVocabularyToolStripMenuItem_Click;
            // 
            // CheckButton
            // 
            CheckButton.Location = new Point(442, 412);
            CheckButton.Margin = new Padding(2);
            CheckButton.Name = "CheckButton";
            CheckButton.Size = new Size(112, 20);
            CheckButton.TabIndex = 12;
            CheckButton.Text = "Check";
            CheckButton.UseVisualStyleBackColor = true;
            CheckButton.Click += CheckButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(labelForEnglishWord);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 24);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(565, 182);
            panel2.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 1;
            label1.Text = "AddingVocabulary";
            label1.Visible = false;
            // 
            // labelForEnglishWord
            // 
            labelForEnglishWord.AutoSize = true;
            labelForEnglishWord.Location = new Point(247, 66);
            labelForEnglishWord.Margin = new Padding(2, 0, 2, 0);
            labelForEnglishWord.Name = "labelForEnglishWord";
            labelForEnglishWord.Size = new Size(53, 15);
            labelForEnglishWord.TabIndex = 0;
            labelForEnglishWord.Text = "Behavior";
            labelForEnglishWord.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // EnglishWordStudy
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 554);
            Controls.Add(panel2);
            Controls.Add(CheckButton);
            Controls.Add(TextBoxForAnswer);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "EnglishWordStudy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox TextBoxForAnswer;
        private ToolStripMenuItem asdfToolStripMenuItem;
        private ToolStripMenuItem selectDictionaryToolStripMenuItem;
        private ToolStripMenuItem editCurrentDictionaryToolStripMenuItem;
        private ToolStripMenuItem takeToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Button CheckButton;
        private Panel PanelWithEnglishWord;
        private Panel panel2;
        private Label labelForEnglishWord;
        private ToolStripMenuItem addVocabularyToolStripMenuItem;
        private Label label1;
        private OpenFileDialog openFileDialog1;
    }
}