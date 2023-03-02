using UnityEngine;

public class Tree : MonoBehaviour
{
    public int woodAmount = 10;
    public float chopDuration = 2f;

    private bool isBeingChopped = false;
    private float currentChopTime = 0f;

    private void Update()
    {
        if (isBeingChopped)
        {
            currentChopTime += Time.deltaTime;

            if (currentChopTime >= chopDuration)
            {
                isBeingChopped = false;
                currentChopTime = 0f;

                // Destroy the tree and drop wood
                Destroy(gameObject);
                PlayerInventory.instance.AddItem(new WoodItem(woodAmount));
            }
        }
    }

    private void OnMouseDown()
    {
        if (!isBeingChopped)
        {
            isBeingChopped = true;

            // Play chop animation and sound
            GetComponent<Animator>().SetTrigger("Chop");
            GetComponent<AudioSource>().Play();
        }
    }
}