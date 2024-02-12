using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicialManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI  text_total_puntos;
     public void clickNuevaPartida()
    {
        SceneManager.LoadScene("Lvl001");
    }
    private void Start()
    {
      int puntos =  PlayerStats.Instance.getPuntosTotales();
        text_total_puntos.text = puntos + "";
    }
}
