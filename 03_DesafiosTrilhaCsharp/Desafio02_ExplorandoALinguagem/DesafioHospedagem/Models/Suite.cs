using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHospedagem.Models;

public class Suite
{   

    public Suite()
    {
    }

    public Suite(string tipoDaSuite, int capacidade, decimal valorDaDiaria)
    {
        TipoDaSuite = tipoDaSuite;
        Capacidade = capacidade;
        ValorDaDiaria = Convert.ToDecimal(valorDaDiaria);
    }
    public string TipoDaSuite { get; set; }
    public int Capacidade { get; set; }
    public decimal ValorDaDiaria { get; set; }
}
