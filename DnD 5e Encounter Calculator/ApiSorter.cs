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
using static DnD_5e_Encounter_Calculator.CR0;

namespace DnD_5e_Encounter_Calculator
{
    internal class ApiSorter
    {
        
        string displayList = "";
        internal ApiSorter(int PartyCR,CR0 cr0)
        {// all Monsters to be made into lists by CR
            if (PartyCR == 0) 
            {
                string displayList = cr0.CR0Print();
            }
            else if (PartyCR >= 0.1 && PartyCR <= 0.125)
            {
                
            }
            else if (PartyCR >= 0.126 && PartyCR <= 0.25) 
            {
                //Acolyte
                //Axe Beak
                //Blink Dog
                //Boar
                //Constrictor Snake
                //Draft Horse
                //Dretch
                //Drow
                //Elk
                //Flying Sword
                //Giant Badger
                //Giant Bat
                //Giant Centipede
                //Giant Frog
                //Giant Lizard
                //Giant Owl
                //Giant Piosonous Snake
                //Giant Wolf Spider
                //Goblin
                //Grinlock
                //Panther
                //Pseudodragon
                //Pteranodon
                //Riding Horse
                //Skeleton
                //Sprite
                //Steam Mephit
                //Swarm Of Bats
                //Swarm Of Rats
                //Swarm Of Ravens
                //Violet Fungus
                //Wolf
                //Zombie
            }
            else if (PartyCR >= .26 && PartyCR <= .50)
            {
                //Crocodile
                //Darkmantle
                //Deep Gnome
                //Dust Mephit
                //Giant Goat
                //Giant Sea Horse
                //Giant Wasp
                //Gnoll
                //Gray Ooze
                //Hobgoblin
                //Ice Mephit
                //Lizardfolk
                //Magma Mephit
                //Magmin
                //Orc
                //Reef Shark
                //Rust Monster
                //Sahuagin
                //Satyr
                //Scout
                //Shadow
                //Swarm Of Insects
                //Swarm Of Beetles
                //Swarm Of Centipedes
                //Swarm Of Spiders
                //Swarm Of Wasps
                //Thug
                //Warhorse Skeleton
                //Worg

            }
            else if (PartyCR >= .51 && PartyCR <= 1)
            {
                //Animated Armor
                //Brass Dragon Wyrmling
                //Brown Bear
                //Bugbear
                //Copper Dragon Wyrmling
                //Death Dog
                //Dire Wolf
                //Dryad
                //Duergar
                //Ghoul
                //Giant Eagle
                //Giant Hyena
                //Giant Octopus
                //Giant Spider
                //Giant Toad
                //Giant Vulture
                //Harpy
                //Hippogriff
                //Imp
                //Lion
                //Quasit
                //Specter
                //Spy
                //Swarm Of Quippers
                //Tiger
            }
            else if (PartyCR >= 1.1 && PartyCR <= 2) 
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
            else if (PartyCR >= 2.1 && PartyCR <= 3) 
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
            else if (PartyCR >= 3.1 && PartyCR <= 4) 
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
            else if (PartyCR >= 4.1 && PartyCR <= 5)
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
            else if (PartyCR >= 5.1 && PartyCR <= 6) 
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
            else if (PartyCR >= 6.1 && PartyCR <= 7) 
            { 
                Giant Ape
                Oni
                Sheild Guardian
                Stone Giant
                Young Black Dragon
            }
            else if (PartyCR >= 7.1 && PartyCR <= 8) 
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
            else if (PartyCR >= 8.1 && PartyCR <= 9) 
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
            else if (PartyCR >= 9.1 && PartyCR <= 10)
            {
                Aboleth
                Deva
                Guardian Naga
                Stone Golem
                Young Gold Dragon
                Young Red Dragon
            }
            else if (PartyCR >= 10.1 && PartyCR <= 11) 
            {
                Behir
                Djinni
                Efreeti
                Gynosphinx
                Horned Devil
                Remorhaz
                Roc    
            }
            else if (PartyCR >= 11.1 && PartyCR <= 12) 
            {
                Archmage
                Erinyes 
            }
            else if (PartyCR >= 12.1 && PartyCR <= 13)
            {
                Adult Brass Dragon
                Adult White Dragon
                Nalfeshnee
                Rakshasa
                Storm Giant
                Vampire
            }
            else if (PartyCR >= 13.1 && PartyCR <= 14)
            {
                Adult Black Dragon
                Adult Copper Dragon
                Ice Devil
                    }
            else if (PartyCR >= 14.1 && PartyCR <= 15)
            {
                Adult Bronze Dragon
                Adult Green Dragon
                Mummy Lord
                Purple Worm
            }
            else if (PartyCR >= 15.1 && PartyCR <= 16)
            {
                Adult Blue Dragon
                Adult Silver Dragon
                Iron Golem
                Marilith
                Planetar
                    }
            else if (PartyCR >= 16.1 && PartyCR <= 17.5)
            {
                Adult Gold Dragon
                Adult Red Dragon
                Androsphinx
                Dragon Turtle
                    }
            else if (PartyCR >= 17.6 && PartyCR <= 19) 
            { 
                Balor
            }
            else if (PartyCR >= 19.1 && PartyCR <= 20)
            {
                Ancient Brass Dragon
                ancient White Dragon
                Pit Fiend
            }
            else if (PartyCR >= 20.1 && PartyCR <= 30)
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
