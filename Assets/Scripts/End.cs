using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{

    public string scene;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(scene);
    }

}
