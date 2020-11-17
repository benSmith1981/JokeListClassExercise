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
        Joke[] jokes = { new Joke("I used to memorise the \n alphabet but now \n I don't know Y!", 0),
                            new Joke("What does Stephen Hawking say  \nwhen his computer crashed? \nNothing!", 1),
                            new Joke("I ate a clock yesterday \n and it was time consuming!", 5),
                            new Joke("Today was a terrible day. \n My ex got hit with a bus, \n and I lost my job as a bus driver", 3),
                            new Joke("What is difference between \n stephen hawking and his computer? \n His computer can run.", 2),
                            new Joke("How did the penguin pass \n his driving test...he winged it!",4)
        };

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

        private void button2_Click(object sender, EventArgs e)
        {
            if (jokeIndex > jokes.Length)
            {
                jokeIndex = 0;
            }
            else
            {
                jokeIndex += 1;
            }
            jokeText.Text = jokes[jokeIndex].joke;
            ratingTextBox.Text = jokes[0].rating;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
