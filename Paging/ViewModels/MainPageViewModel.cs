using Paging.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Paging.ViewModels
{
    class MainPageViewModel
    {
        public List<GameData> Games { get; set; }
        public MainPageViewModel() {
            Games = new List<GameData> {
                new GameData { Name = "American McGee's Alice", YearOfRelease = 2000, Rating = 4, Platform = PlatformType.PC, System = "Mac & Windows", About = "The game's premise is based on the Lewis Carroll novels Alice's Adventures in Wonderland and Through the Looking-Glass, but presents a gloomy, cruel and violent version of the setting. The game centers on the novels' protagonist Alice, whose parents are killed in a house fire years before the story of the game takes place. After several years of treatment in a psychiatric clinic, the emotionally traumatized Alice makes a mental retreat to Wonderland, which has been disfigured by her injured psyche."},
                new GameData { Name = "Sonic Adventure 2", YearOfRelease = 2002, Rating = 4, Platform = PlatformType.Console, System = "Nintendo Gamecube", About = "a 3D platform game divided into two campaigns: Hero and Dark. In the Hero campaign, players control Sonic, Tails, and Knuckles, who fight to save the world; in the Dark campaign, players control Shadow the Hedgehog, Doctor Eggman and Rouge the Bat, fighting to conquer it. Each campaign cycles through levels of its three characters, telling different sides of the story."},
                new GameData { Name = "Crash Bandicoot: Tag Team Racing", YearOfRelease = 2005, Rating = 3, Platform = PlatformType.Console, System = "Nintendo Gamecube", About = "The game's story centers on the exploits of the protagonist, Crash Bandicoot, who must win the ownership of a dilapidated theme park by finding its missing Power Gems before his nemesis, Doctor Neo Cortex, can."},
                new GameData { Name = "Sonic the Hedgehog", YearOfRelease = 2006, Rating = 2, Platform = PlatformType.Console, System = "Xbox360", About = "Players control Sonic, Shadow, and new character Silver, who battle Solaris, an ancient evil pursued by Doctor Eggman. Each playable character has his own campaign and abilities, and must complete levels, explore hub worlds and fight bosses to advance the story. In multiplayer modes, players can work cooperatively to collect Chaos Emeralds or race to the end of a level."},
                new GameData { Name = "Kingdom Hearts: Coded", YearOfRelease = 2008, Rating = 3, Platform = PlatformType.Mobile, System = "Android & IOS", About = "The gameplay is centered mostly around puzzle solving, with action-RPG gameplay elements, similar to previous Kingdom Hearts games. Mini-games and platforming are also featured, with three dimensional backgrounds and two dimensional characters."},

                
        };
        }

       
    }
}
