using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GatherableResource : MonoBehaviour, IInteractable
{
    [SerializeField] private int resourceAmount = 5;
    [SerializeField] private Item resourceItem;
    
    [SerializeField] private float interactDuration = 2f;
    [SerializeField] private bool isBeingInteracted = false;
    [SerializeField] private  float currentInteractTime = 0f;

    private int currentResourceAmount;

    private void Start()
    {
        currentResourceAmount = resourceAmount;
    }

     private void Update()
    {
        if (isBeingInteracted)
        {
            currentInteractTime += Time.deltaTime;

            if (currentInteractTime >= interactDuration)
            {
                if (currentResourceAmount > 0)
                {
                    isBeingInteracted = false;
                    currentInteractTime = 0f;

                    // Destroy the tree and drop wood
                    Destroy(gameObject);
                    PlayerInventory.instance.AddItem(resourceItem);
                }
            }
        }
    }

    public void OnInteract(PlayerController playerController)
    {
        if (currentResourceAmount > 0)
        {
            currentResourceAmount--;

            if (currentResourceAmount == 0)
            {
                Destroy(gameObject);
            }

            playerController.Inventory.AddItem(resourceItem);
        }
    }
}
