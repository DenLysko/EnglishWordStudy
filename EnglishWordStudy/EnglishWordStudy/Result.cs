using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishWordStudy
{
    public partial class Result : Form
    {
        private bool _resultFromMainForm;
        public Result(bool resultFromMainForm)
        {
            _resultFromMainForm = resultFromMainForm;
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            if (_resultFromMainForm)
                pictureBox1.Image = Properties.Resources.Good_DinNorris;
            else
                pictureBox1.Image = Properties.Resources.Bas_DinNorris;
        }

        private void Result_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.Close();
        }
    }
}
