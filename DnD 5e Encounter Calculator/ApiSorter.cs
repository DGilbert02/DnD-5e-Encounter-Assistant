using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DnD_5e_Encounter_Calculator.PartyList;
using static DnD_5e_Encounter_Calculator.CRCalculator;
using System.Net;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.AvalonDock.Layout;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Xceed.Wpf.Toolkit.Media.Animation;
using System.Net.Cache;
using System.Data;
using Newtonsoft.Json.Linq;
using System.Threading;
using static System.Formats.Asn1.AsnWriter;
using System.Timers;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace DnD_5e_Encounter_Calculator
{
    internal class ApiSorter
    {
        internal ApiSorter(int PartyCR)
        {// all Monsters to be made into Console.Writelines
            if (PartyCR == 0) 
            {
                //List<CR1Monster> cr1 = new()
                //{
                //    new CR1Monster() {Name = "Awakened Shrub" },
                //    new CR1Monster() { "Baboon" },
                //    new CR1Monster() { "Badger" },
                //    new CR1Monster() { "Bat" },
                //    new CR1Monster() { "Cat" },
                //    new CR1Monster() { "Commoner" },
                //    new CR1Monster() { "Crab" },
                //    new CR1Monster() { "Deer" },
                //    new CR1Monster() { "Eagle" },
                //    new CR1Monster() { "Frog" },
                //    new CR1Monster() { "Giant Fire Beetle" },
                //    new CR1Monster() { "Goat" },
                //    new CR1Monster() { "Hawk" },
                //    new CR1Monster() { "Homunculus" },
                //    new CR1Monster() { "Hyena" },
                //    new CR1Monster() { "Jackal" },
                //    new CR1Monster() { "Lemure" },
                //    new CR1Monster() { "Lizard" },
                //    new CR1Monster() { "Octopus" },
                //    new CR1Monster() { "Owl" },
                //    new CR1Monster() { "Quipper" },
                //    new CR1Monster() { "Rat" },
                //    new CR1Monster() { "Raven" },
                //    new CR1Monster() { "Scorpion" },
                //    new CR1Monster() { "Sea-Horse" },
                //    new CR1Monster() { "Shrieker" },
                //    new CR1Monster() { "Spider" },
                //    new CR1Monster() { "Vulture" },
                //    new CR1Monster() { "Weasel" }
                //}

            }
            if (PartyCR >= 0.1 && PartyCR <= 0.125)
            {
                //Bandit
                //Blood Hawk
                //Camel
                //Cultist
                //Diseased Giant Rat
                //Flying Snake
                //Giant Crab
                //Giant Rat
                //Giant Weasel
                //Guard
                //Kobold
                //Mastiff
                //Merfolk
                //Mule
                //Noble
                //Poisonous Snake
                //Pony
                //Stirge
                //Tribal Warrior
                //Twig Blight
                 }
            if (PartyCR >= 0.126 && PartyCR <= 0.25) 
            {
                Acolyte
                Axe Beak
                Blink Dog
                Boar
                Constrictor Snake
                Draft Horse
                Dretch
                Drow
                Elk
                Flying Sword
                Giant Badger
                Giant Bat
                Giant Centipede
                Giant Frog
                Giant Lizard
                Giant Owl
                Giant Piosonous Snake
                Giant Wolf Spider
                Goblin
                Grinlock
                Panther
                Pseudodragon
                Pteranodon
                Riding Horse
                Skeleton
                Sprite
                Steam Mephit
                Swarm Of Bats
                Swarm Of Rats
                Swarm Of Ravens
                Violet Fungus
                Wolf
                Zombie
            }
            if (PartyCR >= .26 && PartyCR <= .50)
            {
                Crocodile
                Darkmantle
                Deep Gnome
                Dust Mephit
                Giant Goat
                Giant Sea Horse
                Giant Wasp
                Gnoll
                Gray Ooze
                Hobgoblin
                Ice Mephit
                Lizardfolk
                Magma Mephit
                Magmin
                Orc
                Reef Shark
                Rust Monster
                Sahuagin
                Satyr
                Scout
                Shadow
                Swarm Of Insects
                Swarm Of Beetles
                Swarm Of Centipedes
                Swarm Of Spiders
                Swarm Of Wasps
                Thug
                Warhorse Skeleton
                Worg

            }
            if (PartyCR >= .51 && PartyCR <= 1)
            {
                Animated Armor
                Brass Dragon Wyrmling
                Brown Bear
                Bugbear
                Copper Dragon Wyrmling
                Death Dog
                Dire Wolf
                Dryad
                Duergar
                Ghoul
                Giant Eagle
                Giant Hyena
                Giant Octopus
                Giant Spider
                Giant Toad
                Giant Vulture
                Harpy
                Hippogriff
                Imp
                Lion
                Quasit
                Specter
                Spy
                Swarm Of Quippers
                Tiger
            }
            if (PartyCR >= 1.1 && PartyCR <= 2) 
            {
                Allosaurus
                Ankheg
                Awakened Tree
                Azer
                Bandit Captain
                Berserker
                Black Dragon Wyrmling
                Centaur
                Cult Fanatic
                Druid
                Ettercap
                Gargoyle
                Gelatinous Cube
                Ghast
                Giant Boar
                Giant Constrictor Snake
                Giant Elk
                Gibbering Mouther
                Green Dragon Wyrmling
                Grick
                Griffon
                Hunter Shark
                Merrow
                Mimic
                Minotaur Skeleton
                Nothic
                Ochre Jelly
                Ogre Zombie
                Pegasus
                Plesiosaurus
                Polar Bear
                Priest
                Rhinoceros
                Rug Of Smothering
                Saber Toothed Tiger
                Sea Hag
                Silver Dragon Wyrmling
                Swarm Of Poisonous Snakes
                Wererat
                White Dragon Wyrmling
                Will O Wisp
            }
            if (PartyCR >= 2.1 && PartyCR <= 3) 
            {
                Ankylosaurus
                Basilisk
                Bearded Devil
                Blue Dragon Wyrmling
                Doppelganger
                Giant Scorpion
                Gold Dragon Wyrmling
                Green Hag
                Hell Hound
                Killer Whale
                Knight
                Manticore
                Minotaur
                Mummy
                Nightmare
                Owlbear
                Phase Spider
                Spectator
                Veteran
                Werewolf
                Wight
                Winter Wolf
                Yeti
            }
            if (PartyCR >= 3.1 && PartyCR <= 4) 
            {
                Banshee
                Black Pudding
                Chuul
                Couatl
                Elephant
                Ettin
                Flameskull
                Ghost
                Incubus
                Lamia
                Red Dragon Wyrmling
                Succubus
                Wereboar
                Weretiger
            }
            if (PartyCR >= 4.1 && PartyCR <= 5)
            {
                Air - Elemental
                Barbed Devil
                Bulette
                Dust Devil
                Earth Elemental
                Fire Elemental
                Flesh Golem
                Giant Crocodile
                Giant Shark
                Gladiator
                Gorgon
                Half - Red Dragon Veteran
                Hill Giant
                Night Hag
                Otyugh
                Roper
                Salamander
                Shambling Mound
                Triceratops
                Troll
                Unicorn
                Vampire Spawn
                Water Elemental
                Werebear
                Wraith
                Xorn
            }
            if (PartyCR >= 5.1 && PartyCR <= 6) 
            {
                Chimera
                Cyclops
                Drider
                Invisible Stalker
                Mage
                Mammoth
                Medusa
                Vrock
                Wyvern
                Young Brass Dragon
                Young White Dragon
            }
            if (PartyCR >= 6.1 && PartyCR <= 7) 
            { 
                Giant Ape
                Oni
                Sheild Guardian
                Stone Giant
                Young Black Dragon
            }
            if (PartyCR >= 7.1 && PartyCR <= 8) 
            {
                Assassin
                Chain Devil
                Cloaker
                Frost Giant
                Hezrou
                Hydra
                Spirit Naga
                Tyannosaurus Rex
                Young Bronze Dragon
                Young Green Dragon
            }
            if (PartyCR >= 8.1 && PartyCR <= 9) 
            { 
                Bone Devil
                Clay Golem
                Cloud Giant
                Fire Giant
                Glabrezu
                Treant
                Young Blue Dragon
                Young Sliver Dragon
            }
            if (PartyCR >= 9.1 && PartyCR <= 10)
            {
                Aboleth
                Deva
                Guardian Naga
                Stone Golem
                Young Gold Dragon
                Young Red Dragon
            }
            if (PartyCR >= 10.1 && PartyCR <= 11) 
            {
                Behir
                Djinni
                Efreeti
                Gynosphinx
                Horned Devil
                Remorhaz
                Roc    
            }
            if (PartyCR >= 11.1 && PartyCR <= 12) 
            {
                Archmage
                Erinyes 
            }
            if (PartyCR >= 12.1 && PartyCR <= 13)
            {
                Adult Brass Dragon
                Adult White Dragon
                Nalfeshnee
                Rakshasa
                Storm Giant
                Vampire
            }
            if (PartyCR >= 13.1 && PartyCR <= 14)
            {
                Adult Black Dragon
                Adult Copper Dragon
                Ice Devil
                    }
            if (PartyCR >= 14.1 && PartyCR <= 15)
            {
                Adult Bronze Dragon
                Adult Green Dragon
                Mummy Lord
                Purple Worm
            }
            if (PartyCR >= 15.1 && PartyCR <= 16)
            {
                Adult Blue Dragon
                Adult Silver Dragon
                Iron Golem
                Marilith
                Planetar
                    }
            if (PartyCR >= 16.1 && PartyCR <= 17.5)
            {
                Adult Gold Dragon
                Adult Red Dragon
                Androsphinx
                Dragon Turtle
                    }
            if (PartyCR >= 17.6 && PartyCR <= 19) 
            { 
                Balor
            }
            if (PartyCR >= 19.1 && PartyCR <= 20)
            {
                Ancient Brass Dragon
                ancient White Dragon
                Pit Fiend
            }
            if (PartyCR >= 20.1 && PartyCR <= 30)
            {
                Ancient Black Dragon
                Ancient Copper Dragon
                Lich
                Solar
                Ancient Bronze Dragon
                Ancient Green Dragon
                Ancient Blue Dragon
                Ancient Silver Dragon
                Kraken
                Ancient Gold Dragon
                Ancient Red Dragon
                Tarrasque
            }
            else
            {
                Console.WriteLine("There are no creatures capable of standing up to your party!");
            }

        }

    }
}
