using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraConsole
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }

        public int somar(int num1, int num2)
        {
            int res = num1 + num2;
            listaHistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }

        public int subtrair(int num1, int num2)
        {
            int res = num1 - num2;
            listaHistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }

        public int multiplicar(int num1, int num2)
        {
            int res = num1 * num2;
            listaHistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }

        public int dividir(int num1, int num2)
        {
            int res = num1 / num2;
            listaHistorico.Insert(0, "Res: " + res + " - data: " + data);
            return res;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}