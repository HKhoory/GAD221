using UnityEngine;

public class Draggable : MonoBehaviour
{

    [SerializeField] private Camera workstationCamera;
    Vector3 mousePosOffset;
    [SerializeField] private GameObject originalPos;


    private Vector3 GetMouseWorldPos ()
    {
        return workstationCamera.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseUp()
    {
        if (originalPos != null)
        {
            transform.position = originalPos.transform.position;
        }
    }

    private void OnMouseDown()
    {
        mousePosOffset = gameObject.transform.position - GetMouseWorldPos();
    }

    private void OnMouseDrag()
    {
        Vector3 pos = GetMouseWorldPos() + mousePosOffset;

        transform.position = new Vector3(pos.x, transform.position.y, pos.z);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
