namespace WindowsFormsApp4
{
    partial class Form1
    {
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // Initialize button positions and sizes
            this.button1.Location = new System.Drawing.Point(10, 10);
            this.button1.Size = new System.Drawing.Size(80, 80);
            this.button2.Location = new System.Drawing.Point(100, 10);
            this.button2.Size = new System.Drawing.Size(80, 80);
            this.button3.Location = new System.Drawing.Point(190, 10);
            this.button3.Size = new System.Drawing.Size(80, 80);
            this.button4.Location = new System.Drawing.Point(10, 100);
            this.button4.Size = new System.Drawing.Size(80, 80);
            this.button5.Location = new System.Drawing.Point(100, 100);
            this.button5.Size = new System.Drawing.Size(80, 80);
            this.button6.Location = new System.Drawing.Point(190, 100);
            this.button6.Size = new System.Drawing.Size(80, 80);
            this.button7.Location = new System.Drawing.Point(10, 190);
            this.button7.Size = new System.Drawing.Size(80, 80);
            this.button8.Location = new System.Drawing.Point(100, 190);
            this.button8.Size = new System.Drawing.Size(80, 80);
            this.button9.Location = new System.Drawing.Point(190, 190);
            this.button9.Size = new System.Drawing.Size(80, 80);

            // Add buttons to the form
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);

            // Form properties
            this.ClientSize = new System.Drawing.Size(284, 284);
            this.Name = "Form1";
            this.Text = "TicTacToe_064";
            this.ResumeLayout(false);
        }
    }
}
