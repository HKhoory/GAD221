using UnityEngine;


[RequireComponent(typeof(Collider))]

public class PaintTransfer : MonoBehaviour
{


    [Header("Raycast")]

    [SerializeField] private Camera rayCamera;

    [SerializeField] private float maxDistance = 5f;

    [SerializeField] private LayerMask raycastMask = ~0;


    [Header("Canvases")]

    [SerializeField] private GameObject canvasToShow;

    [SerializeField] private GameObject canvasToHide;

    private Collider selfCol;

    private bool isHovering;



    private void Awake()
    {
        selfCol = GetComponent<Collider>();

        if (!rayCamera) rayCamera = Camera.main;

        SetState(false);




    }



    private void OnDisable()
    {

        SetState(false);


    }


    private void Update()
    {


        if (!rayCamera)
        {

            return;

        }

        bool hoverNow = false;

        Ray ray = rayCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit, maxDistance, raycastMask, QueryTriggerInteraction.Ignore))
        {

            hoverNow = hit.collider == selfCol || hit.collider.transform.IsChildOf(transform);

        }
        if (hoverNow != isHovering)
        {

            SetState(hoverNow);

        }

    }

    private void SetState(bool hover)
    {

        isHovering = hover;


        if (canvasToShow)
        {
            canvasToShow.SetActive(hover);
        }

        if (canvasToHide)
        {
            canvasToHide.SetActive(!hover);
        }


    }




}
