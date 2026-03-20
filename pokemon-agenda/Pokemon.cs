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

        // Criação da função de inicialização padrão do meu objeto
        public Pokemon(string nomePokemon, string tipoPokemon, int nivelPokemon)
        {
            //Nome = "Pikachu";
            //Tipo = "Elétrico";
            //Nivel = 5;
            Nome = nomePokemon;
            Tipo = tipoPokemon;
            Nivel = nivelPokemon;
            Vida = 100;
            Dano = 20;
        }

        // public posso usar da função em qualquer espaço do meu projeto
        // private posso usar a função somente no meu arquivo original
       public void fnDescricao()
        {
            MessageBox.Show($"pokemon: {Nome}, Tipo: {Tipo}, " +
                $"Nivel: {Nivel}, Vida: {Vida}, Dano: {Dano}");
        }

    }
}
