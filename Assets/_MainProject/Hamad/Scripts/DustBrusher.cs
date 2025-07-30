using UnityEngine;

public class DustBrusher : MonoBehaviour
{

    [SerializeField] private Transform originalLocation;
    [SerializeField] private float speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //if thing is inactive as a tool
        //transport it back to there
        //have a check if it is already there

        float xAxis = Input.GetAxisRaw("Horizontal");
        float zAxis = Input.GetAxis("Vertical");

        Vector3 pos = transform.position;
        pos = new Vector3(pos.x + (speed * xAxis), pos.y, pos.z + (speed * zAxis));
        transform.position = pos;
    }
}
