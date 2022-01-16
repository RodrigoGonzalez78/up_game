using UnityEngine;
using UnityEngine.SceneManagement;

public class Button_Manager : MonoBehaviour
{
    

    public void LoadScenes(string name) 
    {
        SceneManager.LoadScene(name);
    
    }

    public void Exit() 
    {
        Application.Quit();
    }

    public void GooglePlayCalification(string url) 
    {
        Application.OpenURL(url);
    
    }

    public void Pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0f;
            FindObjectOfType<PuaseMenu>().MenuPause(true);
        }
        else
        {
            Time.timeScale = 1;
            FindObjectOfType<PuaseMenu>().MenuPause(false);
        }
        
    }

}
