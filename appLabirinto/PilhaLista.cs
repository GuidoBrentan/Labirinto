using System;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using System.Security.Cryptography;
using System.Text;

namespace appLabirinto
{
    class PilhaLista<Dado> : ListaSimples<Dado> where Dado : IComparable<Dado>
    {
        public override string ToString() 
        {
            string ret = "";
            base.Atual = base.Primeiro;
            while (base.Atual != null) 
            {
                ret += base.Atual.Info.ToString();
                base.Atual = base.Atual.Prox;
            }
            return ret;
        }

        public PilhaLista() { }

        public Dado Desempilhar()
        {
            if (EstaVazia)
                return default(Dado);

            Dado valor = base.Primeiro.Info;

            NoLista<Dado> pri = base.Primeiro;
            NoLista<Dado> ant = null;
            base.RemoverNo(ref pri, ref ant);
            return valor;
        }

        public void Empilhar(Dado elemento)
        {
            var no = new NoLista<Dado>(elemento, null);

            base.InserirAntesDoInicio(no);
        }

        new public bool EstaVazia
        {
            get => base.EstaVazia;
        }

        public NoLista<Dado> OTopo()
        {
            if (EstaVazia)
                return null;

            return base.Primeiro;
        }

        public int Tamanho { get => base.QuantosNos; }

        public void Exibir(DataGridView dgv)
        {
            dgv.ColumnCount = Tamanho;
            dgv.RowCount = 2;
            for (int j = 0; j < dgv.ColumnCount; j++)
                dgv[j, 0].Value = "";

            var auxiliar = new PilhaLista<Dado>();
            int i = 0;
            while (!this.EstaVazia)
            {
                dgv[i++, 0].Value = this.OTopo();
                Thread.Sleep(300);
                Application.DoEvents();
                auxiliar.Empilhar(this.Desempilhar());
            }

            while (!auxiliar.EstaVazia)
                this.Empilhar(auxiliar.Desempilhar());
        }
    }
}
