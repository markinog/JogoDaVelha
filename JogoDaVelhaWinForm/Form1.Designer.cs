namespace JogoDaVelhaWinForm
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            label1 = new Label();
            button10 = new Button();
            lblX = new Label();
            lblO = new Label();
            VitX = new Label();
            VitO = new Label();
            lblEmpate = new Label();
            EmpateValor = new Label();
            txtQuemJoga = new TextBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.Control;
            btn1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.ForeColor = SystemColors.ControlText;
            btn1.Location = new Point(22, 21);
            btn1.Name = "btn1";
            btn1.Size = new Size(82, 69);
            btn1.TabIndex = 0;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += btn1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(110, 21);
            btn2.Name = "btn2";
            btn2.Size = new Size(82, 69);
            btn2.TabIndex = 1;
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(198, 21);
            btn3.Name = "btn3";
            btn3.Size = new Size(82, 69);
            btn3.TabIndex = 2;
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(22, 96);
            btn4.Name = "btn4";
            btn4.Size = new Size(82, 69);
            btn4.TabIndex = 3;
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(110, 96);
            btn5.Name = "btn5";
            btn5.Size = new Size(82, 69);
            btn5.TabIndex = 4;
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(198, 96);
            btn6.Name = "btn6";
            btn6.Size = new Size(82, 69);
            btn6.TabIndex = 5;
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(22, 171);
            btn7.Name = "btn7";
            btn7.Size = new Size(82, 69);
            btn7.TabIndex = 6;
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(110, 171);
            btn8.Name = "btn8";
            btn8.Size = new Size(82, 69);
            btn8.TabIndex = 7;
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(198, 171);
            btn9.Name = "btn9";
            btn9.Size = new Size(82, 69);
            btn9.TabIndex = 8;
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Courier New", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(310, 21);
            label1.Name = "label1";
            label1.Size = new Size(93, 32);
            label1.TabIndex = 9;
            label1.Text = "PLACAR";
            // 
            // button10
            // 
            button10.BackColor = Color.SpringGreen;
            button10.ForeColor = Color.Black;
            button10.Location = new Point(307, 187);
            button10.Name = "button10";
            button10.Size = new Size(161, 50);
            button10.TabIndex = 10;
            button10.Text = "Resetar";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // lblX
            // 
            lblX.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblX.ForeColor = Color.Red;
            lblX.Location = new Point(307, 58);
            lblX.Name = "lblX";
            lblX.Size = new Size(93, 32);
            lblX.TabIndex = 11;
            lblX.Text = "Jogador X: ";
            // 
            // lblO
            // 
            lblO.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblO.ForeColor = Color.Blue;
            lblO.Location = new Point(307, 90);
            lblO.Name = "lblO";
            lblO.Size = new Size(93, 32);
            lblO.TabIndex = 12;
            lblO.Text = "Jogador O: ";
            // 
            // VitX
            // 
            VitX.AutoSize = true;
            VitX.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            VitX.ForeColor = Color.Red;
            VitX.Location = new Point(393, 58);
            VitX.Name = "VitX";
            VitX.Size = new Size(16, 17);
            VitX.TabIndex = 13;
            VitX.Text = "0";
            // 
            // VitO
            // 
            VitO.AutoSize = true;
            VitO.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            VitO.ForeColor = Color.Blue;
            VitO.Location = new Point(393, 91);
            VitO.Name = "VitO";
            VitO.Size = new Size(16, 17);
            VitO.TabIndex = 14;
            VitO.Text = "0";
            // 
            // lblEmpate
            // 
            lblEmpate.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEmpate.ForeColor = Color.Yellow;
            lblEmpate.Location = new Point(307, 118);
            lblEmpate.Name = "lblEmpate";
            lblEmpate.Size = new Size(93, 32);
            lblEmpate.TabIndex = 15;
            lblEmpate.Text = "Empates: ";
            // 
            // EmpateValor
            // 
            EmpateValor.AutoSize = true;
            EmpateValor.Font = new Font("Arial", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            EmpateValor.ForeColor = Color.FromArgb(255, 255, 128);
            EmpateValor.Location = new Point(384, 118);
            EmpateValor.Name = "EmpateValor";
            EmpateValor.Size = new Size(16, 17);
            EmpateValor.TabIndex = 16;
            EmpateValor.Text = "0";
            // 
            // txtQuemJoga
            // 
            txtQuemJoga.BackColor = Color.SpringGreen;
            txtQuemJoga.Enabled = false;
            txtQuemJoga.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtQuemJoga.ForeColor = Color.Black;
            txtQuemJoga.Location = new Point(310, 158);
            txtQuemJoga.Name = "txtQuemJoga";
            txtQuemJoga.Size = new Size(158, 25);
            txtQuemJoga.TabIndex = 17;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSeaGreen;
            ClientSize = new Size(480, 249);
            Controls.Add(txtQuemJoga);
            Controls.Add(EmpateValor);
            Controls.Add(lblEmpate);
            Controls.Add(VitO);
            Controls.Add(VitX);
            Controls.Add(lblO);
            Controls.Add(lblX);
            Controls.Add(button10);
            Controls.Add(label1);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Name = "FrmMain";
            Text = "Jogo da Velha";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Label label1;
        private Button button10;
        private Label lblX;
        private Label lblO;
        private Label VitX;
        private Label VitO;
        private Label lblEmpate;
        private Label EmpateValor;
        private TextBox txtQuemJoga;
    }
}
