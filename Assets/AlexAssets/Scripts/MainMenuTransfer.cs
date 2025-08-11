using UnityEngine;
using UnityEngine.SceneManagement;



public class MainMenuTransfer : MonoBehaviour
{

    [SerializeField] private string nameOfScene;

    public void SceneTransaction()
    {

        if (!string.IsNullOrEmpty(nameOfScene))
        {

            SceneManager.LoadScene(nameOfScene);

        }


    }
}
