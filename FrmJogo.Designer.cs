namespace FatalShots
{
    partial class FrmJogo
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJogo));
            PicNave = new PictureBox();
            PnlMenu = new Panel();
            label1 = new Label();
            BtnVoltar = new Button();
            BtnSair = new Button();
            PnlJogo = new Panel();
            LblTimer = new Label();
            LblPontos = new Label();
            TmrTiros = new System.Windows.Forms.Timer(components);
            TmrMonstros = new System.Windows.Forms.Timer(components);
            TmrTempo = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)PicNave).BeginInit();
            PnlMenu.SuspendLayout();
            PnlJogo.SuspendLayout();
            SuspendLayout();
            // 
            // PicNave
            // 
            PicNave.Image = (Image)resources.GetObject("PicNave.Image");
            PicNave.Location = new Point(360, 310);
            PicNave.Name = "PicNave";
            PicNave.Size = new Size(75, 75);
            PicNave.SizeMode = PictureBoxSizeMode.StretchImage;
            PicNave.TabIndex = 0;
            PicNave.TabStop = false;
            // 
            // PnlMenu
            // 
            PnlMenu.BackColor = Color.White;
            PnlMenu.BorderStyle = BorderStyle.FixedSingle;
            PnlMenu.Controls.Add(label1);
            PnlMenu.Controls.Add(BtnVoltar);
            PnlMenu.Controls.Add(BtnSair);
            PnlMenu.Location = new Point(277, 120);
            PnlMenu.Name = "PnlMenu";
            PnlMenu.Size = new Size(246, 210);
            PnlMenu.TabIndex = 1;
            PnlMenu.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 14);
            label1.Name = "label1";
            label1.Size = new Size(155, 29);
            label1.TabIndex = 2;
            label1.Text = "Menu de pausa";
            // 
            // BtnVoltar
            // 
            BtnVoltar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnVoltar.Location = new Point(52, 68);
            BtnVoltar.Name = "BtnVoltar";
            BtnVoltar.Size = new Size(141, 53);
            BtnVoltar.TabIndex = 1;
            BtnVoltar.Text = "Voltar";
            BtnVoltar.UseVisualStyleBackColor = true;
            BtnVoltar.Click += BtnVoltar_Click;
            // 
            // BtnSair
            // 
            BtnSair.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSair.Location = new Point(52, 134);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(141, 53);
            BtnSair.TabIndex = 0;
            BtnSair.Text = "Sair do jogo";
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // PnlJogo
            // 
            PnlJogo.Controls.Add(PicNave);
            PnlJogo.Location = new Point(2, 41);
            PnlJogo.Name = "PnlJogo";
            PnlJogo.Size = new Size(797, 409);
            PnlJogo.TabIndex = 2;
            // 
            // LblTimer
            // 
            LblTimer.AutoSize = true;
            LblTimer.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblTimer.Location = new Point(655, 9);
            LblTimer.Name = "LblTimer";
            LblTimer.Size = new Size(129, 29);
            LblTimer.TabIndex = 2;
            LblTimer.Text = "Tempo: 1:00";
            // 
            // LblPontos
            // 
            LblPontos.AutoSize = true;
            LblPontos.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblPontos.Location = new Point(12, 9);
            LblPontos.Name = "LblPontos";
            LblPontos.Size = new Size(102, 29);
            LblPontos.TabIndex = 1;
            LblPontos.Text = "Pontos: 0";
            // 
            // TmrTiros
            // 
            TmrTiros.Interval = 10;
            TmrTiros.Tick += TmrTiros_Tick;
            // 
            // TmrMonstros
            // 
            TmrMonstros.Interval = 1000;
            TmrMonstros.Tick += TmrInimigos_Tick;
            // 
            // TmrTempo
            // 
            TmrTempo.Interval = 1000;
            TmrTempo.Tick += TmrTempo_Tick;
            // 
            // FrmJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(LblTimer);
            Controls.Add(PnlMenu);
            Controls.Add(LblPontos);
            Controls.Add(PnlJogo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmJogo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FatalShots v1.0";
            Load += FrmJogo_Load;
            KeyDown += FrmJogo_KeyDown;
            KeyPress += FrmJogo_KeyPress;
            ((System.ComponentModel.ISupportInitialize)PicNave).EndInit();
            PnlMenu.ResumeLayout(false);
            PnlMenu.PerformLayout();
            PnlJogo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PicNave;
        private Panel PnlMenu;
        private Button BtnVoltar;
        private Button BtnSair;
        private Label label1;
        private System.Windows.Forms.Timer TmrTiros;
        private Label LblPontos;
        private System.Windows.Forms.Timer TmrMonstros;
        protected internal Panel PnlJogo;
        private Label LblTimer;
        private System.Windows.Forms.Timer TmrTempo;
    }
}