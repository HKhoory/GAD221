using UnityEngine;

public class PCamera : MonoBehaviour
{

    [SerializeField] private float xAxis;
    [SerializeField] private float yAxis;

    public Transform orientation;

    float xRot, yRot;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * xAxis;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * yAxis;

        yRot += mouseX;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRot, yRot, 0);
        orientation.rotation = Quaternion.Euler(0, yRot, 0);

    }
}
