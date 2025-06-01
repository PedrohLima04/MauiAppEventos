using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppEventos.Models
{
    public class Evento
    {
        public required string Nome { get; set; }
        public required string Local {  get; set; }
        public double ValorD
        {
            get => 250;
        }
        public double ValorP
        {
            get => 150;
        }
        public DateTime Dp_inicio { get; set; }
        public DateTime Dp_termino { get; set; }
        public int QntPessoas { get; set; }

        public int PeriodoEvento 
        {
            get => Dp_termino.Subtract(Dp_inicio).Days;
        }
        
        public double ValorTotal
        {
            get
            {
                double total = (ValorD * PeriodoEvento) + (ValorP * QntPessoas);
                return total;
            }
        }

    }//fim classe
}//fim namespace
