using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHospedagem.Models;

public class Reserva
{

    public Reserva()
    {
    }

    public Reserva(int diasReservados)
    {
        DiasReservados = diasReservados;
    }

    public List<Pessoa> Hospedes { get; set; }
    public Suite Suite { get; set; }
    public int DiasReservados { get; set; }

    public void CadastrarHospedes(List<Pessoa> hospedes)
    {
        
        bool capacidadeAdequada = Suite.Capacidade >= hospedes.Count() ? true : false;

        if (capacidadeAdequada)
        {
            Hospedes = hospedes;
        }
        else
        {
            throw new Exception("Não foi possível fazer a reserva...Capacidade da é inferior a quantidade de hóspedes.");
        }
    }

    public void CadastrarSuite(Suite suite)
    {
        Suite = suite;
    }

    public int ObterQuantidadeDeHospedes()
    {
       
        return Hospedes.Count();
    }

    public decimal CalcularValorDaDiaria()
    {
        
        decimal valor = Convert.ToDecimal(Suite.ValorDaDiaria * DiasReservados);

        if (DiasReservados >= 10)
        {

            valor *= 0.9M;
        }

        return valor;
    }

}
