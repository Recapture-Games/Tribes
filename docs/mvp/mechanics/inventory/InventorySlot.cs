// InventorySlot.cs
[System.Serializable]
public class InventorySlot
{
    public Item item;
    public int quantity;

    public InventorySlot(Item item, int quantity)
    {
        this.item = item;
        this.quantity = quantity;
    }

    public void AddToStack(int amount)
    {
        quantity += amount;
    }

    public void RemoveFromStack(int amount)
    {
        quantity -= amount;
    }
}