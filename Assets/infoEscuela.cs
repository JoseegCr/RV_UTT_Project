using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class infoEscuela : MonoBehaviour
{
   public void retroceder(){
        SceneManager.LoadScene(0);
    }

    public void info(){
        SceneManager.LoadScene(4);
    }
}
