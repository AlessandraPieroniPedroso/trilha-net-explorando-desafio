namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            // TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
                        
            if (hospedes.Count() <= Suite.Capacidade)
            {
                Hospedes = hospedes;
                hospedes.Count();

            }
            else
            {
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
               
                throw new InvalidOperationException("A capacidade da suíte é menor que o número de hóspedes.");

            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            
            return Hospedes?.Count ?? 0;

        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            
            
            decimal valor = 0;
            decimal desconto = 0.1M;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            
            if (DiasReservados >= 10 )
            {
                valor = (DiasReservados * Suite.ValorDiaria)-(DiasReservados * Suite.ValorDiaria * desconto);
                
                
            }
            else
            {
                valor = 0;
                valor = DiasReservados * Suite.ValorDiaria;
            }

            return valor;
        }
    }
}