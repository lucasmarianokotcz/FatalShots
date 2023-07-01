﻿using FatalShots.Properties;
using Timer = System.Windows.Forms.Timer;

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
            PictureBox picMissel = new()
            {
                Name = "picMissel" + Random.Shared.Next(),
                Image = Resources.missile,
                Width = 25,
                Height = 35,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Left = PicJogador.Left + 20,
                Top = PicJogador.Top - 50
            };

            pnlJogo.Controls.Add(picMissel);
        }
    }
}
