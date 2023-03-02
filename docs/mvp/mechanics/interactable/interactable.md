# Interactable System

## MVP Interactables

### IInteractable.cs

- Interface that all interactable objects will implement.
- Contains a single function OnInteract().

### DoorInteractable.cs

- Implements IInteractable.cs
- Represents a door that can be opened and closed by the player.
- When the player presses the interact button while looking at the door, the door will open or close depending on its current state.

### PickupInteractable.cs

- Implements IInteractable.cs
- Represents an item that the player can pick up.
- When the player presses the interact button while looking at the item, the item will be added to the player's inventory.
