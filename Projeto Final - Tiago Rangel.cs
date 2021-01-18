using System;
using System.Collections.Generic;

namespace Projeto_Final
{
    class Program
    {
        public abstract class CardsYugioh
        {
            public string nome;
            public string descricao;

            public CardsYugioh(string nome, string descricao)
            {
                this.nome = nome;
                this.descricao = descricao;
            }
        }
        public enum typeMonster
        {
            Aqua, Beast, BeastWarrior, Cyberse, Dinosaur, DivineBeast, Dragon, Fairy, Fiend, Fish, Insect, Machine, Plant, Psychic, Pyro, Reptile, Rock, SeaSerpent, Spellcaster, Thunder, Warrior, WingedBeast, Wyrm, Zombie
        }
        public enum attributtesMonster
        {
            Dark, Divine, Earth, Fire, Light, Water, Wind
        }
        public enum typeMagic
        {
            RitualSpells,
            ContinuousSpells,
            EquipSpells,
        }
        public enum typeTrap
        {
            NormalTraps, ContinuousTraps, CounterTraps
        }
        public enum starsMonster
        {
            one,
            two,
            three,
            four,
            five,
            six,
            seven,
            eight,
            nine,
            ten,
            eleven,
            Twelve

        }

        class Monster : CardsYugioh 
        {
            public int attack { get; set; }
            public int defense { get; set; }
            public attributtesMonster attributtes;
            public typeMonster type;
            public bool effect;
            public starsMonster stars;

            public Monster(int attack, int defense, string nome, string descricao, attributtesMonster attributtes, typeMonster type, bool effect, starsMonster stars) : base(nome, descricao)
            {
                this.attack = attack;
                this.defense = defense;
                this.attributtes = attributtes;
                this.type = type;
                this.effect = effect;
                this.stars = stars;
            }

            public void CompareAttack(object obj)
            {
                Monster monster = (Monster)(obj);

                if (this.attack < monster.attack)
                    Console.WriteLine(this.nome + " tem menor ataque do que " + monster.nome);
                else if (this.attack > monster.attack)
                    Console.WriteLine(this.nome + " tem maior ataque do que " + monster.nome); 
                else
                    Console.WriteLine("As cartas " + this.nome + " " + monster.nome + " têm o ataque igual"); 
            }

            public void CompareDefende(object obj)
            {
                Monster monster = (Monster)(obj);

                if (this.defense < monster.defense)
                    Console.WriteLine(this.nome + " nao consegue atacar " + monster.nome);
                else if (this.defense > monster.defense)
                    Console.WriteLine(this.nome + " tem maior defesa do que " + monster.nome);
                else
                    Console.WriteLine("As cartas " + this.nome + " " + monster.nome + " têm a defesa igual"); 
            }
            public void Ataca (object obj)
            {
                Monster monster = (Monster)(obj);

                if (this.attack < monster.defense)
                    Console.WriteLine(this.nome + " não destruir a carta " + monster.nome);
                else if (this.attack > monster.defense)
                    Console.WriteLine(this.nome + " destruiu a carta " + monster.nome);
                else
                    Console.WriteLine("As cartas " +this.nome +" "+  monster.nome + " foram destruidas");
            }
        }

        class Magic : CardsYugioh
        {
            public typeMagic type;
            public Magic(typeMagic type, string nome, string descricao) : base(nome, descricao)
            {
                this.type = type;
            }
        }

        class Trap : CardsYugioh
        {
            public typeTrap type;
            public Trap(string nome, string descricao, typeTrap type) : base(nome, descricao)
            {
                this.type = type;
            }
        }

