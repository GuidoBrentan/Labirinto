using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace appLabirinto
{
    public partial class appLabirinto : Form
    {
        Labirinto labirinto;
        LinkedList<ArrayList> rotas = new LinkedList<ArrayList>();
        public appLabirinto()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, System.EventArgs e)
        {
            if (openFIle.ShowDialog() == DialogResult.OK)
            {
                labirinto = new Labirinto(openFIle.FileName);

                labirinto.ExibirDataGriedView(dgvLabirinto);
            }
        }

        private void btnEncontrar_Click(object sender, System.EventArgs e)
        {
            if (labirinto != null)
            {
                rotas = labirinto.findpaths(dgvLabirinto);

                if (rotas.First == null)
                    MessageBox.Show("Não há caminho");
                else
                {
                    labirinto.ExibirDataGridView2(dataGridView2, rotas);
                    MessageBox.Show("Caminhos enocntrados");
                }
            }
            else
                MessageBox.Show("Primeiro selecione um arquivo com o labirinto");
        }

        private void dataGridView2_SelectionChanged(object sender, System.EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
                labirinto.ExibirCaminho(rotas.ElementAt(dataGridView2.SelectedRows[0].Index), dgvLabirinto);
        }
    }
}
