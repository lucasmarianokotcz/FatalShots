namespace FatalShots
{
    partial class FrmNovoJogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnNovoJogo = new Button();
            BtnSair = new Button();
            TxtApelido = new TextBox();
            label1 = new Label();
            BtnEnviar = new Button();
            DgvPontuacoes = new DataGridView();
            LblTop5 = new Label();
            ((System.ComponentModel.ISupportInitialize)DgvPontuacoes).BeginInit();
            SuspendLayout();
            // 
            // BtnNovoJogo
            // 
            BtnNovoJogo.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNovoJogo.Location = new Point(12, 333);
            BtnNovoJogo.Name = "BtnNovoJogo";
            BtnNovoJogo.Size = new Size(200, 74);
            BtnNovoJogo.TabIndex = 2;
            BtnNovoJogo.Text = "Novo jogo";
            BtnNovoJogo.UseVisualStyleBackColor = true;
            BtnNovoJogo.Click += BtnNovoJogo_Click;
            // 
            // BtnSair
            // 
            BtnSair.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSair.Location = new Point(284, 333);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(196, 74);
            BtnSair.TabIndex = 3;
            BtnSair.Text = "Sair do jogo";
            BtnSair.UseVisualStyleBackColor = true;
            BtnSair.Click += BtnSair_Click;
            // 
            // TxtApelido
            // 
            TxtApelido.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            TxtApelido.Location = new Point(12, 60);
            TxtApelido.MaxLength = 20;
            TxtApelido.Name = "TxtApelido";
            TxtApelido.Size = new Size(303, 37);
            TxtApelido.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(464, 29);
            label1.TabIndex = 3;
            label1.Text = "Digite seu apelido para enviar a sua pontuação:";
            // 
            // BtnEnviar
            // 
            BtnEnviar.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnEnviar.Location = new Point(321, 60);
            BtnEnviar.Name = "BtnEnviar";
            BtnEnviar.Size = new Size(159, 37);
            BtnEnviar.TabIndex = 1;
            BtnEnviar.Text = "Enviar";
            BtnEnviar.UseVisualStyleBackColor = true;
            BtnEnviar.Click += BtnEnviar_Click;
            // 
            // DgvPontuacoes
            // 
            DgvPontuacoes.AllowUserToAddRows = false;
            DgvPontuacoes.AllowUserToDeleteRows = false;
            DgvPontuacoes.AllowUserToResizeColumns = false;
            DgvPontuacoes.AllowUserToResizeRows = false;
            DgvPontuacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvPontuacoes.Location = new Point(103, 150);
            DgvPontuacoes.MultiSelect = false;
            DgvPontuacoes.Name = "DgvPontuacoes";
            DgvPontuacoes.ReadOnly = true;
            DgvPontuacoes.RowTemplate.Height = 25;
            DgvPontuacoes.ScrollBars = ScrollBars.None;
            DgvPontuacoes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPontuacoes.Size = new Size(287, 177);
            DgvPontuacoes.TabIndex = 4;
            // 
            // LblTop5
            // 
            LblTop5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            LblTop5.Location = new Point(12, 112);
            LblTop5.Name = "LblTop5";
            LblTop5.Size = new Size(464, 26);
            LblTop5.TabIndex = 5;
            LblTop5.Text = "Top 5 jogadores";
            LblTop5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmNovoJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 419);
            ControlBox = false;
            Controls.Add(LblTop5);
            Controls.Add(DgvPontuacoes);
            Controls.Add(BtnEnviar);
            Controls.Add(label1);
            Controls.Add(TxtApelido);
            Controls.Add(BtnSair);
            Controls.Add(BtnNovoJogo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "FrmNovoJogo";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FatalShots v1.0";
            Load += FrmNovoJogo_Load;
            ((System.ComponentModel.ISupportInitialize)DgvPontuacoes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnNovoJogo;
        private Button BtnSair;
        private TextBox TxtApelido;
        private Label label1;
        private Button BtnEnviar;
        private DataGridView DgvPontuacoes;
        private Label LblTop5;
    }
}