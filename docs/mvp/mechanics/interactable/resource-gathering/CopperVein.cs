using UnityEngine;

public class OreVein : MonoBehaviour, IInteractable
{
    public int amount = 5;  // The amount of copper ore that can be gathered from this vein

    public ItemType type;

    public void OnInteract(PlayerController player)
    {
        // Check if the player has a pickaxe equipped
        if (player.equippedItem is Pickaxe)
        {
            // Reduce the amount of ore in this vein
            amount--;

            // Add copper ore to the player's inventory
            player.inventory.AddItem(new Item("Copper Ore", 1));
            
            // If there's no more ore, destroy this object
            if (amount <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
