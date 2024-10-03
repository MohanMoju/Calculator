using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public void Gun()
    {
        SceneManager.LoadScene(1);
    }
    public void Out()
    {
        Application.Quit();
    }
}
