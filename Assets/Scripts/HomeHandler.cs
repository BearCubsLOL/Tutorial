using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{

    public void startGame()
    {
        SceneManager.LoadScene("GamemodeSelector");
    }
}