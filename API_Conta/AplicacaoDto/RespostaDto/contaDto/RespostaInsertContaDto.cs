using Dominio.Entidade;

namespace AplicacaoDto.RespostaDto.InsertContaDto
{
    /// <summary>
    /// Classe de resposta relacionada a conta 
    /// </summary>
    public class RespostaInsertContaDto : RespostaDto
    {
        /// <summary>
        /// Resposta ao inserir, devolve um objeto do tipo conta
        /// </summary>
        public conta conta { get; set; }
    }
}
