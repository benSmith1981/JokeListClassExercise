using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jokslist
{
    public partial class Form1 : Form
    {
        Joke[] jokes = { };

        int jokeIndex = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jokeText.Text = jokes[0].joke;
            ratingTextBox.Text = jokes[0].rating;
        }
        private void previous_Click(object sender, EventArgs e)
        {
            if (jokeIndex <= 0)
            {
                jokeIndex = jokes.Length - 1;
            }
            else
            {
                jokeIndex -= 1;
            }
            jokeText.Text = jokes[jokeIndex].joke;
            ratingTextBox.Text = jokes[0].rating;
        }

    }
}
