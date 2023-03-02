# MVP Feature: Mining Ore Veins

## Description

Players will be able to mine ore veins found in the world using a pickaxe. After each swing of the pickaxe, ore will be added to the player's inventory directly. 

## Implementation

- Create a `Pickaxe.cs` script that handles the mining of ore veins.
- Add a `OnTriggerEnter()` function to `Pickaxe.cs` that checks for a `GatherableResource.cs` component on the game object it collides with.
- If a `GatherableResource.cs` component is found, check if it is a `CopperOre.cs` or `TinOre.cs` component.
- If the component is found, add the appropriate `Item.cs` object to the player's `Inventory.cs` with a quantity of 1.
- Update the UI to show the new item in the inventory.

## Considerations

- The mining animation should be synced across the network for multiplayer gameplay.
- The `Pickaxe.cs` script should handle durability and breakage of the pickaxe after a certain number of uses.
- The `GatherableResource.cs` script should handle depletion of the ore vein after a certain number of uses.
- The ore vein should respawn after a certain amount of time.
