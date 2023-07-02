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
            SuspendLayout();
            // 
            // BtnNovoJogo
            // 
            BtnNovoJogo.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnNovoJogo.Location = new Point(12, 121);
            BtnNovoJogo.Name = "BtnNovoJogo";
            BtnNovoJogo.Size = new Size(198, 74);
            BtnNovoJogo.TabIndex = 2;
            BtnNovoJogo.Text = "Novo jogo";
            BtnNovoJogo.UseVisualStyleBackColor = true;
            BtnNovoJogo.Click += BtnNovoJogo_Click;
            // 
            // BtnSair
            // 
            BtnSair.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnSair.Location = new Point(282, 121);
            BtnSair.Name = "BtnSair";
            BtnSair.Size = new Size(194, 74);
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
            TxtApelido.Size = new Size(351, 37);
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
            BtnEnviar.Location = new Point(369, 60);
            BtnEnviar.Name = "BtnEnviar";
            BtnEnviar.Size = new Size(107, 37);
            BtnEnviar.TabIndex = 1;
            BtnEnviar.Text = "Enviar";
            BtnEnviar.UseVisualStyleBackColor = true;
            BtnEnviar.Click += BtnEnviar_Click;
            // 
            // FrmNovoJogo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 221);
            ControlBox = false;
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnNovoJogo;
        private Button BtnSair;
        private TextBox TxtApelido;
        private Label label1;
        private Button BtnEnviar;
    }
}