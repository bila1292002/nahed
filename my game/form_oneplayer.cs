using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_game
{
    public partial class form_oneplayer : Form
    {
     
        List<Button> buttons;
        int nerd=0;
        int player1count = 0;
        int player2count = 0;
        bool win = false;
        public form_oneplayer()
        {
            InitializeComponent();
            playagain();
            foreach (Control c in buttons) { if (c is Button) { c.Click += new System.EventHandler(btn_click); } }
        }
        void btn_click(object sender, EventArgs e)
        {
            Button butn = (Button)sender;
            if (butn.Text=="")
            {
                if (nerd % 2 == 0)
                {
                    butn.Text = "x";
                    butn.ForeColor = Color.White;
                    clilk();
                }
                else
                { 
                    butn.Text = "o";
                    butn.ForeColor = Color.Green;
                    clilk();
                }
                nerd++;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the result now is [0  _   0]","@");
            player1count = 0;
            lbl1.Text = player1count.ToString();
            player2count = 0;
            lbl2.Text = player2count.ToString();
            playagain();
            
        }

        private void clickwin(object sender, EventArgs e)
        {
            
        }

        private void playagain(object sender, EventArgs e)
        {
            playagain();
        }
        private void playagain() {
            buttons = new List<Button> { btn1,btn2,btn3,btn4,btn5,btn6,btn7,btn8,btn9};
            foreach (Button r in buttons) { r.Enabled = true; r.Text = ""; r.BackColor = Color.Transparent; }
        }
        private void clilk()
        {
            if (btn1.Text == "x" && btn2.Text == "x" && btn3.Text == "x" ||
                btn4.Text == "x" && btn5.Text == "x" && btn6.Text == "x" ||
                btn7.Text == "x" && btn8.Text == "x" && btn9.Text == "x" ||
                btn1.Text == "x" && btn4.Text == "x" && btn7.Text == "x" ||
                btn2.Text == "x" && btn5.Text == "x" && btn8.Text == "x" ||
                btn3.Text == "x" && btn6.Text == "x" && btn9.Text == "x" ||
                btn1.Text == "x" && btn5.Text == "x" && btn9.Text == "x" ||
                btn3.Text == "x" && btn5.Text == "x" && btn7.Text == "x")
            {
                win = true;
                lbl1.Text = player1count.ToString();
                MessageBox.Show("the winner is player 1","win");
               playagain();
               player1count++;
               lbl1.Text = player1count.ToString();
            }

            else if (btn1.Text == "o" && btn2.Text == "o" && btn3.Text == "o" ||
        btn4.Text == "o" && btn5.Text == "o" && btn6.Text == "o" ||
        btn7.Text == "o" && btn8.Text == "o" && btn9.Text == "o" ||
        btn1.Text == "o" && btn4.Text == "o" && btn7.Text == "o" ||
        btn2.Text == "o" && btn5.Text == "o" && btn8.Text == "o" ||
        btn3.Text == "o" && btn6.Text == "o" && btn9.Text == "o" ||
        btn1.Text == "o" && btn5.Text == "o" && btn9.Text == "o" ||
        btn3.Text == "o" && btn5.Text == "o" && btn7.Text == "o")
            {
                win = true;
                lbl2.Text = player2count.ToString();
                MessageBox.Show("the winner is player 2", "win");
                playagain();
                player2count++;
                lbl2.Text = player2count.ToString();
            }
        }

        private void timer(object sender, EventArgs e)
        {

        }

        private void move_oneplayer(object sender, EventArgs e)
        {

        }
    }
}
