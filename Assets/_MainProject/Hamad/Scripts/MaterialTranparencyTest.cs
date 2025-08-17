using UnityEngine;

public class MaterialTranparencyTest : MonoBehaviour
{

    [SerializeField] private MeshRenderer _renderer;


    [Range(0f, 1f)] public float transparency;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _renderer.material.color = new Color(_renderer.material.color.r, _renderer.material.color.g, _renderer.material.color.b, transparency);
    }
}
