using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appLabirinto
{
	class Movimento : IComparable<Movimento>
	{
		private int linhaOrigem, linhaDestino,
					colunaOrigem, colunaDestino;

		public Movimento(int movimento, int linhaOrigem, int colunaOrigem)
		{
			LinhaOrigem = linhaOrigem;
			ColunaOrigem = colunaOrigem;

			switch (movimento)
			{
				case 0: { LinhaDestino = LinhaOrigem - 1; ColunaDestino = ColunaOrigem - 0; }; break;
				case 1: { LinhaDestino = LinhaOrigem - 1; ColunaDestino = ColunaOrigem + 1; }; break;
				case 2: { LinhaDestino = LinhaOrigem + 0; ColunaDestino = ColunaOrigem + 1; }; break;
				case 3: { LinhaDestino = LinhaOrigem + 1; ColunaDestino = ColunaOrigem + 1; }; break;
				case 4: { LinhaDestino = LinhaOrigem + 1; ColunaDestino = ColunaOrigem + 0; }; break;
				case 5: { LinhaDestino = LinhaOrigem + 1; ColunaDestino = ColunaOrigem - 1; }; break;
				case 6: { LinhaDestino = LinhaOrigem - 0; ColunaDestino = ColunaOrigem - 1; }; break;
				case 7: { LinhaDestino = LinhaOrigem - 1; ColunaDestino = ColunaOrigem - 1; }; break;
			}
		}
		public int LinhaOrigem
		{
			get => linhaOrigem;
			set => linhaOrigem = value;
		}
		public int LinhaDestino
		{
			get => linhaDestino;
			set => linhaDestino = value;
		}
		public int ColunaOrigem
		{
			get => colunaOrigem;
			set => colunaOrigem = value;
		}
		public int ColunaDestino
		{
			get => colunaDestino;
			set => colunaDestino = value;
		}

		public override String ToString()
		{
			return "[" + linhaOrigem + "," + colunaOrigem + "]" + " para " +
				   "[" + linhaDestino + "," + colunaDestino + "]";
		}

		public int CompareTo(Movimento outro)   // para compatibilizar com ListaSimples e NoLista
		{
			return 0;
		}
	}
}
