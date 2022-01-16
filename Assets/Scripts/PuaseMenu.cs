using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuaseMenu : MonoBehaviour
{
    public GameObject hambur;
    public GameObject menu;
    
    public void MenuPause(bool pause)
    {

        if (pause)
        {
            
            hambur.SetActive (false);
            menu.SetActive(true);
           
        }
        else 
        {
            
            hambur.SetActive(true);
            menu.SetActive(false);
           
        }
    
    
    }


}
