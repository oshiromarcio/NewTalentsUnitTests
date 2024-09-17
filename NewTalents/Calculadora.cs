using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private Queue<string> _historico = new Queue<string>();

        public int somar(int num1, int num2)
        {
            int result = num1 + num2;
            this.gravaHistorico($"{ num1 } + { num2 } = { result }");
            return result;
        }

        public int subtrair(int num1, int num2)
        {
            int result = num1 - num2;
            this.gravaHistorico($"{num1} - {num2} = {result}");
            return result;
        }

        public int multiplicar(int num1, int num2)
        {
            int result = num1 * num2;
            this.gravaHistorico($"{num1} x {num2} = {result}");
            return result;
        }

        public int dividir(int num1, int num2)
        {
            int result = num1 / num2;
            this.gravaHistorico($"{num1} / {num2} = {result}");
            return result;
        }

        private void gravaHistorico(string historicoCalculo)
        {
            this._historico.Enqueue(historicoCalculo);
            while (this._historico.Count > 3)
                this._historico.Dequeue();
        }

        public List<string> historico()
        {
            return this._historico.ToList();
        }
    }
}
