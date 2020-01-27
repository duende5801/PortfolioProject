using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAbdallah_Project2
{
    //David Abdallah
    //09/27/2019
    //Project2
    //Make Deal or No Deal
    //Reviewed by: Carter galvez
    //comment:Case at end says -1 cases to pick other wise great job
    public partial class Game_Screen : Form
    {
        Button firstCase;
        public List<int> caseNums = new List<int>()
        {
            1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26
        };
        public List<string> dollarAmounts = new List<string>()
        {
            "$.01","$1","$5","$10","$25","$50","$75","$100","$200","$300",
            "$400","$500","$750","$1,000","$5,000","$10,000","$25,000",
            "$50,000","$75,000","$100,000","$200,000","$300,000",
            "$400,000","$500,000","$750,000","$1,000,000"
        };
        public List<string> banekerOffer = new List<string>()
        {
            "$.01","$1","$5","$10","$25","$50","$75","$100","$200","$300",
            "$400","$500","$750","$1000","$5000","$10000","$25000",
            "$50000","$75000","$100000","$200000","$300000",
            "$400000","$500000","$750000","$1000000"
        };
        Dictionary<string, string> cases = new Dictionary<string, string>();
        Dictionary<string, string> cases2 = new Dictionary<string, string>();
        int roundCounter = 0;
        int casesLeft = 0;
        string winningCase = "";
        public Game_Screen()
        {
            InitializeComponent();
            ShuffleCases();
        }
        public void SelectCase(object sender, EventArgs e)
        {
            //Happens with each case selected
            Button btn = sender as Button;
            string dollar = cases[btn.Text];
            btn.Enabled = false;
            //remove from dictionary
           
            Label[] LabelControls = this.Controls.OfType<Label>().ToArray();
            if (roundCounter == 0)
            {
                btn.Left = 200;
                btn.Top = 455;
                btn.Enabled = false;
                btn.BackColor = Color.Gold;
                btn.ForeColor = Color.Black;
                btn.Visible = true;
                firstCase = btn;
            }
            else
                cases.Remove(btn.Text);

            foreach (Label l in LabelControls)
            {
                if (roundCounter == 0)
                {
                    break;
                }
                else if (l.Text == dollar)
                {
                    l.BackColor = Color.DarkGray;
                }
            }
            roundCounter++;
            if (btn != firstCase && roundCounter < 25)
            {
                btn.Text = dollar;
            }
            if (roundCounter == 26)
            {
                winningCase = btn.Text;
            }
            RoundCondition();
        }

        public void ShuffleCases()
        {
            //This runs once
            //int randomCase;
            int randomDollar;
            Random r = new Random();
            for (int i = 0; i < 26; i++)
            {
                //randomCase = r.Next(0, caseNums.Count);
                randomDollar = r.Next(0, dollarAmounts.Count);
                cases.Add(Convert.ToString(caseNums[i]), dollarAmounts[randomDollar]);
                cases2.Add(Convert.ToString(caseNums[i]), dollarAmounts[randomDollar]);
                //caseNums.Remove(randomCase);
                dollarAmounts.Remove(dollarAmounts[randomDollar]);
            }
        }
        public void RoundCondition()
        {
            switch (roundCounter)
            {
                case 1://round 1
                    casesLeft = 6;
                    break;
                case 7://round 2
                    BanerOffer.Text = "$" + BankerOffer();
                    casesLeft = 5;
                    break;
                case 12://round 3
                    BanerOffer.Text = "$" + BankerOffer();
                    casesLeft = 4;
                    break;
                case 16://round 4
                    BanerOffer.Text = "$" + BankerOffer();
                    casesLeft = 3;
                    break;
                case 19://round 5
                    BanerOffer.Text = "$" + BankerOffer();
                    casesLeft = 2;
                    break;
                case 21://round 6
                    BanerOffer.Text = "$" + BankerOffer();
                    casesLeft = 2;
                    break;
                case 23://round 7
                    BanerOffer.Text = "$" + BankerOffer();
                    casesLeft = 1;
                    break;
                case 24://round 8
                    BanerOffer.Text = "$" + BankerOffer();
                    casesLeft = 1;
                    break;
                case 25://round 9
                    SwapCases();
                    break;
                case 26://Swap rounds
                    MessageBox.Show($"You won {cases2[winningCase]}");
                    GameOver();
                    break;
                default:
                    break;
            }
            Cases_Left_Lbl.Text = casesLeft.ToString();
            Cases_Left_Lbl.Update();
            casesLeft--;
        }

        public double BankerOffer()
        {
            foreach (Control c in Controls)
            {
                Button btn = c as Button;
                if (btn != null)
                {
                    btn.Enabled = false;
                }
            }
            Deal.Enabled = true;
            No_Deal.Enabled = true;
            Label[] labels = this.Controls.OfType<Label>().ToArray();
            List<string> lab = new List<string>();
            foreach (Label l in labels)
            {
                if (l.BackColor == Color.Gold)
                {
                    lab.Add(l.Text);
                }
            }
            for (int i = 0; i < lab.Count; i++)
            {
                lab[i] = lab[i].Replace("$", "");
            }
            double total = 0;
            foreach (string s in lab)
            {
                total += Convert.ToDouble(s);
            }
            total = total / lab.Count();
            return Math.Round(total);
        }


        private void Deal_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You have accepted the Banker's offer! You won {BanerOffer.Text}", "Congrats");
            GameOver();
        }

        private void No_Deal_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                Button btn = c as Button;
                if (btn != null && btn.Text != firstCase.Text)
                {
                    btn.Enabled = true;
                }
                if (btn != null && btn.Text.Contains("$"))
                {
                    btn.Enabled = false;
                }
            }
            Deal.Enabled = false;
            No_Deal.Enabled = false;
            Play_Again.Enabled = true;
        }
        public void SwapCases()
        {
            foreach (Control c in Controls)
            {
                Button btn = c as Button;
                if(btn != null)
                {
                    //check to see if it is in the dictionary
                    if(btn != firstCase && cases.ContainsKey(btn.Text))
                    {
                        btn.Left = 290;
                        btn.Top = 455;
                    }
                    if(btn == firstCase)
                    {
                        btn.Enabled = true;
                    }
                }
                //if (btn != null && btn.Text != firstCase.Text && btn.Text != Deal.Text && btn.Text != No_Deal.Text && btn.Text != Play_Again.Text)
                //{
                //    btn.Left = 290;
                //    btn.Top = 455;
                //}

                //if (btn != null)
                //{
                //    btn.Enabled = true;
                //}
            }
            Deal.Enabled = false;
            No_Deal.Enabled = false;
            Play_Again.Enabled = true;
        }
        public void GameOver()
        {
            foreach (Control c in Controls)
            {
                Button btn = c as Button;
                if (btn != null)
                {
                    btn.Enabled = false;
                }
                Play_Again.Enabled = true;
            }
        }

        private void Play_Again_Click(object sender, EventArgs e)
        {
            Form mainForm = new Title_Screen();
            this.Hide();
            mainForm.Show();
        }
    }
}