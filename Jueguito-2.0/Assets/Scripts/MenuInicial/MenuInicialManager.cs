using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicialManager : MonoBehaviour
{
   
     public void clickNuevaPartida()
    {
        SceneManager.LoadScene("Lvl001");
    }
}
