using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScoreApp.scoreDB;

namespace ScoreApp
{
    public partial class AddForm : Form
    {
        public Score scoreData = null;
        public AddForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            scoreData = new Score()
            {
                Id = int.Parse(IDTextBox.Text),
                Name = NameTextBox.Text,
                Kor = int.Parse(KorTextBox.Text),
                Eng = int.Parse(EngTextBox.Text),
                Math = int.Parse(MathTextBox.Text)
            };

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            if(scoreData != null)
            {
                IDTextBox.Text = scoreData.Id.ToString();
                NameTextBox.Text = scoreData.Name;
                KorTextBox.Text = scoreData.Kor.ToString();
                EngTextBox.Text = scoreData.Eng.ToString();
                MathTextBox.Text = scoreData.Math.ToString();
            }
        }
    }
}
