using UnityEngine;

public class Debris : MonoBehaviour
{

    [SerializeField] private MeshRenderer _material;

    [SerializeField] private int timesTillClean;

    [SerializeField] private GameObject step;

    private Material m;

    void Start()
    {
        _material.GetComponent<MeshRenderer>();
        m.SetInt("_ZWrite", 0);
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("DustTool"))
        {
            Debug.Log("dust");
            timesTillClean--;
            Color originColor = _material.material.color;
            originColor.a = _material.material.color.a - 0.40f;
            //m.color = colorTest;
            _material.material.color = new Color(_material.material.color.r, _material.material.color.g, _material.material.color.b, originColor.a);
            if (timesTillClean <= 0)
            {
                if (step != null)
                step.SetActive(false);
                //spawn particles
                Destroy(gameObject);
                
            }
            
        }
    }


}
