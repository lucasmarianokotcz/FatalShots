using System.Windows.Forms;

namespace FatalShots
{
    public partial class FrmJogo : Form
    {
        private const int VelocidadeTirosNave = 15;
        private const double MinutosJogo = 1;
        private TimeSpan tempoRestante = TimeSpan.FromMinutes(MinutosJogo);
        private bool jogoRodando = true;

        public FrmJogo()
        {
            InitializeComponent();
        }

        #region Eventos

        #region Form
        private void FrmJogo_Load(object sender, EventArgs e)
        {
            IniciarJogo();
        }

        private void FrmJogo_KeyDown(object sender, KeyEventArgs e)
        {
            if (jogoRodando)
            {
                switch (e.KeyCode)
                {
                    case Keys.Left:
                        Jogador.MoverEsquerda(PicNave);
                        break;

                    case Keys.Right:
                        Jogador.MoverDireita(PicNave);
                        break;

                    case Keys.Space:
                        Jogador.Atirar(PicNave, PnlJogo);
                        break;

                    default:
                        break;
                }
            }
        }

        private void FrmJogo_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)Keys.Escape:
                    PausarJogo();
                    MostrarMenu();
                    break;

                default:
                    break;
            }
        }
        #endregion

        #region Botões
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            EsconderMenu();
            MostrarJogo();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Timer
        private void TmrTiros_Tick(object sender, EventArgs e)
        {
            foreach (Control control in PnlJogo.Controls)
            {
                if (!control.Name.StartsWith("picMissel"))
                    continue;

                if (control is not null && control.Name != PicNave.Name)
                {
                    if (control.Top > 0 && jogoRodando)
                    {
                        control.Top -= VelocidadeTirosNave;
                        Jogo.CalcularAcertoMonstro((PictureBox)control, PnlJogo, LblPontos);
                    }
                    else
                    {
                        Dispose(control);
                    }
                }
            }
        }

        private void TmrInimigos_Tick(object sender, EventArgs e)
        {
            Monstro.GerarMonstro(PnlJogo);
        }

        private void TmrTempo_Tick(object sender, EventArgs e)
        {
            tempoRestante = tempoRestante.Subtract(TimeSpan.FromSeconds(1));

            if (tempoRestante >= TimeSpan.Zero)
            {
                AtualizarTempo();
            }
            else
            {
                TerminarJogo();
            }
        }
        #endregion

        #endregion

        #region Métodos

        #region Jogo
        public void IniciarJogo()
        {
            ZerarJogo();
            jogoRodando = true;
            IniciarTimers();
        }

        private void TerminarJogo()
        {
            jogoRodando = false;
            PararTimers(pararTiros: false);
            MessageBox.Show($"O jogo acabou! Você fez {Jogo.pontos} pontos.", "Fim de jogo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult result = new FrmNovoJogo(Jogo.pontos).ShowDialog();
            if (result == DialogResult.Cancel)
            {
                IniciarJogo();
            }
        }

        private void ZerarJogo()
        {
            tempoRestante = TimeSpan.FromMinutes(MinutosJogo);
            PararTimers();
            Monstro.ZerarMonstros(PnlJogo);
            Jogo.ZerarPontos(LblPontos);
            Jogo.ZerarTempo(LblTimer);
            ReposicionarNave();
        }

        private void ReposicionarNave()
        {
            PicNave.Location = new Point(360, 310);
        }

        private void PausarJogo()
        {
            PararTimers();
            PnlJogo.Visible = false;
        }

        private void MostrarJogo()
        {
            PnlJogo.Visible = true;
            IniciarTimers();
        }

        private void PararTimers(bool pararTiros = true)
        {
            TmrMonstros.Stop();
            TmrTempo.Stop();

            if (pararTiros)
                TmrTiros.Stop();
        }

        private void IniciarTimers()
        {
            if (jogoRodando)
            {
                TmrMonstros.Start();
                TmrTiros.Start();
                TmrTempo.Start();
            }
        }

        private void EsconderMenu()
        {
            ActiveControl = null;
            BackColor = Color.White;
            PnlMenu.Visible = false;
        }

        private void MostrarMenu()
        {
            BackColor = SystemColors.Control;
            PnlMenu.Visible = true;
        }

        private void AtualizarTempo()
        {
            LblTimer.Text = $"Tempo: {tempoRestante:m\\:ss}";
        }

        #endregion

        protected static void Dispose(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Dispose();
            }

            GC.Collect();
        }

        #endregion
    }
}