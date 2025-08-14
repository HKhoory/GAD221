using UnityEngine;
using UnityEngine.Events;
public class StepEvents : MonoBehaviour
{

    public UnityEvent OnStart;
    public UnityEvent OnFinish;
    //public StepEvents nextStep; //other method

    private void OnEnable()
    {
        OnStart.Invoke();
    }

    private void OnDisable()
    {
        OnFinish.Invoke();
        //nextStep.gameObject.SetActive(true);
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
