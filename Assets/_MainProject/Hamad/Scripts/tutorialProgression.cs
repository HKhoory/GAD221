using UnityEngine;

public class tutorialProgression : MonoBehaviour
{

    [SerializeField] private int increment;

    [SerializeField] private GameObject[] steps;

    void Start()
    {
        increment = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && steps[0].activeSelf && increment == 0)
        {
            steps[0].SetActive(false);
            steps[1].SetActive(true);
            increment++;
        }
        else if (Input.GetKeyDown(KeyCode.E) && steps[1].activeSelf && increment == 1)
        {
            steps[1].SetActive(false);
            steps[2].SetActive(true);
            increment++;
        }
        else if (Input.GetKeyDown(KeyCode.R) && steps[2].activeSelf && increment == 2)
        {
            steps[2].SetActive(false);
            steps[3].SetActive(true);
            increment++;
        }
        else if (Input.GetMouseButtonDown(0) && steps[3].activeSelf && increment == 3)
        {
            steps[3].SetActive(false);
            steps[4].SetActive(true);
            increment++;
        }
        else if (Input.GetMouseButtonDown(0) && steps[4].activeSelf && increment == 4)
        {
            steps[4].SetActive(false);

        }
    }
}
