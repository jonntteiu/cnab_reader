using CnabReader.Models.Attributes;
using CnabReader.Models.Classes;
using CnabReader.Models.Cnabs.Sizes;

namespace CnabReader.Models.Cnabs.BancoDoBrasil;

[CnabInfo(CnabSize.V400)]
public class BancoDoBrasil : Cnab
{
    [CnabRow(0)]
    public class HeaderArquivo
    {
        [CnabField(1, 1)]
        public int IdentificacaoRegistro { get; set; }

        [CnabField(2, 1)]
        public int TipoDeOperacao { get; set; }

        [CnabField(3, 7)]
        public string? IdentificadorPorExtensoDoTipoDeOperacao { get; set; }

        [CnabField(10, 2)]
        public int IdentificadorTipoDeServico { get; set; }

        [CnabField(12, 8)]
        public string? IdentificadorPorExtensoDoTipoDeServico { get; set; }

        [CnabField(20, 7)]
        public string? Brancos_01 { get; set; }

        [CnabField(27, 4)]
        public int PrefixoAgencia { get; set; }

        [CnabField(31, 1)]
        public string? DigitoVerificadorAgencia { get; set; }

        [CnabField(32, 8)]
        public int NumeroContaCorrente { get; set; }

        [CnabField(40, 1)]
        public string? DigitoVerificadorContaCorrente { get; set; }

        [CnabField(41, 6)]
        public int NumeroConvenioLider { get; set; }

        [CnabField(47, 30)]
        public string? NomeDoCedente { get; set; }

        [CnabField(77, 18)]
        public string? BANCO_DO_BRASIL_001 { get; set; }

        [CnabField(95, 6)]
        public DateTime DataDaGravacao { get; set; }

        [CnabField(101, 7)]
        public int SequencialRemessa { get; set; }

        [CnabField(108, 287)]
        public int Brancos_02 { get; set; }

        [CnabField(395, 6)]
        public int SequencialRegistro { get; set; }
    }
}