        static void Main(string[] args)
        {
            Monster Dragao = new Monster(2000, 2000, "Dragon", "qq", attributtesMonster.Light, typeMonster.Dragon, true, starsMonster.seven);
            Monster Fantasma = new Monster(3000, 2000, "Fantasma", "qq", attributtesMonster.Light, typeMonster.Dragon, true, starsMonster.seven);

            Dragao.CompareAttack(Fantasma); //comparar ataque
            Dragao.CompareDefende(Fantasma); //comparar defesa
            Dragao.Ataca(Fantasma); //ver se é destruida


            /////////////calcular a media de ataques num baralho/////////////;
            float somaAtaques = 0;
            float mediasomaAtaques = 0;

            List<Monster> BaralhoMonster = new List<Monster>();

            BaralhoMonster.Add(new Monster(3000, 2000, "Dragon", "qq", attributtesMonster.Light, typeMonster.Dragon, true, starsMonster.seven));
            BaralhoMonster.Add(new Monster(3000, 2000, "Dragon", "qq", attributtesMonster.Light, typeMonster.Dragon, true, starsMonster.seven));

            for (int i = 0; i < BaralhoMonster.Count; i++) 
            {
                somaAtaques += BaralhoMonster[i].attack;
                mediasomaAtaques = somaAtaques / BaralhoMonster.Count;
            }
            Console.WriteLine("Média de Ataques do baralho: " + mediasomaAtaques);  //soma de todos os ataque médias

            /////////////calcular a media de defesas num baralho/////////////;
            float somaDefesas = 0;
            float mediasomaDefesas = 0;

            for (int i = 0; i < BaralhoMonster.Count; i++)
            {
                somaDefesas += BaralhoMonster[i].defense;
                mediasomaDefesas = somaDefesas / BaralhoMonster.Count;
            }

            Console.WriteLine("Média de defesas do baralho: " + mediasomaDefesas);

            ///////////////calcular a quantidade de cada tipo de cartas magia/////////////

            int cartasContinuosSpells = 0;
            int cartasRitualSpells = 0;
            int cartasEquipSpells = 0;

            List<Magic> BaralhoMagia = new List<Magic>();

            BaralhoMagia.Add(new Magic(typeMagic.ContinuousSpells, "ContinuosSpell", "qq"));
            BaralhoMagia.Add(new Magic(typeMagic.RitualSpells, "RitualSpell", "qq"));
            BaralhoMagia.Add(new Magic(typeMagic.EquipSpells, "EquipSpell", "qq"));
            
            for(int i = 0; i < BaralhoMagia.Count; i++)
            {
                if (BaralhoMagia[i].type.ToString() == "ContinuousSpells")
                {
                    cartasContinuosSpells += 1;
                }
                else if (BaralhoMagia[i].type.ToString() == "RitualSpells")
                {
                    cartasRitualSpells += 1;
                }
                else if (BaralhoMagia[i].type.ToString() == "EquipSpells")
                {
                    cartasEquipSpells += 1;
                }
            }

            Console.WriteLine("Cartas do tipo Magia repetidas \nContinuos Spells: " + cartasContinuosSpells + "\nRitual Spells: " + cartasRitualSpells + "\nEquip Spells: " + cartasEquipSpells);

            ///////////////calcular a quantidade de cada tipo de cartas trap/////////////

            int cartasContinuosTraps = 0;
            int cartasCounterTraps = 0;
            int cartasNormalTraps = 0;

            List<Trap> BaralhoTrap = new List<Trap>();

            BaralhoTrap.Add(new Trap("ContinuosTraps", "qq", typeTrap.ContinuousTraps));
            BaralhoTrap.Add(new Trap("CounterTraps", "qq", typeTrap.CounterTraps));
            BaralhoTrap.Add(new Trap("NormalTraps", "qq", typeTrap.NormalTraps));

            for (int i = 0; i < BaralhoTrap.Count; i++)
            {
                if (BaralhoTrap[i].type.ToString() == "ContinuousTraps")
                {
                    cartasContinuosTraps += 1;
                }
                else if (BaralhoTrap[i].type.ToString() == "CounterTraps")
                {
                    cartasCounterTraps += 1;
                }
                else if (BaralhoTrap[i].type.ToString() == "NormalTraps")
                {
                    cartasNormalTraps += 1;
                }
            }

            Console.WriteLine("Cartas do tipo Trap repetidas \nContinuos Traps: " + cartasContinuosTraps + "\nCounter Traps: " + cartasCounterTraps + "\nNormal Traps: " + cartasNormalTraps);












        }
    }
}

