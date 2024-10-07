using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Cadastro
{
    public partial class Frm_Resultado : Form
    {
        public Frm_Resultado()
        {
            InitializeComponent();
        }

        private void Lbl_Resultado_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Voltar_Click(object sender, EventArgs e)
        {
            Frm_Projeto_Cadastro cadastro = new Frm_Projeto_Cadastro(); //Instanciando o objeto Cadastro
            cadastro.Show(); //Abrindo a Tela 1
            Hide(); //Ocultando a tela 2
        }

        private void Frm_Resultado_Load(object sender, EventArgs e)
        {

        }

        private void Frm_Resultado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //Fechar o Aplicativo
        }
    }
}
