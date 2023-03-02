# MVP Feature: Resource Gathering

## Gathering

- [Gathering](./gathering.md)

## Mining / Woodcutting

- [Woodcutting](./woodcutting.md)

- [Mining](./mining.md)

  - [CopperVein.cs](./CopperVein.cs)

  - [Tree.cs](./Tree.cs)

Players will be able to gather resources by interacting with GatherableResource objects in the game world. When a player interacts with a GatherableResource, a progress bar will appear on screen and the player will continue to interact with the object until the progress bar is complete. Once complete, the GatherableResource object will be destroyed and a new item will be added to the player's inventory.

The player's inventory will consist of an Inventory object, which will be a list of InventorySlot objects. Each InventorySlot object will contain an Item object, as well as the quantity of that item that the player currently has in their inventory.

When a player interacts with a GatherableResource, the type of item that is added to their inventory will depend on the type of GatherableResource that they are interacting with. For example, if the player interacts with a CopperOre GatherableResource, a new Item object with the type "Copper Ore" will be added to their inventory.

If the player's inventory is full, they will not be able to interact with any additional GatherableResource objects until they free up some inventory space.

The player will be able to view their inventory at any time by pressing a designated key on their keyboard. This will bring up the Inventory UI, which will display a list of InventorySlot objects representing the items in the player's inventory. The player will be able to select an individual item in their inventory to view its details, including its name and quantity.

Additionally, the player will be able to drop items from their inventory by selecting an item in their inventory UI and clicking a "Drop" button. This will remove the item from their inventory and spawn a new GameObject in the game world with the Item's corresponding sprite, representing the dropped item.