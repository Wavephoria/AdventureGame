# GameMakingtest

- This will be a text-based adventure game


# Update 20/2-23
- Game is playable but lack stuff to do except just fighting!
- Map generated from a premade map in Excel
- Movement implemented
- Player can now check stats and decide movement each turn
- Before movement user can see what lies beyond in each direction
- Some encounters are done, and battling monster will ensure until someone dies if needed


# Priorities
- Encounters in the world
- Monsters
- Battlesystem
  Flee from battle

# Priorites 2
- Towns
- NPCs

# Priorites 3
- Save/Load progress


# Wishlist
Main functions

- Save/Load feature
  At first this will most likely be some kind of text-based saving function, maybe later a small database
- Implement playing in browser
- Running two threads
  Main game in middle, stats menu on left side


World functions

- World needs to be populated with NPC and towns/caves to explore
- Each town in the world will offer something different, some will be small towns with just tavern and some will be much bigger
- Each town will be populated with NPCs to interact with
- Caves will be of different size and level, will be little hint before entering how hard cave could be
- End game will be in the dungeon on map, will have a big boss that will be very hard to kill


Hero functions

- Hero classes needs to be built up to offer some different mechanics and playstyle
- Will change the level up system in game, will have to look at balancing
- Gold/Silver can be found in chest in the wild and be used in town to buy stuff
- Travelling merchants can appear and can have stuff that you want to buy
- Focus system ---- Will be used as a percentage, starting with 100%
  Focus system will be a set level at how good hero will be fighting
  Alcohol will lower it
  Being out on long adventures will also lower it


Monster functions

- In each of the different environments in the world, each one will have a different sets of monster list that can spawn and have a different
  chance or being a monster or something much nicer
- Random drops from enemies
  Each enemy type will have a different set of items they can carry
  Will be randomized what they carry
  Maybe they carry just "item name" and then depends on what level hero is, the type of weapon/armor can differ
  

Battle system

- Will be balanced and changed later
- Should be able to run from fights if they are looking to be too dangerous


NPC

- Needs to be built out alot, right now there is only a blueprint of that kind of NPCs you can meet in the world


Items 

- Should have Potions, Valuables, MonsterDrops, Weapons and Armor
- Can be bought or sold in towns or merchant
- Backpack will have a set amount of space for items, items worn on you will not be acounted for


Storytelling

- Low on the list right now until I have build out alot more NPC and Towns
- Will be a small story just to have some content to build on
