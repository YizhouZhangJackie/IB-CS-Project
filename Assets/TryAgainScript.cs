using UnityEngine;
using UnityEngine.SceneManagement;

public class TryAgainScript : MonoBehaviour
{
    public void changeScene()
    {
        SceneManager.LoadSceneAsync("Main Menu");
    }
}
