using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{

    [SerializeField] private GameObject _mainCamera;
    [SerializeField] private GameObject _workstationCamera;

    private bool isCleaning;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _workstationCamera.SetActive(false);
        isCleaning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (!isCleaning)
            {
                _mainCamera.SetActive(true);
                _workstationCamera.SetActive(false);
                isCleaning = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
            }
            else
            {
                
                _mainCamera.SetActive(false);
                _workstationCamera.SetActive(true);
                isCleaning = false;
                Cursor.lockState = CursorLockMode.Confined;
                Cursor.visible = true;
            }
        }
    }
}
