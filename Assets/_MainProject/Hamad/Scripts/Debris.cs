using UnityEngine;

public class Debris : MonoBehaviour
{

    [SerializeField] private Renderer _material;

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
            Color colorTest = m.color;
            timesTillClean--;
            colorTest.a = colorTest.a - 30;
            m.color = colorTest;
            if (colorTest.a < 30 || timesTillClean <= 0)
                Destroy(gameObject);
            //become transparent a bit
            //if it is so transparent
            //delete
            //and maybe spawn the particles
        }
    }


}
