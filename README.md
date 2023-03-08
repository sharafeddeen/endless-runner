# Design Document for Endless Runner
This document contains general ideas about the game: overview, story, environment, mechanics, ideas for future features, etc.

## Overview
An ocean-themed endless runner game.

The player is being dragged into a swirling whirlpool in the middle of the ocean. Other objects are being dragged (e.g., wooden boxes, wrecked ships, etc.) and the player has to avoid them. If the player hits anything, they lose balance and fall deeper; otherwise, they can rotate themselves to get further from the center of the whirlpool. The whilrpool will eventually suck the player. But the game measures how long the player can survive; the longer they survive, the harder the game gets.

## Story
Two possible scenarios here:
1) You're on a sailboat/ship in the middle of the ocean. Strong tides and engine failure cause you to go off-course and you get lost. After a while, you find a swirling whirlpool in the horizon that you're being dragged into.
2) Same scenario as 1, but your ship gets wrecked and you're left with a longboard that you can use to surf.

## Environment
This section describes the separate elements that constitute the environment, as well as how they all come together to form the environment.

### Background Elements
These elements are there to complement the environment and make it more realistic. The player doesn't interact with them. They can either be still (still sky) or have simple motion patterns (simple ocean waves).
- **Sky**:        day/night sky with simple sun/moon or stars.
- **Ocean**:      water environment with small or big waves.

### Foreground Elements
These elements will have animation that mainly depends on how the player interacts with them. They're closer to the player (in terms of depth) than the background elements.
- **Whirlpool**:  swirling whirlpool that sucks elements (e.g., obstacles/player).
- **Obstacles**:  some ship wreckage that's falling into the whirlpool before the player.
- **Player**:     either a person steering a ship or a surfer on a longboard.

### Environment Synergy
The background elements won't do anything: they're there to augment the visuals and give more realistic feelings to the environment. The main foreground element is the whirlpool; this should take up most of the screen space (and some space off-screen that keeps being rendered as the player swirls in the whirlpool). The wreckage is falling into the whirlpool but not as fast as the player (depending on how big the wreckage is: should bigger or smaller fall more quickly?).

### Device & Environment Visibility
The player will play using a mobile phone in vertical mode. This means that not all elements are being rendered to the screen. Exactly what portions are to be rendered will be decided later.

## Game Mechanics & Physics
This section descrbies the physics of the game: the rules for the interaction of objects in the environment, and the rules for how the player interacts with the environment.

## Notes (misc.)
