﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitanBot.Commands;

namespace TT2Bot
{
    public static partial class TT2Localisation
    {
        public static partial class Game
        {
            public static class Equipment
            {
                private const string BASE_PATH = Game.BASE_PATH + "EQUIPMENT_";
                
                public const string UNABLE_DOWNLOAD = BASE_PATH + nameof(UNABLE_DOWNLOAD);
                public const string MULTIPLE_MATCHES = BASE_PATH + nameof(MULTIPLE_MATCHES);
                public static LocalisedString GetName(string equipmentName)
                    => new LocalisedString(BASE_PATH + equipmentName.ToUpper());
                public static LocalisedString GetAbbreviation(string equipmentName)
                    => new LocalisedString(BASE_PATH + "ABBREV_" + equipmentName.ToUpper());

                public static IReadOnlyDictionary<string, string> Defaults { get; }
                    = new Dictionary<string, string>
                    {
                        { UNABLE_DOWNLOAD, "I could not download any equipment data. Please try again later." },
                        { MULTIPLE_MATCHES, "There were more than 1 equipment that matched `{0}`" },
                        { GetName("Aura_Bats").Key, "Bat Cave" },                        { GetAbbreviation("Aura_Bats").Key, "" },
                        { GetName("Aura_Bird").Key, "Birds" },                           { GetAbbreviation("Aura_Bird").Key, "" },
                        { GetName("Aura_BlackEnergy").Key, "Dark Energy" },              { GetAbbreviation("Aura_BlackEnergy").Key, "" },
                        { GetName("Aura_Bones").Key, "Smells Fishy" },                   { GetAbbreviation("Aura_Bones").Key, "" },
                        { GetName("Aura_Bugs").Key, "Butterfly Effect" },                { GetAbbreviation("Aura_Bugs").Key, "" },
                        { GetName("Aura_Cards").Key, "Magic Illusion" },                 { GetAbbreviation("Aura_Cards").Key, "" },
                        { GetName("Aura_Colors").Key, "Colour Pop" },                    { GetAbbreviation("Aura_Colors").Key, "" },
                        { GetName("Aura_Diamonds").Key, "Diamond Ring" },                { GetAbbreviation("Aura_Diamonds").Key, "" },
                        { GetName("Aura_Embers").Key, "Falling Ember" },                 { GetAbbreviation("Aura_Embers").Key, "" },
                        { GetName("Aura_Fire").Key, "Flame Thrower" },                   { GetAbbreviation("Aura_Fire").Key, "" },
                        { GetName("Aura_GroundLightning").Key, "Lightning Charge" },     { GetAbbreviation("Aura_GroundLightning").Key, "" },
                        { GetName("Aura_Ice").Key, "Frost Bite" },                       { GetAbbreviation("Aura_Ice").Key, "" },
                        { GetName("Aura_Leaves").Key, "Leaf Shield" },                   { GetAbbreviation("Aura_Leaves").Key, "" },
                        { GetName("Aura_Lightning").Key, "Magnetic Power" },             { GetAbbreviation("Aura_Lightning").Key, "" },
                        { GetName("Aura_Orbs").Key, "Space Orbs" },                      { GetAbbreviation("Aura_Orbs").Key, "" },
                        { GetName("Aura_Star").Key, "Star Shine" },                      { GetAbbreviation("Aura_Star").Key, "" },
                        { GetName("Aura_Water").Key, "Whirlpool" },                      { GetAbbreviation("Aura_Water").Key, "" },
                        { GetName("Aura_Wind").Key, "Blue Wind" },                       { GetAbbreviation("Aura_Wind").Key, "" },
                        { GetName("Aura_Dizzy").Key, "Dizzy" },                          { GetAbbreviation("Aura_Dizzy").Key, "" },
                        { GetName("Aura_Sparks").Key, "Sparks" },                        { GetAbbreviation("Aura_Sparks").Key, "" },
                        { GetName("Hat_Alien").Key, "Alien Helmet" },                    { GetAbbreviation("Hat_Alien").Key, "" },
                        { GetName("Hat_Bag").Key, "Hat of Mystery" },                    { GetAbbreviation("Hat_Bag").Key, "" },
                        { GetName("Hat_BatGrey").Key, "Dark Knight" },                   { GetAbbreviation("Hat_BatGrey").Key, "" },
                        { GetName("Hat_BatRed").Key, "Crimson Knight" },                 { GetAbbreviation("Hat_BatRed").Key, "" },
                        { GetName("Hat_Cap").Key, "Everyday Cap" },                      { GetAbbreviation("Hat_Cap").Key, "" },
                        { GetName("Hat_Cat").Key, "Feline Helmet" },                     { GetAbbreviation("Hat_Cat").Key, "" },
                        { GetName("Hat_Chicken").Key, "Chicken Beanie" },                { GetAbbreviation("Hat_Chicken").Key, "" },
                        { GetName("Hat_Football").Key, "Football Head" },                { GetAbbreviation("Hat_Football").Key, "" },
                        { GetName("Hat_HelmDevil").Key, "Devil Helmet" },                { GetAbbreviation("Hat_HelmDevil").Key, "" },
                        { GetName("Hat_HelmHorned").Key, "Horned Helmet" },              { GetAbbreviation("Hat_HelmHorned").Key, "" },
                        { GetName("Hat_HelmTall").Key, "Magnificent Helmet" },           { GetAbbreviation("Hat_HelmTall").Key, "" },
                        { GetName("Hat_HelmWhite").Key, "White Warrior Helmet" },        { GetAbbreviation("Hat_HelmWhite").Key, "" },
                        { GetName("Hat_Ice").Key, "Ice Walker Helmet" },                 { GetAbbreviation("Hat_Ice").Key, "" },
                        { GetName("Hat_Indie").Key, "Fedora" },                          { GetAbbreviation("Hat_Indie").Key, "" },
                        { GetName("Hat_Ironman").Key, "Ironguy Helmet" },                { GetAbbreviation("Hat_Ironman").Key, "" },
                        { GetName("Hat_KickAss").Key, "Castle Guard Mask" },             { GetAbbreviation("Hat_KickAss").Key, "" },
                        { GetName("Hat_Kid").Key, "Whiz Kid's Cap" },                    { GetAbbreviation("Hat_Kid").Key, "" },
                        { GetName("Hat_Kitty").Key, "Softy Kitty Hood" },                { GetAbbreviation("Hat_Kitty").Key, "" },
                        { GetName("Hat_Link").Key, "Phrygian Cap" },                     { GetAbbreviation("Hat_Link").Key, "" },
                        { GetName("Hat_Mega").Key, "Megaguy Helmet" },                   { GetAbbreviation("Hat_Mega").Key, "" },
                        { GetName("Hat_Music").Key, "Boom Box Head" },                   { GetAbbreviation("Hat_Music").Key, "" },
                        { GetName("Hat_Ninja").Key, "Ninja Mask" },                      { GetAbbreviation("Hat_Ninja").Key, "" },
                        { GetName("Hat_Pineapple").Key, "Pineapple Head" },              { GetAbbreviation("Hat_Pineapple").Key, "" },
                        { GetName("Hat_Poo").Key, "Poop Head" },                         { GetAbbreviation("Hat_Poo").Key, "" },
                        { GetName("Hat_PowerRanger").Key, "Silver Mask" },               { GetAbbreviation("Hat_PowerRanger").Key, "" },
                        { GetName("Hat_Robot").Key, "Cyclops Mask" },                    { GetAbbreviation("Hat_Robot").Key, "" },
                        { GetName("Hat_Soccer").Key, "Soccer Head" },                    { GetAbbreviation("Hat_Soccer").Key, "" },
                        { GetName("Hat_Top").Key, "Top Hat" },                           { GetAbbreviation("Hat_Top").Key, "" },
                        { GetName("Hat_Transformer").Key, "Optimus Helmet" },            { GetAbbreviation("Hat_Transformer").Key, "" },
                        { GetName("Hat_Tribal").Key, "Tribal Helmet" },                  { GetAbbreviation("Hat_Tribal").Key, "" },
                        { GetName("Hat_Wizard").Key, "Wizard Hat" },                     { GetAbbreviation("Hat_Wizard").Key, "" },
                        { GetName("Hat_Beanie").Key, "Beanie" },                         { GetAbbreviation("Hat_Beanie").Key, "" },
                        { GetName("Hat_Detective").Key, "Detective Hat" },               { GetAbbreviation("Hat_Detective").Key, "" },
                        { GetName("Hat_Ears").Key, "Ears" },                             { GetAbbreviation("Hat_Ears").Key, "" },
                        { GetName("Hat_Halo").Key, "Angel Halo" },                       { GetAbbreviation("Hat_Halo").Key, "" },
                        { GetName("Hat_HeadPhones").Key, "Headphones" },                 { GetAbbreviation("Hat_HeadPhones").Key, "" },
                        { GetName("Hat_MadHatter").Key, "Mad Hat" },                     { GetAbbreviation("Hat_MadHatter").Key, "" },
                        { GetName("Hat_RedTopHat").Key, "Red Hat" },                     { GetAbbreviation("Hat_RedTopHat").Key, "" },
                        { GetName("Hat_Ribbon").Key, "Ribbon" },                         { GetAbbreviation("Hat_Ribbon").Key, "" },
                        { GetName("Hat_Santa").Key, "Santa" },                           { GetAbbreviation("Hat_Santa").Key, "" },
                        { GetName("Hat_SmallTook").Key, "Small Toque" },                 { GetAbbreviation("Hat_SmallTook").Key, "" },
                        { GetName("Hat_Took").Key, "Toque" },                            { GetAbbreviation("Hat_Took").Key, "" },
                        { GetName("Slash_Darkness").Key, "Casting Shadows" },            { GetAbbreviation("Slash_Darkness").Key, "" },
                        { GetName("Slash_Embers").Key, "Fiery Embers" },                 { GetAbbreviation("Slash_Embers").Key, "" },
                        { GetName("Slash_EmbersBlue").Key, "Frosted Embers" },           { GetAbbreviation("Slash_EmbersBlue").Key, "" },
                        { GetName("Slash_Fire").Key, "Flames" },                         { GetAbbreviation("Slash_Fire").Key, "" },
                        { GetName("Slash_FireBlack").Key, "Crimson Flames" },            { GetAbbreviation("Slash_FireBlack").Key, "" },
                        { GetName("Slash_FireGray").Key, "Gray Flames" },                { GetAbbreviation("Slash_FireGray").Key, "" },
                        { GetName("Slash_FireOrange").Key, "Summoner Flames" },          { GetAbbreviation("Slash_FireOrange").Key, "" },
                        { GetName("Slash_Lava").Key, "Hot Lava" },                       { GetAbbreviation("Slash_Lava").Key, "" },
                        { GetName("Slash_Leaves").Key, "Fallen Leaves" },                { GetAbbreviation("Slash_Leaves").Key, "" },
                        { GetName("Slash_Lightning").Key, "Blue Lightning" },            { GetAbbreviation("Slash_Lightning").Key, "" },
                        { GetName("Slash_Paint").Key, "Paint Streaks" },                 { GetAbbreviation("Slash_Paint").Key, "" },
                        { GetName("Slash_Petals").Key, "Sakura Petals" },                { GetAbbreviation("Slash_Petals").Key, "" },
                        { GetName("Slash_Rainbow").Key, "Rainbow Road" },                { GetAbbreviation("Slash_Rainbow").Key, "" },
                        { GetName("Slash_Smelly").Key, "Something Stinks" },             { GetAbbreviation("Slash_Smelly").Key, "" },
                        { GetName("Slash_Stars").Key, "Starry Path" },                   { GetAbbreviation("Slash_Stars").Key, "" },
                        { GetName("Slash_StarsBlue").Key, "Glimmering Path" },           { GetAbbreviation("Slash_StarsBlue").Key, "" },
                        { GetName("Slash_Water").Key, "Tidal Waves" },                   { GetAbbreviation("Slash_Water").Key, "" },
                        { GetName("Suit_ArmorFace").Key, "Unknown Face" },               { GetAbbreviation("Suit_ArmorFace").Key, "" },
                        { GetName("Suit_ArmorGreen").Key, "Forest Fighter" },            { GetAbbreviation("Suit_ArmorGreen").Key, "" },
                        { GetName("Suit_ArmorHighTec").Key, "Futuristic Gladiator" },    { GetAbbreviation("Suit_ArmorHighTec").Key, "" },
                        { GetName("Suit_ArmorIce").Key, "Frosted Armor" },               { GetAbbreviation("Suit_ArmorIce").Key, "" },
                        { GetName("Suit_ArmorOrange").Key, "Sunrise Armor" },            { GetAbbreviation("Suit_ArmorOrange").Key, "" },
                        { GetName("Suit_ArmorPurple").Key, "Amethyst Armor" },           { GetAbbreviation("Suit_ArmorPurple").Key, "" },
                        { GetName("Suit_ArmorRed").Key, "Crimson Warrior" },             { GetAbbreviation("Suit_ArmorRed").Key, "" },
                        { GetName("Suit_ArmorRoman").Key, "Ancient Rome" },              { GetAbbreviation("Suit_ArmorRoman").Key, "" },
                        { GetName("Suit_ArmorRoyal").Key, "Fit for Royals" },            { GetAbbreviation("Suit_ArmorRoyal").Key, "" },
                        { GetName("Suit_ArmorScale").Key, "Scaly Suit" },                { GetAbbreviation("Suit_ArmorScale").Key, "" },
                        { GetName("Suit_ArmorWhite").Key, "White Warrior" },             { GetAbbreviation("Suit_ArmorWhite").Key, "" },
                        { GetName("Suit_Casual").Key, "Everyday Sweater" },              { GetAbbreviation("Suit_Casual").Key, "" },
                        { GetName("Suit_Chicken").Key, "Chicken Breast" },               { GetAbbreviation("Suit_Chicken").Key, "" },
                        { GetName("Suit_Farmer").Key, "Farmer Overalls" },               { GetAbbreviation("Suit_Farmer").Key, "" },
                        { GetName("Suit_Ironman").Key, "Ironman Suit" },                 { GetAbbreviation("Suit_Ironman").Key, "" },
                        { GetName("Suit_KungFu").Key, "Kungfu Master" },                 { GetAbbreviation("Suit_KungFu").Key, "" },
                        { GetName("Suit_Ninja").Key, "Ninja Suit" },                     { GetAbbreviation("Suit_Ninja").Key, "" },
                        { GetName("Suit_Robot").Key, "Cyclops Body" },                   { GetAbbreviation("Suit_Robot").Key, "" },
                        { GetName("Suit_Snowman").Key, "Snowman" },                      { GetAbbreviation("Suit_Snowman").Key, "" },
                        { GetName("Suit_Wizard").Key, "Wizard Sweater" },                { GetAbbreviation("Suit_Wizard").Key, "" },
                        { GetName("Weapon_Basic").Key, "Average Sword" },                { GetAbbreviation("Weapon_Basic").Key, "" },
                        { GetName("Weapon_Bat").Key, "Dark Knight Sword" },              { GetAbbreviation("Weapon_Bat").Key, "" },
                        { GetName("Weapon_BattleAxe").Key, "Axe of Ages" },              { GetAbbreviation("Weapon_BattleAxe").Key, "" },
                        { GetName("Weapon_Beam").Key, "Lightsaber" },                    { GetAbbreviation("Weapon_Beam").Key, "" },
                        { GetName("Weapon_Brute").Key, "Crimson Sword" },                { GetAbbreviation("Weapon_Brute").Key, "" },
                        { GetName("Weapon_Buster").Key, "Buster Blade" },                { GetAbbreviation("Weapon_Buster").Key, "" },
                        { GetName("Weapon_Carrot").Key, "Carrot Stick" },                { GetAbbreviation("Weapon_Carrot").Key, "" },
                        { GetName("Weapon_Cleaver").Key, "Conqueror's Cleaver" },        { GetAbbreviation("Weapon_Cleaver").Key, "" },
                        { GetName("Weapon_Club").Key, "Club" },                          { GetAbbreviation("Weapon_Club").Key, "" },
                        { GetName("Weapon_Excalibur").Key, "Excalibur" },                { GetAbbreviation("Weapon_Excalibur").Key, "" },
                        { GetName("Weapon_Fish").Key, "Fish Stick" },                    { GetAbbreviation("Weapon_Fish").Key, "" },
                        { GetName("Weapon_Gear").Key, "Geared Blade" },                  { GetAbbreviation("Weapon_Gear").Key, "" },
                        { GetName("Weapon_Glaive").Key, "Ancient Glaive" },              { GetAbbreviation("Weapon_Glaive").Key, "" },
                        { GetName("Weapon_Halberd").Key, "Onyx Halberd" },               { GetAbbreviation("Weapon_Halberd").Key, "" },
                        { GetName("Weapon_Hammer").Key, "Titansmasher" },                { GetAbbreviation("Weapon_Hammer").Key, "" },
                        { GetName("Weapon_Holy").Key, "Knightfall Sword" },              { GetAbbreviation("Weapon_Holy").Key, "" },
                        { GetName("Weapon_Katana").Key, "Reforged Katana" },             { GetAbbreviation("Weapon_Katana").Key, "" },
                        { GetName("Weapon_Laser").Key, "Energy Sword" },                 { GetAbbreviation("Weapon_Laser").Key, "" },
                        { GetName("Weapon_Ninja").Key, "Ninja Dagger" },                 { GetAbbreviation("Weapon_Ninja").Key, "" },
                        { GetName("Weapon_Pencil").Key, "Blue Pencil" },                 { GetAbbreviation("Weapon_Pencil").Key, "" },
                        { GetName("Weapon_PitchFork").Key, "Pitchfork" },                { GetAbbreviation("Weapon_PitchFork").Key, "" },
                        { GetName("Weapon_Poison").Key, "Poisonous Spellblade" },        { GetAbbreviation("Weapon_Poison").Key, "" },
                        { GetName("Weapon_Saw").Key, "Sharpened Saw" },                  { GetAbbreviation("Weapon_Saw").Key, "" },
                        { GetName("Weapon_Skull").Key, "Skull-crusher Sword" },          { GetAbbreviation("Weapon_Skull").Key, "" },
                        { GetName("Weapon_Spear").Key, "Swift Spear" },                  { GetAbbreviation("Weapon_Spear").Key, "" },
                        { GetName("Weapon_Staff").Key, "Twilight Staff" },               { GetAbbreviation("Weapon_Staff").Key, "" },
                        { GetName("Weapon_Sythe").Key, "Death Sythe" },                  { GetAbbreviation("Weapon_Sythe").Key, "" },
                        { GetName("Weapon_WoodAxe").Key, "Lumberjack Axe" },             { GetAbbreviation("Weapon_WoodAxe").Key, "" },
                        { GetName("Weapon_ZigZag").Key, "Crooked Blade" },               { GetAbbreviation("Weapon_ZigZag").Key, "" },
                        { GetName("Aura_Valentines").Key, "Circle of Love" },            { GetAbbreviation("Aura_Valentines").Key, "" },
                        { GetName("Hat_Valentines").Key, "Hat of Love" },                { GetAbbreviation("Hat_Valentines").Key, "" },
                        { GetName("Weapon_Valentines").Key, "Heartbreaker" },            { GetAbbreviation("Weapon_Valentines").Key, "" },
                    }.ToImmutableDictionary();
            }
        }
    }
}
