using UnityEngine;

public class GameState : MonoBehaviour
{

    [SerializeField] public static bool isCleaning;

    [SerializeField] private Camera playerCam;
    [SerializeField] private Camera cleaningCam;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isCleaning = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isCleaning)
        {
            playerCam.enabled = false;
            cleaningCam.enabled = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
            //view of the workstation
        }
        else
        {
            playerCam.enabled = true;
            cleaningCam.enabled = false;
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            //view of the player
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isCleaning)
            {
                isCleaning = !isCleaning;
            }
            else isCleaning = !isCleaning;
        }

    }
}
