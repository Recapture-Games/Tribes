using UnityEngine;

public class DoorInteractable : MonoBehaviour, IInteractable
{
    // Whether or not the door is currently open
    private bool isOpen = false;

    // The angle that the door is open by (0 for closed, 90 for fully open)
    private float openAngle = 90f;

    // The speed at which the door opens/closes
    public float openSpeed = 2f;

    // The sound that plays when the door opens/closes
    public AudioClip openSound;
    public AudioClip closeSound;

    // Reference to the audio source component
    private AudioSource audioSource;

    // Cache the transform component for performance
    private Transform transform;

    private void Awake()
    {
        // Get references to the audio source and transform components
        audioSource = GetComponent<AudioSource>();
        transform = GetComponent<Transform>();
    }

    public void OnInteract()
    {
        // If the door is already open, close it
        if (isOpen)
        {
            // Calculate the target rotation for the door (closed position)
            Quaternion targetRotation = Quaternion.Euler(0, 0, 0);

            // Smoothly rotate the door towards the target rotation
            StartCoroutine(RotateTowards(targetRotation));

            // Play the close sound
            audioSource.PlayOneShot(closeSound);

            // Set isOpen to false
            isOpen = false;
        }
        // If the door is closed, open it
        else
        {
            // Calculate the target rotation for the door (open position)
            Quaternion targetRotation = Quaternion.Euler(0, openAngle, 0);

            // Smoothly rotate the door towards the target rotation
            StartCoroutine(RotateTowards(targetRotation));

            // Play the open sound
            audioSource.PlayOneShot(openSound);

            // Set isOpen to true
            isOpen = true;
        }
    }

    private IEnumerator RotateTowards(Quaternion targetRotation)
    {
        // Loop until the door has reached its target rotation
        while (transform.rotation != targetRotation)
        {
            // Smoothly rotate the door towards the target rotation
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, openSpeed * Time.deltaTime);

            // Wait for the next frame
            yield return null;
        }
    }
}
