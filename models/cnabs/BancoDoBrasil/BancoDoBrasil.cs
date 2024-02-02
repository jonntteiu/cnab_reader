using CnabReader.Models.Attributes;
using CnabReader.Models.Classes;
using CnabReader.Models.Cnabs.Sizes;

namespace CnabReader.Models.Cnabs.BancoDoBrasil;

[CnabInfo(CnabSize.V400)]
public class BancoDoBrasil : Cnab
{
    public BancoDoBrasil()
    {
        ValidateMapping();
    }

    [CnabRowInfo(0)]
    public class HeaderArquivo : CnabRow
    {
        [CnabField(1, 1)]
        public int IdentificacaoRegistro { get; set; } = default;

        [CnabField(2, 1)]
        public int TipoDeOperacao { get; set; } = default;

        [CnabField(3, 7)]
        public string? IdentificadorPorExtensoDoTipoDeOperacao { get; set; } = default;

        [CnabField(10, 2)]
        public int IdentificadorTipoDeServico { get; set; } = default;

        [CnabField(12, 8)]
        public string? IdentificadorPorExtensoDoTipoDeServico { get; set; } = default;

        [CnabField(20, 7)]
        public string? Brancos_01 { get; set; } = default;

        [CnabField(27, 4)]
        public int PrefixoAgencia { get; set; } = default;

        [CnabField(31, 1)]
        public string? DigitoVerificadorAgencia { get; set; } = default;

        [CnabField(32, 8)]
        public int NumeroContaCorrente { get; set; } = default;

        [CnabField(40, 1)]
        public string? DigitoVerificadorContaCorrente { get; set; } = default;

        [CnabField(41, 6)]
        public int NumeroConvenioLider { get; set; } = default;

        [CnabField(47, 30)]
        public string? NomeDoCedente { get; set; } = default;

        [CnabField(77, 18)]
        public string? BANCO_DO_BRASIL_001 { get; set; } = default;

        [CnabField(95, 6)]
        public DateTime DataDaGravacao { get; set; } = default;

        [CnabField(101, 7)]
        public int SequencialRemessa { get; set; } = default;

        [CnabField(108, 287)]
        public string? Brancos_02 { get; set; } = default;

        [CnabField(395, 6)]
        public int SequencialRegistro { get; set; } = default;
    }
}