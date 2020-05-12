using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Threading;

namespace SistemaCadastro
{


    public partial class Form1 : Form
    {
        public class produto : IComparable<produto>
        {
            
        }

        // list
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void mostrar()
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
      
        }
        void salvar()
        {
            BinaryWriter arq = new BinaryWriter(File.Open("nomes.txt", FileMode.Create));
            arq.Write(lista.Count());
            foreach (produto b in lista)
            {
                arq.Write(b.Descricao);
                arq.Write(b.Local);
                arq.Write(b.Qtd);
            }
            arq.Close();
            MessageBox.Show("Dados Salvos com Sucesso", "Mensagem");
        }
        void carregar()
        {

            BinaryReader arq = new BinaryReader(
                File.Open("nomes.txt", FileMode.Open));
            if (File.Exists("nomes.txt"))
            {
                int qtd = arq.ReadInt32();
                for (int i = 0; i < qtd; i++)
                {
                    produto b = new produto();
                    b.Descricao = arq.ReadString();
                    b.Local = arq.ReadString();
                    b.Qtd = arq.ReadInt32();
                    lista.Add(b);
                }// fim for
                arq.Close();
                mostrar();
            }// fim if 
            else
                MessageBox.Show("Arquivo não encontrado", "Erro");
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            carregar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            salvar();
        }


        private void btnAtender_Click(object sender, EventArgs e)
        {
            
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
        }



        private void btnAddEstoque_Click(object sender, EventArgs e)
        {

        }

        private void gvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnRemoveEstoque_Click(object sender, EventArgs e)
        {

        }
    }
}
