using UnityEngine;

public class DustBrusher : MonoBehaviour
{

    [SerializeField] private float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xAxis = Input.GetAxisRaw("Horizontal");
        float zAxis = Input.GetAxis("Vertical");

        Vector3 pos = transform.position;
        pos = new Vector3(pos.x + (speed * xAxis), pos.y, pos.z + (speed * zAxis));
        transform.position = pos;
    }
}
