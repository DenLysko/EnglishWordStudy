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
        static bool _resultFromMainForm;
        public Result(bool resultFromMainForm)
        {
            //if (resultFromMainForm == null)
            //    _resultFromMainForm = false;
            //else
            _resultFromMainForm = resultFromMainForm;
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            if (_resultFromMainForm)
                pictureBox1.Image = Properties.Resources._123;
            else
                pictureBox1.Image = Properties.Resources._3211;
        }

    }
}
