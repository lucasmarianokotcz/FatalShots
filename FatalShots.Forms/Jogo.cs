namespace FatalShots
{
    internal class Jogo
    {
        public static int pontos;

        internal static void CalcularAcertoMonstro(PictureBox missil, Panel pnlJogo, Label lblPontos)
        {
            foreach (Control control in pnlJogo.Controls)
            {
                if (!control.Name.StartsWith("picMonstro"))
                    continue;

                if (MissilAcertaMonstro(control, missil))
                {
                    Monstro.EmitirSomMonstroMorto();
                    Dispose(control, missil);
                    AtualizaPontos(lblPontos);
                    Monstro.GerarMonstro(pnlJogo);
                }
            }
        }

        internal static void ZerarPontos(Label lblPontos)
        {
            pontos = 0;
            lblPontos.Text = $"Pontos: {pontos}";
        }

        internal static void ZerarTempo(Label lblTimer)
        {
            lblTimer.Text = "Tempo: 1:00";
        }

        private static void AtualizaPontos(Label lblPontos)
        {
            pontos++;
            lblPontos.Text = $"Pontos: {pontos}";
        }

        internal static bool MissilAcertaMonstro(Control monstro, Control missil) =>
            monstro.Bounds.IntersectsWith(missil.Bounds);

        internal static void Dispose(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Dispose();
            }

            GC.Collect();
        }
    }
}