using UnityEngine;

public class PickUpAndPlace : MonoBehaviour, IInteractable
{

    public Transform player, paintingContainer, playerCamera, workBenchContainer;
    public bool equipped;
    public static bool slotFull;
    


    public void Interact()
    {
        equipped = true;
        slotFull = true;

        transform.SetParent(paintingContainer);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);
        transform.localScale = Vector3.one;
        
    }

    void Start()
    {
        
    }

    void Update()
    {
        if(!equipped && !slotFull && Input.GetKeyDown(KeyCode.E))
        {
            Interact();
        }
        else if(equipped && slotFull && Input.GetKeyDown(KeyCode.E))
        {
            transform.SetParent(workBenchContainer);
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.Euler(Vector3.zero);
            transform.localScale = Vector3.one;
        }
            
    }
}
