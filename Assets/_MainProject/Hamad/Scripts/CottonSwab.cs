using UnityEngine;
using UnityEngine.UI;

public class CottonSwab : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float amount;

    [SerializeField] private Slider _slider;
    
    //[SerializeField] private Collider col;
    [SerializeField] private BoxCollider _b;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (amount <= 0)
        {
            _b.enabled = false;
        }
        else if (!_b.enabled)
        {
            _b.enabled = true;
        }

        float xAxis = Input.GetAxisRaw("Horizontal");
        float zAxis = Input.GetAxis("Vertical");

        Vector3 pos = transform.position;
        pos = new Vector3(pos.x + (speed * xAxis), pos.y, pos.z + (speed * zAxis));
        transform.position = pos;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Solution"))
        {

            _slider.value = _slider.maxValue;
            //increase the thing
        }
        else if (other.CompareTag("Debris2"))
        {
            //minus the thing
        }
    }

}
