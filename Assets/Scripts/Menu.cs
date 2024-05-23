using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void jugar()
    {
         SceneManager.LoadScene(1);
    }
    public void creditos()
    {
         SceneManager.LoadScene(4);
    }
   public void atras()
    {
         SceneManager.LoadScene(3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
