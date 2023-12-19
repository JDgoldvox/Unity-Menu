using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("ShopMenu");
    }

    public void Options()
    {
        SceneManager.LoadScene("OptionsMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
