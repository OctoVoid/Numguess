namespace Numguess
{
    public partial class Form1 : Form
    {
        int myNum = 0; // input number
        int guessNum;
        int round = 0;
        bool gameOn;
        Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            StartNewGame();
        }

        public void StartNewGame()
        {
            gameOn = true;
            guessNum = rnd.Next(1, 10);
            myNum = 0;
            round = 0;

            correctPic.Left = -300;
            correctPic.Top = -300;

            wrongPic.Left = -300;
            wrongPic.Top = -300;

            newnumPic.Left = -300;
            newnumPic.Top = -300;
        }

        public void Evaluation(int myNum)  //checking guess
        {
            if (!gameOn) return;  // stops the execution if guessNum == myNum

            if (guessNum == myNum)
            {
                gameOn = false;
                correctPic.Left = 160;
                correctPic.Top = 179;

                wrongPic.Left = -300;
                wrongPic.Top = -300;

                newnumPic.Left = 253;
                newnumPic.Top = 501;
            }
            else
            {
                round++;
                wrongPic.Left = 187;
                wrongPic.Top = 171;

                if (round == 5)
                {
                    newnumPic.Left = 253;
                    newnumPic.Top = 501;
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)  // number 1
        {
            myNum = 1;
            Evaluation(myNum);
        }

        private void pictureBox2_Click(object sender, EventArgs e)  // number 2
        {
            myNum = 2;
            Evaluation(myNum);
        }

        private void pictureBox3_Click(object sender, EventArgs e)  // number 3
        {
            myNum = 3;
            Evaluation(myNum);
        }

        private void pictureBox4_Click(object sender, EventArgs e)  // number 4
        {
            myNum = 4;
            Evaluation(myNum);
        }

        private void pictureBox5_Click(object sender, EventArgs e)  // number 5
        {
            myNum = 5;
            Evaluation(myNum);
        }

        private void pictureBox6_Click(object sender, EventArgs e)  // number 6
        {
            myNum = 6;
            Evaluation(myNum);
        }

        private void pictureBox7_Click(object sender, EventArgs e)  // number 7
        {
            myNum = 7;
            Evaluation(myNum);
        }

        private void pictureBox8_Click(object sender, EventArgs e)  // number 8
        {
            myNum = 8;
            Evaluation(myNum);
        }

        private void pictureBox9_Click(object sender, EventArgs e)  // number 9
        {
            myNum = 9;
            Evaluation(myNum);
        }

        private void newnumPic_Click(object sender, EventArgs e)  //new number, please
        {
            StartNewGame();
        }
    }
}