namespace OrientacaoObjeto
{
    public class Pedido
    {
        public Pedido(Pessoa cliente, DateTime dataDoServico)
        {
            Cliente = cliente;
            DataDoServico = dataDoServico;
        }

        public Pedido(
            Pessoa cliente,
            DateTime dataDoServico,
            double valorTotal,
            string abservacao)
        {
            Cliente = cliente;
            DataDoServico = dataDoServico;
            ValorTotal = valorTotal;    
            Observacao = abservacao;
        }


        public Pessoa Cliente { get; private set; }

        public IList<string> Produto { get; set; }

        public double ValorTotal { get; set; }

        public DateTime DataDoServico { get; private set; }

        public bool IsPago { get; set; }

        public string Observacao { get; set; }
    }
}