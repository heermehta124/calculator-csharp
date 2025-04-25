using System;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private Boolean isPlayerXTurn = true;

        public Form1()
        {
            InitializeComponent();

            button1.Click += Button_Click;
            button2.Click += Button_Click;
            button3.Click += Button_Click;
            button4.Click += Button_Click;
            button5.Click += Button_Click;
            button6.Click += Button_Click;
            button7.Click += Button_Click;
            button8.Click += Button_Click;
            button9.Click += Button_Click;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isPlayerXTurn)
            {
                button.Text = "X";
            }
            else
            {
                button.Text = "O";
            }

            button.Enabled = false;
            CheckWinCondition();
            isPlayerXTurn = !isPlayerXTurn;
        }

        private void CheckWinCondition()
        {
            string[][] winningCombinations = new string[][]
            {
        new string[] { button1.Text, button2.Text, button3.Text },
        new string[] { button4.Text, button5.Text, button6.Text },
        new string[] { button7.Text, button8.Text, button9.Text },
        new string[] { button1.Text, button4.Text, button7.Text },
        new string[] { button2.Text, button5.Text, button8.Text },
        new string[] { button3.Text, button6.Text, button9.Text },
        new string[] { button1.Text, button5.Text, button9.Text },
        new string[] { button3.Text, button5.Text, button7.Text }
            };

            foreach (var combination in winningCombinations)
            {
                if (combination[0] != "" &&
                    combination[0] == combination[1] &&
                    combination[1] == combination[2])
                {
                    DeclareWinner(combination[0]);
                    return;
                }
            }
        }


        private void DeclareWinner(string player)
        {
            DialogResult result = MessageBox.Show(player + " Wins! Play again?", "Tic Tac Toe", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                ResetGame();
            }
            else
            {
                Application.Exit();
            }
        }

        private void ResetGame()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Text = "";
                    button.Enabled = true;
                }
            }
            isPlayerXTurn = true;
        }
    }
}
