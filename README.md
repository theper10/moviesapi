# Scrapborn

**Scrapborn** is a 2D top-down roguelite factory-survival prototype built in **Godot 4 .NET** with **C#**.

You play as a small scrap robot trying to survive in a dead industrial wasteland. During the day, you gather scrap, build a small automated factory, produce ammo, place turrets, repair damaged structures, and prepare your base. At night, waves of corrupted machines attack your Core.

The goal of the current prototype is simple:

> Build. Automate. Survive 5 nights.

---

## Project Status

**Status:** Playable prototype / portfolio project  
**Target:** PC  
**Engine:** Godot 4.x .NET  
**Language:** C#  
**Genre:** Factory automation + roguelite survival  
**Current scope:** Single-run playable demo loop

This is not a finished commercial game yet. It is a playable vertical slice focused on core systems, game loop, and prototype feel.

---

## Gameplay Overview

Scrapborn is built around a short roguelite run structure:

1. **Gather Scrap** from resource deposits.
2. **Build machines** such as Drills, Generators, Assemblers, Turrets, and Storage.
3. **Produce resources** like Scrap, Energy, and Ammo.
4. **Defend the Core** from enemy waves at night.
5. **Repair and sell buildings** as the base gets damaged.
6. **Choose upgrades** between nights.
7. **Survive 5 nights** to win the run.

---

## Features

### Core Gameplay

- 2D top-down movement
- Scrap gathering from finite resource deposits
- Grid-based building placement
- Building selling with partial refunds
- Building health, damage, repair, and destruction
- Day/night survival loop
- 5-night run structure
- Victory and defeat states
- Run summary screen

### Factory Systems

- **Drill**: extracts Scrap from nearby Scrap Deposits
- **Generator**: produces Energy
- **Assembler**: converts Scrap and Energy into Ammo
- **Turret**: consumes Ammo to shoot enemies
- **Storage**: increases resource capacity

### Resource Economy

- Finite Scrap Deposits
- Controlled Scrap Deposit respawning
- Resource caps
- Resource refund system when selling buildings
- Softlock protection for depleted Scrap Deposits

### Combat

- Multiple enemy archetypes:
  - Crawler
  - Fast enemy
  - Tank
- Turret targeting and firing
- Enemy health and death feedback
- Enemies can damage:
  - Core
  - Buildings
  - Player
- Player death and Core destruction both trigger defeat

### Roguelite Upgrades

The prototype includes a run-based upgrade system with upgrade cards across several categories:

- Player upgrades
- Core upgrades
- Turret upgrades
- Production upgrades
- Economy upgrades

Upgrades appear between survived nights and apply for the rest of the run.

### UI / UX

- Main menu
- Settings menu
- Pause menu
- HUD with resources, health, objectives, and phase info
- Build hotbar
- Placement preview and placement validation
- Inspection panel for buildings and Core
- Hover previews
- Tutorial-style objective tracker
- Victory/defeat summary panel

### Feedback and Polish

- Floating text feedback
- Damage flashes
- Repair pulses
- Camera shake
- Placeholder SFX
- Feedback intensity settings
- Runtime settings for:
  - Master volume
  - SFX volume
  - Mute
  - Feedback intensity
  - Camera shake
  - Camera shake strength
  - Debug stats
  - Fullscreen
  - VSync

---
