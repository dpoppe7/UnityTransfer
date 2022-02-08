using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        
    }

    public void Tutoria(){
        //SceneManager.LoadScene("Scene1");
    }
    

    public void Play(){
        //SceneManager.LoadScene("Scene1");   
    }

    public void QuitButton(){
        Debug.Log("Quit");
        Application.Quit();
    }
}
