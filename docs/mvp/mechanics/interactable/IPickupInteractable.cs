using UnityEngine;

public class PickupInteractable : MonoBehaviour, IInteractable
{
    public Item item; // The item that this interactable contains

    public void OnInteract(PlayerController player)
    {
        // Add the item to the player's inventory
        player.inventory.AddItem(item);

        // Destroy the item in the game world
        Destroy(gameObject);
    }
}