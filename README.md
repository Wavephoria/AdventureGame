# GameMakingtest

- This will be a text-based adventure game

# PrioList
- Make a movement system
- Make the generation of preplanned map
    Need to see how to fix bugs when getting to the end of line, is printing \nQ instead of Q
    Bottom end of map is also showing wrong values

# Wishlist

Main functions

- Save/Load feature
  At first this will most likely be some kind of text-based saving function, maybe later a small database

World functions

- World will be predetermined to be able to consist of a smaller story element and objectives
- Towns will be implemented, will have buildings to visit like tavern/pub/store/dojo?
- Maybe some kind of dungeon/cave endgame with a big boss

Hero functions

- Base class implementation ---- Adventurer implemented
  Everyone will at the start be in some kind of base class, but should soon be able to choose which class to join
- Level up system
  Will make enemies harder, and drops better
  Will be able to level up within each class at set milestones (Learn new spells or abilities)
- Gold/Silver ---- Each Hero will have a pouch with some start gold and silver
  Will be used in town to buy better gear, potions or drink alcohol
- Focus system ---- Will be used as a percentage, starting with 100%
  Focus system will be a set level at how good hero will be fighting
  Alcohol will lower it
  Being out on long adventures will also lower it

Monster functions

- Different environments in the world will have different enemies and different risk of spawning random encounter
- Random drops from enemies
  Each enemy type will have a different set of items they can carry
  Will be randomized what they carry
  Maybe they carry just "item name" and then depends on what level hero is, the type of weapon/armor can differ
