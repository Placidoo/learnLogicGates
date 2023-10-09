using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicGates
{
    public partial class Form1 : Form
    {
        bool switchOne, switchTwo, switchOutput;
        string currentGate;
        int score = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnNOT.PerformClick();
        }

        void gatesUpdate()
        {
            Image switchOn = Properties.Resources.green_button;
            Image switchOff = Properties.Resources.red_button;

            if (switchOne) switch1.Image = switchOn;
            else if (!switchOne) switch1.Image = switchOff;

            if (switchTwo) switch2.Image = switchOn;
            else if (!switchTwo) switch2.Image = switchOff;

            if (switchOutput) switch3.Image = switchOn;
            else if (!switchOutput) switch3.Image = switchOff;
        }

        void determineGate()
        {
            if (currentGate == "NOT") switchOutput = (!switchOne);
            else if (currentGate == "AND") switchOutput = switchOne && switchTwo;
            else if (currentGate == "OR") switchOutput = switchOne || switchTwo;
            else if (currentGate == "NAND") switchOutput = !(switchOne && switchTwo);
            else if (currentGate == "NOR") switchOutput = !(switchOne || switchTwo);
            else if (currentGate == "XOR") switchOutput = !(switchOne == switchTwo);
            else if (currentGate == "XNOR") switchOutput = (switchOne == switchTwo);

            gatesUpdate();
        }

        private void test(object sender, EventArgs e)
        {
            pnlChoices.Visible = true;
            lblScore.Visible = true;
            lblScore.Text = $"Score: {score}";
            switchMystery.Visible = true;
            Random rng = new Random();
            int testNumber = rng.Next(0,6);
            switch (testNumber)
            {
                case 0:
                    btnGates(btnAND,e);
                    break;
                case 1:
                    btnGates(btnOR,e);
                    break;
                case 2:
                    btnGates(btnNAND,e);
                    break;
                case 3:
                    btnGates(btnNOR,e);
                    break;
                case 4:
                    btnGates(btnXOR,e);
                    break;
                case 5:
                    btnGates(btnXNOR,e);
                    break;
                default:
                    btnTest.PerformClick();
                    break;
            }
            int switch1Random = rng.Next(0,2);
            int switch2Random = rng.Next(0,2);
            if (switch1Random == 0) switchOne = false;
            else switchOne = true;
            if (switch2Random == 0) switchTwo = false;
            else switchTwo = true;
            pnlDescription.Visible = false;
            pblButtons.Visible = false;
            switch1.Location = new Point(139, 48);
            switch2.Location = new Point(140, 224);
            switch3.Location = new Point(451, 144);
            switchMystery.Location = switch3.Location;
            pbGate.Location = new Point(259, 120);
            a.Location = new Point(171, 94);
            b.Location = new Point(267, 96);
            c.Location = new Point(171, 270);
            d.Location = new Point(267, 208);
            f.Location = new Point(419, 190);
            switch1.Enabled = false; switch2.Enabled = false;
            determineGate();
        }

        private void btnAnswer(object sender, EventArgs e)
        {
            lblResult.Visible = true;
            switchMystery.Visible = false;
            if (sender == btnTrue)
            {
                if (switchOutput)
                {
                    lblResult.Text = "CORRECT";
                    lblResult.ForeColor = Color.Green;
                    score++;
                    lblScore.Text = $"Score: {score}";
                }
                else
                {
                    lblResult.Text = "INCORRECT";
                    lblResult.ForeColor = Color.Maroon;
                }
            }
            else if (sender == btnFalse)
            {
                if (switchOutput == false)
                {
                    lblResult.Text = "CORRECT";
                    lblResult.ForeColor = Color.Green;
                    score++;
                    lblScore.Text = $"Score: {score}";
                }
                else
                {
                    lblResult.Text = "INCORRECT";
                    lblResult.ForeColor = Color.Maroon;
                }
            }
            btnContinue.Visible = true;

            if (sender == btnContinue)
            {
                lblResult.Visible = false;
                switchMystery.Visible = true;
                btnContinue.Visible = false;
                test(btnTest, e);
            }
        }

        private void btnGates(object sender, EventArgs e)
        {
            
            switchOne = false;
            switchTwo = false;

            a.Visible = true;
            b.Visible = true;
            c.Visible = true;
            d.Visible = true;
            f.Visible = true;

            switch1.Location = new Point(16, 40);
            switch2.Location = new Point(17, 216);
            switch3.Location = new Point(328, 136);
            pbGate.Size = new Size(184, 144);
            pbGate.Location = new Point(136, 112);

            switch2.Visible = true;
            switch2.Enabled = true;

            if (sender == btnNOT)
            {
                a.Visible = false;
                b.Visible = false;
                c.Visible = false;
                d.Visible = false;
                f.Visible = false;

                switch2.Visible = false;
                switch2.Enabled = false;

                switch1.Location = new Point(8,144);
                switch3.Location = new Point(328,144);
                pbGate.SizeMode = PictureBoxSizeMode.Zoom;
                pbGate.Size = new Size(248, 136);
                pbGate.Location = new Point(104, 124);
                pbGate.Image = Properties.Resources.notGate;

                lblGate.Text = "NOT GATE";
                lblDescription.Text = "A NOT gate inverts a single bit input to a single bit of output.";
                pbTable.Image = Properties.Resources.tableNOT;
            }
            else if (sender == btnAND){
                pbGate.Image = Properties.Resources.andGate;
                lblGate.Text = "AND GATE";
                lblDescription.Text = @"An AND gate is a logic gate that gives a high output only if all its inputs are high,
otherwise it gives low output.A dot(.) is used to show the AND operation.";
                pbTable.Image = Properties.Resources.tableAND;
            }
            else if (sender == btnOR){
                pbGate.Image = Properties.Resources.orGate;
                lblGate.Text = "OR GATE";
                lblDescription.Text = @"An OR gate is a logic gate that gives high output if at least one of the inputs is high. A
plus(+) is used to show the OR operation.";
                pbTable.Image = Properties.Resources.tableOR;
            }
            else if (sender == btnNAND){
                pbGate.Image = Properties.Resources.nand;
                lblGate.Text = "NAND GATE";
                lblDescription.Text = @"A NAND gate is a logic gate that gives a low output only if all its inputs are high,
otherwise it gives high output.";
                pbTable.Image = Properties.Resources.tableNAND;
            }
            else if (sender == btnNOR){
                pbGate.Image = Properties.Resources.norGate;
                lblGate.Text = "NOR GATE";
                lblDescription.Text = @"An NOR gate is a logic gate that gives high output if both the inputs are low, otherwise
it gives low output.";
                pbTable.Image = Properties.Resources.tableNOR;
            }
            else if (sender == btnXOR){
                pbGate.Image = Properties.Resources.xorGate;
                lblGate.Text = "XOR GATE";
                lblDescription.Text = @"An XOR (Exclusive OR) gate is a logic gate that gives high output if the inputs are different, otherwise
it gives low output.";
                pbTable.Image = Properties.Resources.tableXOR;
            }
            else if (sender == btnXNOR){
                pbGate.Image = Properties.Resources.xnorGate;
                lblGate.Text = "XNOR GATE";
                lblDescription.Text = @"An EX-NOR (Exclusive NOR) gate is a logic gate that gives high output if the inputs are same, otherwise
it gives low output.";
                pbTable.Image = Properties.Resources.tableXNOR;
            }
            currentGate = (sender as Button).Text;

            determineGate();
        }


        private void btnSwitch(object sender, EventArgs e)
        {
            if (sender == switch1)
            {
                if (!switchOne) { switchOne = true; }
                else if (switchOne) { switchOne = false; }
            }
            else if (sender == switch2)
            {
                if (!switchTwo) { switchTwo = true; }
                else if (switchTwo) { switchTwo = false; }
            }

            determineGate();
        }

    }
}
