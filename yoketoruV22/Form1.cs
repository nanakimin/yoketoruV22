using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yoketoruV22
{
    public partial class Form1 : Form
    {
        enum State
        {
            None = -1,
            Title,
            Geme,
            Gemeover,
            Clear
        }
        State currentState = State.None;
        State nextState = State.Title;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (nextState != State.None)
            {
                initProc ();
            }
        }

        void iniProc()
        {
            currentState = nextState;
            nextState = State.None;

                switch (currentState)
            {
                case State.Title;
                    titleLabel.Visible = true;
                    startButton.Visible = true;
                    copyrightLabel.Visible = true;
                    hiLabel.Visible = true;
                    gemeOverLabel.Visible = true;

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
