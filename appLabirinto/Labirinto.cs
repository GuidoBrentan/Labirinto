using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace appLabirinto
{
    class Labirinto
    {
        int colunas, linhas;
        char[,] matriz;

        public Labirinto(string nomeDoArquivo)
        {
            var arquivo = new StreamReader(nomeDoArquivo);
            colunas = int.Parse(arquivo.ReadLine());
            linhas = int.Parse(arquivo.ReadLine());

            matriz = new char[linhas, colunas];

            for (int i = 0; i < linhas; i++)
            {
                var linha = arquivo.ReadLine();
                for (int j = 0; j < colunas; j++)
                    matriz[i, j] = linha[j];
            }
        }

        public int Colunas { get => colunas; set => colunas = value; }
        public int Linhas { get => linhas; set => linhas = value; }
        public char[,] Matriz { get => matriz; set => matriz = value; }

        public void ExibirDataGriedView(DataGridView dgv)
        {
            dgv.RowCount = linhas;
            dgv.ColumnCount = colunas;
            for (int coluna = 0; coluna < colunas; coluna++)
            {
                dgv.Columns[coluna].HeaderText = coluna.ToString();
                dgv.Columns[coluna].Width = 30;
            }

            for (int linha = 0; linha < linhas; linha++)
                dgv.Rows[linha].HeaderCell.Value = linha.ToString();

            for (int i = 0; i < linhas; i++)
                for (int j = 0; j < colunas; j++)
                    switch(matriz[i, j])
                    {
                        case '#': dgv.Rows[i].Cells[j].Style.BackColor = Color.Yellow; break;
                        case 'I': dgv.Rows[i].Cells[j].Style.BackColor = Color.Red; break;
                        case 'S': dgv.Rows[i].Cells[j].Style.BackColor = Color.Green; break;
                    }
        }

        public PilhaLista<Movimento> EncontrarCaminhosDataGridView(DataGridView dgv)
        {
            var movimentos = new PilhaLista<Movimento>();
            int linhaOrigem = 1, colunaOrigem = 1;
            bool achou = false, andou;
            int movimentoDeVolta = 0;

            while(!achou)
            {
                andou = false;
                for (int i = 0; i <= 7 && !andou; i++)
                {
                    var mov = new Movimento(i, linhaOrigem, colunaOrigem);

                    if(matriz[mov.LinhaDestino, mov.ColunaDestino] != '#')
                    {
                        if (movimentos.ContagemDeNos() == 0 || movimentos.Primeiro.Info.LinhaOrigem != mov.LinhaDestino ||
                           movimentos.Primeiro.Info.ColunaOrigem != mov.ColunaDestino)
                        {
                            movimentos.Empilhar(mov);
                            linhaOrigem = mov.LinhaDestino;
                            colunaOrigem = mov.ColunaDestino;
                            andou = true;

                            ExibirPasso();
                        }
                        else
                            movimentoDeVolta = i;
                    }

                    if(matriz[mov.LinhaDestino, mov.ColunaDestino] == 'S')
                    {
                        achou = true;
                        movimentos.Empilhar(mov);
                    }
                }

                if(!andou)
                {
                    var mov = movimentos.Desempilhar();

                    if (!movimentos.EstaVazia)
                    {
                        movimentos.Empilhar(new Movimento(movimentoDeVolta, linhaOrigem, colunaOrigem));
                        
                        linhaOrigem = mov.LinhaOrigem;
                        colunaOrigem = mov.ColunaOrigem;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            return movimentos;

            void ExibirPasso()
            {
                dgv.Rows[linhaOrigem].Cells[colunaOrigem].Style.BackColor = Color.Black;
            }
        }
    }
}
