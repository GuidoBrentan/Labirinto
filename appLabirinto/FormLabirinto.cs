using System.Windows.Forms;

namespace appLabirinto
{
    public partial class appLabirinto : Form
    {
        Labirinto labirinto;
        public appLabirinto()
        {
            InitializeComponent();
        }

        private void btnAbrir_Click(object sender, System.EventArgs e)
        {
            if(openFIle.ShowDialog() == DialogResult.OK)
            {
                labirinto = new Labirinto(openFIle.FileName);

                labirinto.ExibirDataGriedView(dgvLabirinto);
            }
        }

        private void btnEncontrar_Click(object sender, System.EventArgs e)
        {
            if(labirinto != null)
            {
                var movimentos = labirinto.EncontrarCaminhosDataGridView(dgvLabirinto);

                if(movimentos.EstaVazia)
                    MessageBox.Show("Não há caminho");
                else
                    MessageBox.Show("Caminho localizado");
            }
            else
                MessageBox.Show("Primeiro selecione um arquivo com o labirinto");
        }
    }
}
