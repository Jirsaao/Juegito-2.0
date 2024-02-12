using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicialManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI  text_total_puntos;
    [SerializeField] private GameObject panelSeleccionaNivel;
    [SerializeField] private GameObject panelMenuInicial;
    [SerializeField] private TMP_InputField inputNameUser;
    public void clickNuevaPartida()
    {
        SceneManager.LoadScene("Lvl001");
    }
    private void Start()
    {
      int puntos =  PlayerStats.Instance.getPuntosTotales();
        text_total_puntos.text = puntos + "";
    }
    
    public void clickSeleccionNivel()
    {
        panelMenuInicial.SetActive(false);
        panelSeleccionaNivel.SetActive(true);
    }
    public void clickSeleccionaMenuInicio()
    {
        panelMenuInicial.SetActive(true);
        panelSeleccionaNivel.SetActive(false);

    }
    public void clickLoadNivel(string nombreNivel)
    {
        SceneManager.LoadScene(nombreNivel);
    }
    public void clickSaveNameUser()
    {
        string name = inputNameUser.text;
        PlayerPrefs.SetString("NameUser", name);

    }
}
