# Code Bade Expansion:
This repository represents the "code base expansion" project for CSCI-B453 Game Development.
I am expanding upon the code base provided for the game Dualikiwi developed for the Global Game Jam 2022.

## CBE 1
I am expanding on the original game by adding a new interactable item that "mirrors" the direction the enemy kiwi moves, causing its movement to match the player controlled kiwi rather than move opposite it. This effect will occur when either kiwi interacts with a mirror interactable and will be undone if either kiwi interacts with another mirror interactable wihtin the same level. This effect will only last until the level is cleared or the player kiwi is defeated and the level is reset.

The mirror interactable has been added to the new levels 16 and 17, which are designed specifically to make use of the mirror's properties.

## CBE 2
In the second part of the code base expansion, I am adding a new button and door mechanic to the game. There will be two types of buttons, one that can be activated by the player and one that can be activated by the enemy. Each button will have matching doors that can be opened by activating the corresponding button. The button and door mechanic has been added to the new level 18, 19, and 20. Level 20 makes use of both the mirror and door interactables to showcase how both items can work together.

I am also adding a local two-player mode, where each player moves separately and the respective enemy will move when the assigned player moves. This will mean that the player one enemy will only move when player one moves. In this gamemode the level will be failed if either player dies and will be completed when all enemy kiwis have been defeated. There is one level added to the level select screen that utilizes the two-player mode, this level is unlocked after all 20 one-player levels have been completed.

## GGJ-2022: DualiKiwi
Repository for this year's Global Game Jam project
[Kanban](https://github.com/swiimii/GGJ-2022/projects/1)
