# MVP Feature - Tree Chopping

The player will be able to chop down trees using the "Chop" action. A `Tree` object will have a health value and after a certain number of hits, it will fall down with a physical object and drop `Wood` items as pickups that can be added to the player's inventory.

## Classes Needed

- `Tree.cs`: A class that inherits from `GatherableResource.cs` and has a set amount of health. When the health is reduced to zero, the tree will fall down and create a physical object with a set amount of wood pickups.
- `Wood.cs`: An item that inherits from `PickupInteractable.cs` and can be added to the player's inventory.
