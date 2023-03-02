# MVP Feature: Gathering Loose Materials

The player will be able to gather loose materials on the ground, such as sticks and rocks, by interacting with them. Additionally, there will be a chance to find copper and tin ores when gathering these materials, albeit very rarely.

This will be achieved by creating a new type of interactable object called a "loose material". This will be implemented using the `PickupInteractable.cs` script that we previously generated. When the player interacts with a loose material, the `PickupInteractable.cs` script will add the item to the player's inventory if there is space available. 

To make the chance of finding copper and tin ores more rare, we will create a random number generator with a low probability of spawning an ore instead of a stick or rock. Once the player has picked up the item, it will be removed from the game world.

The `Inventory.cs` and `InventorySlot.cs` classes that we generated earlier will be used to manage the player's inventory and the items that they pick up. The `Item.cs` class will be used to define the properties of the different items that can be picked up, including the loose materials and ores.

This feature will add an additional layer of resource gathering for the player and make the game feel more immersive by allowing them to scavenge for materials on the ground. It also creates an additional challenge for the player by making it more difficult to find copper and tin ores, which are essential for progressing in the game. 
