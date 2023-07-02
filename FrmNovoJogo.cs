namespace FatalShots
{
    public partial class FrmNovoJogo : Form
    {
        public FrmNovoJogo()
        {
            InitializeComponent();
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {

        }

        private void BtnNovoJogo_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
