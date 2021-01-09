using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Projeto_Final
{
    class Program
    {
        public abstract class CartasYugioh
        {
            protected string nome;
            protected string descricao;

            public CartasYugioh(string nome, string descricao)
            {
                this.nome = nome;
                this.descricao = descricao;
            }
        }

        public enum typeM
        {
            Aqua, Beast, BeastWarrior, Cyberse, Dinosaur, DivineBeast, Dragon, Fairy, Fiend, Fish, Insect, Machine, Plant, Psychic, Pyro, Reptile, Rock, SeaSerpent, Spellcaster, Thunder, Warrior, WingedBeast, Wyrm, Zombie
        }
        public enum attributtesM
        {
            Dark, Divine, Earth, Fire, Light, Water, Wind
        }

        class Monster: CartasYugioh
        {
            protected int attack;
            protected int defense;
            public Monster (int attack, int defense,  string nome, string descricao):base(nome, descricao)
            {
                this.attack = attack;
                this.defense = defense;
                this.nome = nome;
                this.descricao = descricao;
            }
        }

        class Magia: CartasYugioh
        {

            public Magia(string nome, string descricao) :base(nome, descricao)
            {

            }
        }

        class Armadilha: CartasYugioh
        {
            public Armadilha(string nome, string descricao) : base(nome, descricao)
            {

            }
        }

        static void decksort()
        {

        }

        static void Main(string[] args)
        {
            Monster Dragon = new Monster(3000,2000, "Dragon", "qq");
        }
    }
}
