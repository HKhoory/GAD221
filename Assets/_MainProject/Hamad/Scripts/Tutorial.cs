using UnityEngine;
using TMPro;

public class Tutorial : MonoBehaviour
{

    [SerializeField] public static bool hasPicked;
    [SerializeField] public static bool hasCleaned;

    [SerializeField] private TextMeshProUGUI tutorialText;
    [SerializeField] private GameObject tutorialPanel;

    [SerializeField] private string[] lines;

    [SerializeField] private int progression;
    [SerializeField] private GameObject[] steps;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tutorialText.text = string.Empty;
    }

    // Update is called once per frame
    void Update()
    {

        switch(progression)
        {
            case 0:
                tutorialText.text = lines[0];
                break;
            case 1:
                tutorialText.text = lines[1];
                break;
            default:
                tutorialText.text = lines[2];
                break;

        }

    }

    public void Progress()
    {
        progression++;
    }
}
