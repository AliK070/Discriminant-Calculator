using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Mathstuff
{
    public partial class Form1 : Form
    {
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "data.txt");


        public Form1()
        {
            InitializeComponent();
            pnlcog.Visible = false;
            pnlGraph.Visible = false;   

        }
        //form size 806, 372 // Form graph sieze 806, 569
        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath); 
                checkBox1.Checked = bool.Parse(lines[0]);
                checkBox2.Checked = bool.Parse(lines[1]);
                checkBox3.Checked = bool.Parse(lines[2]);
                checkBox4.Checked = bool.Parse(lines[3]);
            }
        }

        public void ToDiscrm()
        {
            //Recieve inputs from textboxes and parse into floats.
            float input_a = float.Parse(txtA.Text);
            float input_b = float.Parse(txtB.Text);
            float input_c = float.Parse(txtC.Text);

            lblShow.Text = " " + input_b + "²" + "-4(" + input_a + ")" + "(" + input_c + ")";  //368, 78

            //Calculate discriminant:
            float sumdiscrm = (input_b * input_b) - (4 * input_a * input_c);

            lblAns.Text = "Answer: " + sumdiscrm.ToString(); 

            //Check # of solutions. 
            if (sumdiscrm >= 0)
            {
                lblSol.Text = lblSolG.Text = "Two Solutions: b² - 4ac > 0";
                pbgraph.BackgroundImage = Properties.Resources.twodrscm;
           
            }
            if (sumdiscrm <= 0)
            {
                lblSol.Text = lblSolG.Text = "One Solution: b² - 4ac < 0";
                pbgraph.BackgroundImage = Properties.Resources.onedscrim;
            }
            if (sumdiscrm == 0)
            {
                lblSol.Text = lblSolG.Text = "No Solutions: b² - 4ac = 0";
                pbgraph.BackgroundImage = Properties.Resources.nodscrm;
            }

            lblAnsG.Text = "Answer: " + sumdiscrm.ToString();
         

        }
       
        private void btnCalc_Click(object sender, EventArgs e)
        {
            //check for count overflow, manually fix position if over.
            if(lblShow.Text.Count() >= 13)
            {
                lblShow.Location = new Point(300, 116);
            }

            if (txtA.Text.Count() == 0 || txtB.Text.Count() == 0 || txtC.Text.Count() == 0)
            {
                MessageBox.Show("Please enter your values.");
                return;
            }
          ToDiscrm();
        }

        private void btncog_Click(object sender, EventArgs e)
        {
            pnlcog.Visible = true;
            btncog.Visible = false;
            pnlInput.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            pnlcog.Visible = false;
            btncog.Visible = true;
            pnlInput.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked)
            {
               
                BackColor = Color.Black;
                ForeColor = Color.Silver;
                checkBox1.Text = "ON";
            }
            else
            {
                BackColor = Color.White;
                ForeColor = Color.Black;
                checkBox1.Text = "OFF";
            }
          
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                lblSol.Visible = false;
                checkBox2.Text = "OFF";
            }
            else
            {
                lblSol.Visible = true;
                checkBox2.Text = "ON";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                lblAns.Visible = false;
                checkBox3.Text = "OFF";
            }
            else
            {
                lblAns.Visible = true;
                checkBox3.Text = "ON";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
          
            if (checkBox4.Checked)
            {
                Size = new Size(773, 561);
                checkBox4.Text = "ON";
                pnlGraph.Visible = true;
                
            }
            else
            {
                Size = new Size(773, 357);
                checkBox4.Text = "OFF";
                pnlGraph.Visible = false;
            }

           
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            string[] lines = { checkBox1.Checked.ToString(), checkBox2.Checked.ToString(), checkBox3.Checked.ToString(), checkBox4.Checked.ToString() };
            File.WriteAllLines(filePath, lines);
        }



        /*
        var msg = MessageBox.Show("are you sure to close");
        if (msg == DialogResult.OK)
        {
            File

        }
        */
    }
    }


