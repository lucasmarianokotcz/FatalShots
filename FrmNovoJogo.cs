using FatalShots.Data.Models;
using System.Data;
using System.Windows.Forms;

namespace FatalShots
{
    public partial class FrmNovoJogo : Form
    {
        private readonly int _pontuacao;

        public FrmNovoJogo(int pontuacao)
        {
            InitializeComponent();
            _pontuacao = pontuacao;
        }

        private async void FrmNovoJogo_Load(object sender, EventArgs e)
        {
            await ObterPontuacoesJogadores();
        }

        private async void BtnEnviar_Click(object sender, EventArgs e)
        {
            TxtApelido.Enabled = BtnEnviar.Enabled = false;

            if (FormularioInvalido())
                return;

            try
            {
                PontuacaoJogador pontuacao = new(TxtApelido.Text.Trim(), _pontuacao);
                if (await pontuacao.SalvarPontuacaoJogador())
                {
                    TxtApelido.Enabled = BtnEnviar.Enabled = false;

                    await ObterPontuacoesJogadores();
                }
                else
                    throw new Exception();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao salvar a sua pontuação. Detalhes técnicos: {ex.Message}",
                    "Erro ao salvar pontuação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                BtnEnviar.Enabled = true;
            }
            finally
            {
                BtnEnviar.Text = "Enviar";
            }
        }

        private async Task ObterPontuacoesJogadores()
        {
            LblTop5.Text = "Top 5 jogadores (carregando...)";

            var pontuacoes = await new PontuacaoJogador().ObterPontucaoesJogadores();

            // Converter a lista anônima para um DataTable
            var newPont = pontuacoes.Select(p => new
            {
                p.Apelido,
                p.Pontuacao
            }).ToList();

            DataTable dataTable = new();

            // Adicionar as colunas ao DataTable
            dataTable.Columns.Add("Apelido", typeof(string));
            dataTable.Columns.Add("Pontuação", typeof(int));

            foreach (var item in newPont)
            {
                dataTable.Rows.Add(item.Apelido, item.Pontuacao);
            }

            // Atribuir o DataTable como a fonte de dados do DataGridView
            DgvPontuacoes.DataSource = dataTable;

            LblTop5.Text = "Top 5 jogadores";
        }

        private bool FormularioInvalido()
        {
            if (string.IsNullOrWhiteSpace(TxtApelido.Text))
            {
                MessageBox.Show("Preencha o seu apelido.", "Erro ao salvar pontuação.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
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
