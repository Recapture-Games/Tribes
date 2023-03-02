// Inventory.cs
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public int maxSlots = 20;
    public List<InventorySlot> slots = new List<InventorySlot>();
    
    public bool AddItem(Item itemToAdd)
    {
        if (slots.Count < maxSlots)
        {
            // Check if the item is already in the inventory and stackable
            foreach (InventorySlot slot in slots)
            {
                if (slot.item != null && slot.item.itemName == itemToAdd.itemName && slot.item.isStackable)
                {
                    slot.AddToStack(itemToAdd.quantity);
                    return true;
                }
            }
            // Add the item to an empty slot
            InventorySlot newSlot = new InventorySlot(itemToAdd, 1);
            slots.Add(newSlot);
            return true;
        }
        return false;
    }
    
    public void RemoveItem(Item itemToRemove)
    {
        foreach (InventorySlot slot in slots)
        {
            if (slot.item != null && slot.item.itemName == itemToRemove.itemName)
            {
                slot.RemoveFromStack(itemToRemove.quantity);
                if (slot.quantity <= 0)
                {
                    slots.Remove(slot);
                }
                return;
            }
        }
    }
}
