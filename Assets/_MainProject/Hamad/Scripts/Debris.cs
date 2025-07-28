using UnityEngine;

public class Debris : MonoBehaviour
{

    [SerializeField] private Renderer _material;
    [SerializeField] private GameObject _particle;

    [SerializeField] private int timesTillClean;

    private Material m;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _material = GetComponent<Renderer>();
        m = _material.material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("DustTool"))
        {
            Debug.Log("dust");
            Color colorTest = m.color;
            timesTillClean--;
            colorTest.a = colorTest.a - 10;
            m.color = colorTest;
            if (timesTillClean <= 0)
            {
                Destroy(gameObject);
                Instantiate(_particle, transform.position, Quaternion.identity);
            }
        }
    }


}
