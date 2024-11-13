namespace JogoDaVelhaWinForm
{
    public partial class FrmMain : Form
    {
        public string JogadorAtual = "X";
        public int contadorX = 0, contadorO = 0, contadorempate = 0;
        public FrmMain()
        {
            InitializeComponent();
           
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        public string TrocaJogador()
        {
            if (JogadorAtual == "X")
            {
                
                return "O";

            }
            else
            {
               
                return "X";
            }
        }

        public void ZerarCasas()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";

            btn1.BackColor = Color.White;
            btn2.BackColor = Color.White;
            btn3.BackColor = Color.White;
            btn4.BackColor = Color.White;
            btn5.BackColor = Color.White;
            btn6.BackColor = Color.White;
            btn7.BackColor = Color.White;
            btn8.BackColor = Color.White;
            btn9.BackColor = Color.White;
        }
        public void ResetaTudo()
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            VitX.Text = "0";
            VitO.Text = "0";
            EmpateValor.Text = "0";
            txtQuemJoga.Text = "";
        }

        public void Ganhador()
        {

            MessageBox.Show("O jogador " + JogadorAtual + " ganhou!");
            ZerarCasas();

            txtQuemJoga.Text = "Vencedor: " + JogadorAtual;
            

        }

        public void Empate()
        {
            MessageBox.Show("Empate!");
            ZerarCasas();
            
     

        }





        public bool Verificar(string jogadroatual)
        {
            if(btn1.Text == JogadorAtual && btn2.Text == JogadorAtual && btn3.Text == JogadorAtual)
            {
                if (JogadorAtual == "X")
                {
                    contadorX++;
                    VitX.Text = contadorX.ToString();
                }
                else if (JogadorAtual == "O")
                {
                    contadorO++;
                    VitO.Text = contadorO.ToString();
                }
                btn1.BackColor = Color.Green;
                btn2.BackColor = Color.Green;
                btn3.BackColor = Color.Green;
                
                Ganhador();
                return true;
            }
            if (btn4.Text == JogadorAtual && btn5.Text == JogadorAtual && btn6.Text == JogadorAtual)
            {
                if (JogadorAtual == "X")
                {
                    contadorX++;
                    VitX.Text = contadorX.ToString();
                }
                else if (JogadorAtual == "O")
                {
                    contadorO++;
                    VitO.Text = contadorO.ToString();
                }
                btn4.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                
                Ganhador();
                return true;
            }
            if (btn7.Text == JogadorAtual && btn8.Text == JogadorAtual && btn9.Text == JogadorAtual)
            {
                if (JogadorAtual == "X")
                {
                    contadorX++;
                    VitX.Text = contadorX.ToString();
                }
                else if (JogadorAtual == "O")
                {
                    contadorO++;
                    VitO.Text = contadorO.ToString();
                }
                btn7.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                
                Ganhador();
                return true;
            }
            if (btn1.Text == JogadorAtual && btn4.Text == JogadorAtual && btn7.Text == JogadorAtual)
            {
                if (JogadorAtual == "X")
                {
                    contadorX++;
                    VitX.Text = contadorX.ToString();
                }
                else if (JogadorAtual == "O")
                {
                    contadorO++;
                    VitO.Text = contadorO.ToString();
                }
                btn1.BackColor = Color.Green;
                btn4.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
               

                Ganhador();
                return true;
            }
            if (btn2.Text == JogadorAtual && btn5.Text == JogadorAtual && btn8.Text == JogadorAtual)
            {
                if (JogadorAtual == "X")
                {
                    contadorX++;
                    VitX.Text = contadorX.ToString();
                }
                else if (JogadorAtual == "O")
                {
                    contadorO++;
                    VitO.Text = contadorO.ToString();
                }
                btn2.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn8.BackColor = Color.Green;
                

                Ganhador();
                return true;

            }
            if (btn3.Text == JogadorAtual && btn6.Text == JogadorAtual && btn9.Text == JogadorAtual)
            {
                if (JogadorAtual == "X")
                {
                    contadorX++;
                    VitX.Text = contadorX.ToString();
                }
                else if (JogadorAtual == "O")
                {
                    contadorO++;
                    VitO.Text = contadorO.ToString();
                }
                btn3.BackColor = Color.Green;
                btn6.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
               

                Ganhador();
                return true;

            }
            if (btn1.Text == JogadorAtual && btn5.Text == JogadorAtual && btn9.Text == JogadorAtual)
            {
                if (JogadorAtual == "X")
                {
                    contadorX++;
                    VitX.Text = contadorX.ToString();
                }
                else if (JogadorAtual == "O")
                {
                    contadorO++;
                    VitO.Text = contadorO.ToString();
                }
                btn1.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn9.BackColor = Color.Green;
                

                Ganhador();
                return true;

            }
            if (btn3.Text == JogadorAtual && btn5.Text == JogadorAtual && btn7.Text == JogadorAtual)
            {
                if (JogadorAtual == "X")
                {
                    contadorX++;
                    VitX.Text = contadorX.ToString();
                }
                else if (JogadorAtual == "O")
                {
                    contadorO++;
                    VitO.Text = contadorO.ToString();
                }
                btn3.BackColor = Color.Green;
                btn5.BackColor = Color.Green;
                btn7.BackColor = Color.Green;
                
                Ganhador();
                return true;

            }
            if(btn1.Text != "" && btn2.Text != "" && btn3.Text != "" && btn4.Text != "" && btn5.Text != "" && btn6.Text != "" && btn7.Text != "" && btn8.Text != "" && btn9.Text != "")
            {
                contadorempate++;
                EmpateValor.Text = contadorempate.ToString();
                btn1.BackColor = Color.Yellow;
                btn2.BackColor = Color.Yellow;
                btn3.BackColor = Color.Yellow;
                btn4.BackColor = Color.Yellow;
                btn5.BackColor = Color.Yellow;
                btn6.BackColor = Color.Yellow;
                btn7.BackColor = Color.Yellow;
                btn8.BackColor = Color.Yellow;
                btn9.BackColor = Color.Yellow;
                Empate();
                return true;
            }

            JogadorAtual = TrocaJogador();
            txtQuemJoga.Text = "Vez do jogador: " + JogadorAtual;
            
            return true;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            ResetaTudo();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "")
            {
                btn1.Text = JogadorAtual;
                Verificar(JogadorAtual);
                
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "")
            {
                btn2.Text = JogadorAtual;
                Verificar(JogadorAtual);
                
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "")
            {
                btn3.Text = JogadorAtual;
                Verificar(JogadorAtual);
               
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == "")
            {
                btn4.Text = JogadorAtual;
                Verificar(JogadorAtual);
                
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text == "")
            {
                btn5.Text = JogadorAtual;
                Verificar(JogadorAtual);
                
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "")
            {
                btn6.Text = JogadorAtual;
                Verificar(JogadorAtual);
                
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn7.Text == "")
            {
                btn7.Text = JogadorAtual;
                Verificar(JogadorAtual);
                
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text == "")
            {
                btn8.Text = JogadorAtual;
                Verificar(JogadorAtual);
                
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn9.Text == "")
            {
                btn9.Text = JogadorAtual;
                Verificar(JogadorAtual);
               
            }
        }
    }
}

