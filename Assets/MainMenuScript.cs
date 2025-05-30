using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadSceneAsync("GameScene");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
