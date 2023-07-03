using FatalShots.Forms.Properties;

namespace FatalShots
{
    internal static class Monstro
    {
        private const int PixelMinimoEsquerdaNave = 15;
        private const int PixelMaximoEsquerdaNave = 715;

        internal static void GerarMonstro(Panel pnlJogo)
        {
            PictureBox picMonstro = new()
            {
                Name = "picMonstro" + Random.Shared.Next(),
                Image = Resources.enemy,
                Width = 50,
                Height = 50,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Left = Random.Shared.Next(PixelMinimoEsquerdaNave, PixelMaximoEsquerdaNave),
                Top = 20
            };

            foreach (Control control in pnlJogo.Controls)
            {
                if (!control.Name.StartsWith("picMonstro"))
                    continue;

                if (control.Bounds.IntersectsWith(picMonstro.Bounds))
                {
                    Dispose(picMonstro);
                    return;
                }
            }

            pnlJogo.Controls.Add(picMonstro);
        }

        internal static void ZerarMonstros(Panel pnlJogo)
        {
            foreach (Control control in pnlJogo.Controls)
            {
                if (!control.Name.StartsWith("picMonstro"))
                    continue;

                Dispose(control);
            }
        }

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
