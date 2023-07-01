namespace FatalShots
{
    internal class Jogo
    {
        public static int pontos;

        internal static void CalcularAcertoMonstro(PictureBox missel, Panel pnlJogo, Label lblPontos)
        {
            foreach (Control control in pnlJogo.Controls)
            {
                if (!control.Name.StartsWith("picMonstro"))
                    continue;

                if (MisselAcertaMonstro(control, missel))
                {
                    Dispose(control, missel);
                    AtualizaPontos(lblPontos);
                    Monstro.GerarMonstro(pnlJogo);
                }
            }
        }

        private static void AtualizaPontos(Label lblPontos)
        {
            pontos++;
            lblPontos.Text = $"Pontos: {pontos}";
        }

        internal static bool MisselAcertaMonstro(Control monstro, Control missel) =>
            monstro.Bounds.IntersectsWith(missel.Bounds);

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