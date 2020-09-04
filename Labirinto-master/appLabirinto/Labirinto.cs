using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Collections;

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
            dgv.Columns.Clear();

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
                    switch (matriz[i, j])
                    {
                        case '#': dgv.Rows[i].Cells[j].Style.BackColor = Color.Yellow; break;
                        case 'I': dgv.Rows[i].Cells[j].Style.BackColor = Color.Red; break;
                        case 'S': dgv.Rows[i].Cells[j].Style.BackColor = Color.Green; break;
                    }
        }

        public void ExibirDataGridView2(DataGridView dgv, LinkedList<ArrayList> l)
        {
            dgv.Columns.Clear();

            dgv.RowCount = l.Count;
            dgv.ColumnCount = 100;

            for (int coluna = 0; coluna < dgv.ColumnCount; coluna++)
            {
                dgv.Columns[coluna].HeaderText = coluna.ToString();
                dgv.Columns[coluna].Width = 50;
            }

            for (int linha = 0; linha < dgv.RowCount; linha++)
                dgv.Rows[linha].HeaderCell.Value = linha.ToString();

            int i = 0;
            foreach (var s in l)
            {
                int j = 0;
                foreach (var r in s)
                {
                    dgv.Rows[i].Cells[j].Value = ((int[])r)[0]+" : "+((int[])r)[1];
                    j++;
                }
                i++;
            }
        }

        public void ExibirCaminho(ArrayList a, DataGridView dgv) 
        {
            ExibirDataGriedView(dgv);
            try
            {
                foreach (var i in a)
                {
                    dgv.Rows[((int[])i)[0]].Cells[((int[])i)[1]].Style.BackColor = Color.Black;
                }
            }
            catch (Exception e) { }
        }

        public LinkedList<ArrayList> findpaths(DataGridView dgv)
        {
            LinkedList<ArrayList> ret = new LinkedList<ArrayList>();
            Queue<ArrayList> q = new Queue<ArrayList>();

            ArrayList path = new ArrayList();
            path.Add(new int[2] {1,1});
            q.Enqueue(path);

            //matriz[1,1] = 'O';

            while (q.Count != 0)
            {
                path = q.Dequeue();

                int[] last = (int[]) path[path.Count - 1];

                if (matriz[last[0], last[1]] == 'S')
                    ret.AddLast(path);

                for (int i = 0; i <= 7; i++)
                {
                    var mov = new Movimento(i, last[0], last[1]);
                    if (matriz[mov.LinhaDestino, mov.ColunaDestino] != '#' && matriz[mov.LinhaDestino, mov.ColunaDestino] != 'O')
                    {
                        matriz[last[0], last[1]] = 'O';
                        var newPath = new ArrayList(path);
                        newPath.Add(new int[2]{ mov.LinhaDestino, mov.ColunaDestino});
                        q.Enqueue(newPath);
                    }
                }
            }
            return ret;
        }
    }
}