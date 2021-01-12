using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Repository
{
    private class PokemonRepository
    {
        List<Pokemon> _pokemonTeam = new List<Pokemon>();
    }

        //add to list (limit pokemon to 6)
        public  AddPokemonToTeam(Pokemon pokemon)
        {
            _pokemonTeam.Add(new Pokemon);
        }
        //get list
        public List<Pokemon> GetPokemonTeam()
        {

        }
        //get one pokemon
        public Pokemon GetPokemonByTeamPosition(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            return pokemon;
        }
        //update pokemon
        public void UpdatePokemonByTeamPosition(int teamPosition, Pokemon updates)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            pokemon.PokemonSpeciesName = updates.PokemonSpeciesName;
            pokemon.PokemonNickName = updates.PokemonNickName;
            pokemon.level = updates.Level
            pokemon.PokemonType = updates.PokemonType;
            pokemon.SecondaryType = updates.SecondaryType;
            pokemon.MoveOne = updates.MoveOne
            pokemon.Movetwo = updates.MoveTwo;
            pokemon.MoveThree = updates.MoveThree;
            pokemon.MoveFour = updates.MoveFour
        }

        public void UpdatePokemonByNickName(string nickName, Pokemon newPokemon)
        {
            foreach(Pokemon p in pokemonList)
            {
                if(nickName == p.PokemonNickName)
                {
                    p = new Pokemon;
                }
            }
        }

        //remove pokemon
        public void RemovePokemonFromTeam(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            _pokemonTeam.Dequeue(pokemon);
        }
}
