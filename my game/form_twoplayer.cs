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
    public partial class form_twoplayer : Form

    {
        public enum player { x,o }
         player currentPlayer;
        Random ran = new Random();
        int playercount = 0;
        int cpucount = 0;
        List<Button> buttons;
        public form_twoplayer()
        {
            InitializeComponent();
            PlayAgain();
        }

        private void playercheck(object sender, EventArgs e)
        
        {
            var button = (Button)sender;
            currentPlayer = player.x;
            button.Text = currentPlayer.ToString();
            button.BackColor = Color.Black;
            buttons.Remove(button);
            CheckIn();
            cputimer.Start();
        }

        private void PlayAgain(object sender, EventArgs e)
        {
            PlayAgain();
        }

        private void CheckIn() 
        {if(btn1.Text=="x"&&btn2.Text=="x"&&btn3.Text=="x"||
        btn4.Text=="x"&&btn5.Text=="x"&&btn6.Text=="x"||
        btn7.Text=="x"&&btn8.Text=="x"&&btn9.Text=="x"||
        btn1.Text=="x"&&btn4.Text=="x"&&btn7.Text=="x"||
        btn2.Text=="x"&&btn5.Text=="x"&&btn8.Text=="x"||
        btn3.Text=="x"&&btn6.Text=="x"&&btn9.Text=="x"||
        btn1.Text=="x"&&btn5.Text=="x"&&btn9.Text=="x"||
        btn3.Text=="x"&&btn5.Text=="x"&&btn7.Text=="x")
        {
        cputimer.Stop();
        MessageBox.Show("the player is the winner", "$");
        playercount++;
        lbl1.Text = playercount.ToString();
        PlayAgain();
        }
        else if(btn1.Text=="o"&&btn2.Text=="o"&&btn3.Text=="o"||
        btn4.Text=="o"&&btn5.Text=="o"&&btn6.Text=="o"||
        btn7.Text=="o"&&btn8.Text=="o"&&btn9.Text=="o"||
        btn1.Text=="o"&&btn4.Text=="o"&&btn7.Text=="o"||
        btn2.Text=="o"&&btn5.Text=="o"&&btn8.Text=="o"||
        btn3.Text=="o"&&btn6.Text=="o"&&btn9.Text=="o"||
        btn1.Text=="o"&&btn5.Text=="o"&&btn9.Text=="o"||
        btn3.Text=="o"&&btn5.Text=="o"&&btn7.Text=="o")
        {
            cputimer.Stop();
            MessageBox.Show("the computer is the winner", "THE WINNER");
            cpucount++;
            lbl2.Text = playercount.ToString();
            PlayAgain();
        }

    }
        
        private void PlayAgain()
        { 
            buttons = new List<Button> { btn1,btn2,btn3,btn4,btn5,btn6,btn7,btn8,btn9};
        foreach (Button r in buttons) { r.Enabled = true; r.Text = ""; r.BackColor = Color.Transparent; }
        
        }

        private void cputimer_Tick(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = ran.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = player.o;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor= Color.White;
                buttons.RemoveAt(index);
                CheckIn();
                cputimer.Stop();
            
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("the result now is [  0  _  0  ]");
            cpucount = 0;
            lbl2.Text=cpucount.ToString();
            playercount = 0;
            lbl1.Text=playercount.ToString();
            PlayAgain();
        }
    }
}
