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
    public partial class Frm_Projeto_Cadastro : Form
    {
        public Frm_Projeto_Cadastro()
        {
            InitializeComponent();
            BackgroundImage = null; //Fundo Desativado
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.tema_2; //Mudar para o Tema 2
            
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Controls.Clear(); //Limpar todos os Textos
            InitializeComponent(); //Não apagar os objetos na tela
            Grp_Dados.Enabled = true; //Ativando os Dados pessoais
            Grp_Tema.Enabled = true; //Ativando os Temas
            Btn_Desativar.Enabled = true; //Ativando o Desativar
            Btn_Limpar.Enabled = true; //Ativando o Limpar
            Btn_Ativar.Enabled = false; //Desativando o Ativar
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.tema_3; //Mudar para o Tema 3
            
        }

        private void Btn_Ativar_Click(object sender, EventArgs e)
        {
            Grp_Dados.Enabled = true; //Ativando os Dados pessoais
            Grp_Tema.Enabled = true; //Ativando os Temas
            Btn_Desativar.Enabled = true; //Ativando o Desativar
            Btn_Limpar.Enabled = true; //Ativando o Limpar
            Btn_Ativar.Enabled = false; //Desativando o Ativar
            Rad_Padrao.Checked = true;


        }

        private void Btn_Desativar_Click(object sender, EventArgs e)
        {
            Controls.Clear(); //Limpar todos os Textos
            InitializeComponent(); //Não apagar os objetos na tela
            Grp_Dados.Enabled = false; //Desativando os Dados pessoais
            Grp_Tema.Enabled = false; //Desativando os Temas
            Btn_Desativar.Enabled = false; //Desativando o Desativar
            Btn_Limpar.Enabled = false; //Desativando o Limpar
            Btn_Ativar.Enabled = true; //Ativando o Ativar
            BackgroundImage = null; //Desativando o Fundo
        }

        private void Rad_Padrao_CheckedChanged(object sender, EventArgs e)
        {
            BackgroundImage = Properties.Resources.padrao; //Mudar para o Tema padrão
        }

        private void Btn_Enviar_Nome_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Nome.Text; //Enviar o nome
        }

        private void Btn_Enviar_Sobrenome_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Sobrenome.Text; //Enviar o Sobrenome
        }

        private void Btn_Enviar_Idade_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Idade.Text; //Enviar a Idade
        }

        private void Btn_Enviar_Bairro_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Bairro.Text; //Enviar o Bairro
        }

        private void Btn_Enviar_Celular_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Celular.Text;
        }

        private void Btn_Enviar_Email_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Email.Text;
        }

        private void Btn_Confirmar_Dados_Click(object sender, EventArgs e)
        {
            Frm_Resultado resultado = new Frm_Resultado(); // Instanciando o Objeto Resultado
            resultado.Lbl_Resultado2.Text = Txt_Nome.Text + " " + Txt_Sobrenome.Text + "\n" + Txt_Idade.Text + "\n" + Txt_Bairro.Text + "\n" + Txt_Celular.Text + "\n" + Txt_Email.Text + "\n" + Txt_Gênero.Text; //Enviar todos os Dados
            resultado.Show(); // Abrindo a tela 2
            Hide(); // Ocultando a Tela 1
            resultado.StartPosition = FormStartPosition.CenterScreen;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Pc_Homem.Image = Properties.Resources.man;
            Pc_Mulher.Image = Properties.Resources.invisible_png;
            Pc_Outro.Image = Properties.Resources.invisible_png;
            Txt_Gênero.Text = Rad_Homem.Text;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            Pc_Mulher.Image = Properties.Resources.woman;
            Pc_Homem.Image = Properties.Resources.invisible_png;
            Pc_Outro.Image = Properties.Resources.invisible_png;
            Txt_Gênero.Text = Rad_Mulher.Text;
        }

        private void radioButton3_CheckedChanged_2(object sender, EventArgs e)
        {
            Pc_Outro.Image = Properties.Resources.outro;
            Pc_Homem.Image = Properties.Resources.invisible_png;
            Pc_Mulher.Image = Properties.Resources.invisible_png;
            Txt_Gênero.Text = Rad_Outro.Text;
        }

        private void Btn_Enviar_Genero_Click(object sender, EventArgs e)
        {
            Lbl_Resultado.Text = Txt_Gênero.Text;
        }

        private void Frm_Projeto_Cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
