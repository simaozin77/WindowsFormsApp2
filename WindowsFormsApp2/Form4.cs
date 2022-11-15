using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
             
            //verificar se os campos estao vazios
            if(textBox1.Text=="" && textBox2.Text=="")
            {
                MessageBox.Show("Digite o seu login e a senha", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //vereficar se o login está vazio
            if (textBox1.Text == "")
            {
                MessageBox.Show("Digite o seu login de utilizador", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;


            }
            //Verificar se a senha está vazia
            if(textBox2.Text == "")
            {
                MessageBox.Show("Digite a sua senha", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //validar os dados do utilizador por hard-coded
            if (textBox1.Text == "Rudi" && textBox2.Text == "super")
            {  
                MessageBox.Show("Autenticação com sucesso", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                //encerrar este formulario
                this.Close();
            }
            else
            {
                //imformar que autenticação falhou
                
                MessageBox.Show("o seu login e sua password não são válidos", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //limpar tudo
            textBox1.ResetText();
            textBox2.Clear();

        }
    }
}
