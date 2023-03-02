using UnityEngine;

// ONLY Contains currentInteractable detect and set
// Designed to be ADDED to an actually functional PlayerContoller
public class PlayerController : MonoBehaviour
{
    [SerializeField] private float interactDistance = 2f;

    private Interactable currentInteractable;

    private void Update()
    {
        DetectInteractable();
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
    }

    private void DetectInteractable()
    {
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, interactDistance))
        {
            Interactable interactable = hit.collider.GetComponent<Interactable>();

            if (interactable != null && interactable != currentInteractable)
            {
                currentInteractable = interactable;
                Debug.Log($"Detected interactable: {currentInteractable.name}");
            }
        }
        else
        {
            currentInteractable = null;
        }
    }

    private void Interact()
    {
        if (currentInteractable != null)
        {
            currentInteractable.Interact();
        }
    }
}
