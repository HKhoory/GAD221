using UnityEngine;

public class PaintingAllocator : MonoBehaviour
{

    //copied Aisha's code to be able to debug it without causing a git conflict

    [SerializeField] private Transform playerContainer, paintingContainer, workBenchContainer;
    public bool equipped;
    public static bool slotFull;

    [SerializeField] public bool isInProximity;
    [SerializeField] public bool isNearWorkbench;

    private Transform paintingScale;

    private void Awake()
    {
        paintingScale = gameObject.transform;
    }

    public void Handle()
    {
        equipped = true;
        slotFull = true;

        transform.SetParent(playerContainer);
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(Vector3.zero);
        transform.localScale = Vector3.one;

    }

    public void Place()
    {
        if (WorkbenchStatus.isOccupied && !isNearWorkbench)
        {
            transform.SetParent(paintingContainer);
            //or just return it back
        }
        else if (isNearWorkbench)
        {
            WorkbenchStatus.isOccupied = true;
        }

        
    }

    void Update()
    {
        if (isInProximity && Input.GetKeyDown(KeyCode.E))
        {
            Handle();
        }
        else if (isNearWorkbench && Input.GetKeyDown(KeyCode.E))
        {
            Place();
        }
        else if (!equipped && !slotFull && Input.GetKeyDown(KeyCode.E))
        {
            Handle();
        }
        else if (equipped && slotFull && Input.GetKeyDown(KeyCode.E))
        {
            transform.SetParent(workBenchContainer);
            transform.localPosition = Vector3.zero;
            transform.localRotation = Quaternion.Euler(Vector3.zero);
            transform.localScale = Vector3.one;
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInProximity = true;
        }

        else if (other.CompareTag("Workbench"))
        {
            isNearWorkbench = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isInProximity = false;
        }
        else if (other.CompareTag("Workbench"))
        {
            isNearWorkbench = false;
        }
    }

}
