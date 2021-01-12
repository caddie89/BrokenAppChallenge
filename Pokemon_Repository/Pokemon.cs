using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Repository
{
    private enum PokemonType
    {
        Normal = 100,
        Grass,
        Fire,
        Water,
        Electric,
        Ice,
        Bug,
        Ground,
        Rock,
        Fighting,
        Psychic,
        Ghost,
        Dark,
        Fairy,
        Dragon,
        None
    }

    private class Pokemon
    {
        public string PokemonSpeciesName { get set; }
        public string PokemonNickName { get; set; }
        public i Level { get; set; }
        public PokemonType PokemonType { get; set; }
        public PokeonType? SecondaryType 
        public string MoveOne { get; set; }
        public  MoveTwo { get; set; }
        public string MoveThree { get; set; }
        public string MoveFour { get; set; }

        public Pokemon(string speciesName, string NickName, int level, PokemonType pokemonType, PokemonType secondaryType, string moveOne, string moveTwo, string moveThree, string moveFour)
        {
            //TeamPosition = teamPosition;
            PokemonSpeciesName = speciesName;
            PokemonNickName = nickName;
            Level = level;
            PokemonType = pokemonType;
            SecondaryType = secondaryType
            MoveOne = moveOne;
            MoveTwo = moveTwo;
        }
            MoveThree = moveTwo;
            MoveFour = moveFour;
    
}
