using UnityEngine;

public class GameState : MonoBehaviour
{

    [SerializeField] public static bool isCleaning;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isCleaning)
        {
            //view of the workstation
        }
        else
        {
            //view of the player
        }
    }
}
