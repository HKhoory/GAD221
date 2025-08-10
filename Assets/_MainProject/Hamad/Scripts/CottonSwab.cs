using UnityEngine;
using UnityEngine.UI;

public class CottonSwab : MonoBehaviour
{

    [SerializeField] private Transform originalPos;

    [SerializeField] private bool isPushed;
    [SerializeField] private bool isInUse;

    [SerializeField] private float amount; //5

    [SerializeField] private float yDistance;

    [SerializeField] private Slider _slider;
    [SerializeField] private Rigidbody _rb;
    
    //[SerializeField] private Collider col;
    [SerializeField] private BoxCollider _b;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isPushed = false;
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            isInUse = !isInUse;
        }

        if (!isInUse)
            return;

        //if thing is stopped using
        //return to original pos
        //do check if it is already there before use

        if (_slider.value == 0f)
        {
            amount = 0f;
        }
        else amount = _slider.value;

        if (amount <= 0)
        {
            //_b.enabled = false;
            if (!isPushed)
            {
                _rb.AddForce(0, yDistance, 0);
                isPushed = true;
            }

        }
        else if (!_b.enabled)
        {
            //_b.enabled = true;
        }

        if (Physics.Raycast(transform.position, Vector3.down, Mathf.Infinity, 0))
        {

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Solution"))
        {

            _slider.value = _slider.maxValue;
            _rb.AddForce(0, -yDistance, 0);
            isPushed = false;
            //increase the thing
        }
        else if (other.CompareTag("Debris2"))
        {
            _slider.value -= 50f * Time.deltaTime;
            //minus the thing
        }
    }

}
