using Dominio.Entidade;

namespace AplicacaoDto.RespostaDto.contaDto
{
    /// <summary>
    /// Respota que retorna conta cadastrada por consulta do id
    /// </summary>
    public class RespostaGetByIdContaDto : RespostaDto
    {
        /// <summary>
        /// Resposta que retorna conta por id
        /// </summary>
        public conta conta { get; set; }
    }
}
