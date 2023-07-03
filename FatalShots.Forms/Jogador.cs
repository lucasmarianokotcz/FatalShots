using FatalShots.Forms.Properties;

namespace FatalShots
{
    internal static class Jogador
    {
        private const int ConstanciaMovimentacaoNave = 30;
        private const int PixelMinimoEsquerdaNave = 15;
        private const int PixelMaximoEsquerdaNave = 715;

        internal static void MoverEsquerda(PictureBox PicJogador)
        {
            if (PicJogador.Left - ConstanciaMovimentacaoNave > PixelMinimoEsquerdaNave)
            {
                PicJogador.Left -= ConstanciaMovimentacaoNave;
            }
            else
            {
                PicJogador.Left = PixelMinimoEsquerdaNave;
            }
        }

        internal static void MoverDireita(PictureBox PicJogador)
        {
            if (PicJogador.Left + ConstanciaMovimentacaoNave < PixelMaximoEsquerdaNave)
            {
                PicJogador.Left += ConstanciaMovimentacaoNave;
            }
            else
            {
                PicJogador.Left = PixelMaximoEsquerdaNave;
            }
        }

        internal static void Atirar(PictureBox PicJogador, Panel pnlJogo)
        {
            LancarMissil(PicJogador, pnlJogo);
            EmitirSomMissil();
        }

        private static void LancarMissil(PictureBox PicJogador, Panel pnlJogo)
        {
            PictureBox picMissil = new()
            {
                Name = "picMissil" + Random.Shared.Next(),
                Image = Resources.missile,
                Width = 25,
                Height = 35,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Left = PicJogador.Left + 20,
                Top = PicJogador.Top - 50
            };

            pnlJogo.Controls.Add(picMissil);
        }

        private static void EmitirSomMissil()
        {
            using System.Media.SoundPlayer player = new(Resources.shot);
            player.Play();
        }
    }
}
