using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_agenda
{
    public partial class FmCadastroPokemon : Form
    {

        public FmCadastroPokemon()
        {
            InitializeComponent();
        }

        // disponibilidade retorno nome (funções) a função serve para reaproveitar codigos, definindo uma função eu posso reutilizar o codigo
        private void fnLimpar()
        {
            txtNome.Clear();
            cbTipo.SelectedIndex = -1;
            numNivel.Value = 1;

            txtNome.Focus();

        }
        /* objetivo da aula: aprender a criar e utilizar objetos
         * mini game pokemon 
         * 1- montar meu time pokemon (6 pokemon) -> listas
         * 2- treinar esse meu time pokemon (a cada treinamento ele recebe 2 nivel)
         * 3- batalhar com esse pokemon de forma randonica
         * sistema vai sortear 1 a 6 pokemon (somente os 151 primeiros)
        */
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string nomePokemon = txtNome.Text; //textBox
            string tipoPokemon = cbTipo.Text; //comboBox
            int nivelPokemon = (int)numNivel.Value; //numericUpDown

            Pokemon poke = new Pokemon(nomePokemon, tipoPokemon, nivelPokemon);

            poke.fnDescricao();

            //MessageBox.Show($"o Pokémon {nomePokemon} do tipo {tipoPokemon} " +
            //    $"foi cadastrado com o nivel {nivelPokemon}");

            fnLimpar();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            fnLimpar();
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            // erica
            // luiz
            // fabio
            // leandro
            // natanael

            // variaveis primitivas
            //string aluno1 = "erica";
            //string aluno2 = "luiz";
            //string aluno3 = "ana";
            //string aluno4 = "kaio";
            //string aluno5 = "iori";

            //arrays

            string[] nomesAlunos = new string[5];

            nomesAlunos[0] = "erica";
            nomesAlunos[2] = "ana";
            nomesAlunos[3] = "kaio";

            // List <tipo da variavel>
            List<string> listaNomes = new List<string>();

            listaNomes.Add("Erica");
            listaNomes.Add("Ana");
            listaNomes.Add("kaio");
            listaNomes.Add("iori");
            listaNomes.Add("laysla");


            MessageBox.Show($"Valor da lista: {listaNomes[4]}");

            MessageBox.Show($"Valor da lista: {listaNomes.Count}");

        }
    }
}
