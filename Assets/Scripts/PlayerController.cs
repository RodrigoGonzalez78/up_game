using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float speedY = 3f;

    [SerializeField]//Muestras la variables Privadas
    private Rigidbody2D rb;
    public GameObject effect;
    public GameObject haro;
    

    
    void Start()
    {
        if (Time.timeScale != 1)
        {
            Time.timeScale = 1f;
        }
        
        rb.velocity = new Vector2(0f, speedY);
    }

    void Update()
    {
        MovilController();
        Controller();
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            Exit();
        }

    }
    void Controller()
    {


        Vector3 mov = new Vector2(Input.GetAxisRaw("Horizontal"), 0).normalized;

        transform.position = Vector2.MoveTowards(transform.position, transform.position + mov, speed * Time.deltaTime);


    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GetComponent<TrailRenderer>().enabled = false;
        GetComponent<SpriteRenderer>().enabled = false;
        haro.GetComponent<SpriteRenderer>().enabled = false;
       
        
        Instantiate(effect, transform.position, Quaternion.identity);

        Invoke("Reload", 0.3f);
    }

    void Reload()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Exit()
    {

        SceneManager.LoadScene("MainMenu");
    }

    void MovilController() 
    {
        float x = 0f;

        
        if (Input.GetMouseButton(0)) 
        {
            Vector2 mousePosition =Camera.main.ScreenToWorldPoint (Input.mousePosition);


                if (!(mousePosition.y > transform.position.y)) 
                {
                    if (mousePosition.x > 0f)
                    {
                        x = 5f;

                    }
                    if (mousePosition.x < 0f)
                    {
                        x = -5f;

                    }
                }
                
        }
        
        Vector3 mov = new Vector2(x, 0).normalized;

        transform.position = Vector2.MoveTowards(transform.position, transform.position + mov, speed * Time.deltaTime);
       
        
    }
}
