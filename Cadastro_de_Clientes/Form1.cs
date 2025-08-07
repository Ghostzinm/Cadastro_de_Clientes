using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro_de_Clientes
{
    public partial class cadastro : Form
    {
        public cadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            string nome = textBoxNome.Text;
            string email = textBoxEmail.Text;
            string sobrenome = textBoxSobrenome.Text;
            int idade = int.Parse(textBoxIdade.Text);
            string Infos = $"Nome: {nome}\nSobrenome: {sobrenome}\nEmail: {email}\nIdade: {idade}";

            InfosTxt.Text = Infos;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void infos_Click(object sender, EventArgs e)
        {
            
        }
    }
}
