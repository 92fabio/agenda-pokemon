using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokemon_agenda
{
    internal class Pokemon
    {
        // nome do pokemon
        // tipo do pokemon
        // nivel do pokemon
        // vida do pokemon
        // dano do pokemon
        string Nome;
        string Tipo;
        int Nivel;
        int Vida;
        int Dano;

        // criação de função de inicialização padrão do meu objto 

        public Pokemon(string nomepokemon, string tipopokemon, int nivelpokemon) 
        {
            //Nome = "pikachu";
            //Tipo = "eletrico";
            //Nivel = 5;
            Nome = nomepokemon;
            Tipo = tipopokemon;
            Nivel = nivelpokemon;
            Vida = 100;
            Dano = 20;
        }

        // public posso usar da função em qualquer espaço de um porjeto
        // private posso usar funções somente no meu arquivo original

        public void fnDescricao()
        {
            MessageBox.Show($"pokemon: {Nome}, Tipo: {Tipo}, " +
                $"Nivel: {Nivel}, Vida: {Vida}, Dano: {Dano}");
        }

        // nome do pokemon
        // tipo do pokemon
        // nivel do pokemon
        // vida do pokemon
        // dano do pokemon


    }
}
