using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CanvasManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI puntuacion;
    [SerializeField] private GameObject boton_pausa;
    [SerializeField] private GameObject menu_pausa;
    [SerializeField] private TextMeshPro nameUser;


    private void Start()
    {
        Time.timeScale = 1f;
        boton_pausa.SetActive(true);
        menu_pausa.SetActive(false);
        nameUser.text = PlayerPrefs.GetString("NameUser");
    }


    public void UpdateCherryPoints(int points)
    {
        puntuacion.text = points + "";
    }
    public void clickPausa()
    {
        Time.timeScale = 0;
        boton_pausa.SetActive(false);
        menu_pausa.SetActive(true);

    }
    public void clickResume()
    {
        Time.timeScale = 1f;
        boton_pausa.SetActive(true);
        menu_pausa.SetActive(false);
    }
    public void clickRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void clickFinaliza()
    {
        SceneManager.LoadScene("MenuInicial");
    }
}
