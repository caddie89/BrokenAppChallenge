using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Repository
{
    public class PokemonRepository
    {
        private List<Pokemon> _pokemonTeam = new List<Pokemon>();

        //Add Pokemon to List (limit 6)
        public void AddPokemonToTeam(Pokemon pokemon)
        {
            _pokemonTeam.Add(pokemon);
        }

        //Get List
        public List<Pokemon> GetPokemonTeam()
        {
            return _pokemonTeam;
        }

        //Get One Pokemon
        public Pokemon GetPokemonByTeamPosition(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            return pokemon;
        }

        //Update Pokemon By Team Position
        public bool UpdatePokemonByTeamPosition(int teamPosition, Pokemon updates)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];

            if (pokemon != null)
            {
                pokemon.PokemonSpeciesName = updates.PokemonSpeciesName;
                pokemon.PokemonNickName = updates.PokemonNickName;
                pokemon.Level = updates.Level;
                pokemon.PokemonType = updates.PokemonType;
                pokemon.SecondaryType = updates.SecondaryType;
                pokemon.MoveOne = updates.MoveOne;
                pokemon.MoveTwo = updates.MoveTwo;
                pokemon.MoveThree = updates.MoveThree;
                pokemon.MoveFour = updates.MoveFour;

                return true;
            }
            else
            {
                return false;
            }
        }

        //Get Pokemon By Nickname
        public Pokemon GetPokemonByNickname(string nickName)
        {
            foreach (Pokemon pokemon in _pokemonTeam)
            {
                if (pokemon.PokemonNickName == nickName)
                {
                    return pokemon;
                }
            }
            return null;
        }

        //remove pokemon
        public bool RemovePokemonFromTeam(int teamPosition)
        {
            Pokemon pokemon = _pokemonTeam[teamPosition - 1];
            
            if (_pokemonTeam.Remove(pokemon))
            {
                return true;
            }
            return false;
        }

        ////Update Pokemon By Nickname
        //public void UpdatePokemonByNickName(string nickName, Pokemon newPokemon)
        //{
        //    foreach (Pokemon p in pokemonList)
        //    {
        //        if (nickName == p.PokemonNickName)
        //        {
        //            p = new Pokemon;
        //        }
        //    }
        //}

    }
}
