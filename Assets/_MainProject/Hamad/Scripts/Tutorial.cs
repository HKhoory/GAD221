using UnityEngine;
using TMPro;

public class Tutorial : MonoBehaviour
{

    [SerializeField] public static bool hasPicked;
    [SerializeField] public static bool hasCleaned;

    [SerializeField] private TextMeshProUGUI tutorialText;
    [SerializeField] private GameObject tutorialPanel;

    [SerializeField] private string[] lines;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tutorialText.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasPicked && !hasCleaned)
        {
            tutorialText.text = lines[0];
        }
        else if (hasPicked && !hasCleaned)
        {
            tutorialText.text = lines[1];
        }
        else
        {
            tutorialText.text = lines[2];
        }
    }
}
