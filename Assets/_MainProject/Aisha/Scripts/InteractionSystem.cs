using Unity.VisualScripting;
using UnityEngine;

public class InteractionSystem : MonoBehaviour
{
    [SerializeField] private Transform raycastOrigin;
    private float rayDistance = 6f;
    public LayerMask interactable;

    [SerializeField] private Transform paintingContainer;
    private GameObject heldPainting = null;
    [SerializeField] private float objectScale;
    [SerializeField] private Vector3 placedScale;
    void Update()
    {
        RaycastHit hit;

        Debug.DrawRay(raycastOrigin.position, raycastOrigin.forward * rayDistance, Color.red);

        if (Physics.Raycast(raycastOrigin.position, raycastOrigin.forward, out hit, rayDistance, interactable))
        {
            Debug.Log("object detected" + hit.transform.name);

            GameObject target = hit.transform.gameObject;

            if (Input.GetKeyDown(KeyCode.E))
            {
                if(heldPainting == null && target.CompareTag("Painting"))
                {
                    PickUpObject(target);
                }
                else if (heldPainting != null && target.CompareTag("Placement"))
                {
                    PlaceObject(target.transform);
                }
                else if(heldPainting != null && target.CompareTag("WallPlacement"))
                {
                   ReturnObject(target.transform);
                }
            }
        }

    }

    void PickUpObject(GameObject painting)
    {
        heldPainting = painting;
        heldPainting.transform.SetParent(paintingContainer);
        heldPainting.transform.localPosition = Vector3.zero;
        heldPainting.transform.localScale = Vector3.one * objectScale;
        heldPainting.transform.localRotation = Quaternion.identity;

        Rigidbody rb = heldPainting.GetComponent<Rigidbody>();

        if(rb != null)
        {
            rb.isKinematic = true;
            rb.detectCollisions = false;
        }

        Debug.Log("Picked up: " + heldPainting.name);
    }

    void PlaceObject(Transform placementLocation)
    {
        heldPainting.transform.SetParent(null);
        heldPainting.transform.position = placementLocation.position;
        heldPainting.transform.rotation = placementLocation.rotation;
        heldPainting.transform.localScale = placedScale;

        Rigidbody rb = heldPainting.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.isKinematic = false;
            rb.detectCollisions = true;
        }

        Debug.Log("Object Placed: " + heldPainting.name);
        heldPainting = null;
    }

    void ReturnObject(Transform placementLocation)
    {
        heldPainting.transform.SetParent(null);
        heldPainting.transform.position = placementLocation.position;
        heldPainting.transform.rotation = placementLocation.rotation;
        heldPainting.transform.localScale = Vector3.one;

        Rigidbody rb = heldPainting.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.isKinematic = false;
            rb.detectCollisions = true;
        }

        Debug.Log("Object Placed: " + heldPainting.name);
        heldPainting = null;
    }
}
