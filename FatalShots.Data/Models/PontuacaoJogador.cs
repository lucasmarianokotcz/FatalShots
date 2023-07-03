using MySql.Data.MySqlClient;

namespace FatalShots.Data.Models
{
    public class PontuacaoJogador
    {
        private readonly string connectionString = "";

        public PontuacaoJogador()
        {

        }

        public PontuacaoJogador(string apelido, int pontuacao)
        {
            Apelido = apelido;
            Pontuacao = pontuacao;
            Data = DateTime.Now;
        }

        public int Id { get; private set; }
        public string? Apelido { get; private set; }
        public DateTime Data { get; private set; }
        public int Pontuacao { get; private set; }

        public async Task<bool> SalvarPontuacaoJogador()
        {
            bool aux = false;

            using (MySqlConnection connection = new(connectionString))
            {
                await connection.OpenAsync();

                string sql = @"INSERT INTO PontuacaoJogador (Apelido, Data, Pontuacao)
                                VALUES (@Apelido, @Data, @Pontuacao);";

                using (MySqlCommand command = new(sql, connection))
                {
                    command.CommandType = System.Data.CommandType.Text;
                    command.Parameters.AddWithValue("@Apelido", Apelido);
                    command.Parameters.AddWithValue("@Data", Data);
                    command.Parameters.AddWithValue("@Pontuacao", Pontuacao);

                    aux = await command.ExecuteNonQueryAsync() > 0;
                }

                await connection.CloseAsync();
            }

            return aux;
        }

        public async Task<List<PontuacaoJogador>> ObterPontucaoesJogadores()
        {
            List<PontuacaoJogador> pontuacoes = new();

            using (MySqlConnection connection = new(connectionString))
            {
                await connection.OpenAsync();

                string sql = @"SELECT * FROM PontuacaoJogador
                                ORDER BY Pontuacao DESC, Data DESC
                                LIMIT 5;";

                using (MySqlCommand command = new(sql, connection))
                {
                    using (MySqlDataReader reader = (MySqlDataReader)await command.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            pontuacoes.Add(new PontuacaoJogador
                                (Convert.ToString(reader["Apelido"])!,
                                Convert.ToInt32(reader["Pontuacao"])));
                        }
                    }
                }

                await connection.CloseAsync();
            }

            return pontuacoes;
        }
    }
}