# Constant Spawning Mod
This mod allows you to spawn a monster of your choice at an interval set by you. it could be one second or twenty the choice is yours.
The current version of the mod only requires the host to have it and only they can use the commands. It also works as of patch v64 and can spawn any enemy other than the man eater, which I currently could not get to spawn using the mod.


This mod was originally developed for use by the Twitch Streamer AKalllo in the following video but we have now decided to make it public!
https://www.youtube.com/watch?v=GlzoKWYj9rw
This mod is now open source and free for anyone to use, if you do decide to use it to create content it would be appreciated if you shouted out me or Akalllo but that is not required.
If you are interested in the source code for the project, the GitHub can be found here:
https://github.com/KingofSkulls/Lethal-Company-Constant-Spawning


# How to use the spawn function
1. Once on a moon, open chat
2. type in /loop followed by the internal name of the monster you would like to start spawning then the frequency you would like them to spawn in seconds.  
Both of these parameters are optional, if you are satisfied with the current spawn speed and enemy type you dont need to type them again just the /loop to start the loop.
3. Enemies will spawn randomly among the list of available spawn points, inside enemies spawn inside, and outside enemies spawn outside

# You may not be fully aware of the names, so here's a list of the enemy names:
*Note: You don't need to type the full name, for example, "spider" will work for the bunker spider. Captilization also does not matter

Inside:
Girl
Lasso
Bunker Spider
Centipede
Blob
Flowerman
Spring
Crawler
Hoarding bug
Jester
Puffer
Nutcracker
Butler
Clay Surgeon

Outside:
ForestGiant
MouthDog
Earth Leviathan
Baboon Bird
Masked
RadMech


# Installation
1. Install BepInEx
2. Run game once with BepInEx installed to generate folders/files
3. Drop the DLL inside of the BepInEx/plugins folder
4. No further steps needed

# Commands

- /loop (enemy internal name) (desired spawn frequency in seconds) : starts the process of monsters spawning every N seconds.
- /stop : stops the current spawn loop

# Credits
- All new code written by Skull King
- Credit to AKalllo for the idea
- Credit to the following developers for creating the Game Master mod used as a base for this mod https://thunderstore.io/c/lethal-company/p/GameMasterDevs/GameMaster/
- Pre 1.11 code written by iminxx
- Icon by sadamazon
- Post 1.11 backend code is done by CatMCFish
- All of the work done to the GUI is done by Digiphoenix
- Feel free to use any parts of the code in your own mod!