using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private CanvasManager canvasManager;

    public int numeroCherryDestroy = 0;
    void Start()
    {
      StartCoroutine(CreaCerezas());
    }
    void Update()
    {
        
    }
    bool creaCerezas = true;
    [SerializeField] GameObject cherryPrefab;

    IEnumerator CreaCerezas()
    {

        while (creaCerezas)
        {
            float posX = UnityEngine.Random.Range(-3.24f, 2.46f);
            float posY = UnityEngine.Random.Range(0f, 0.6f);

            posY = Mathf.Clamp(posY, -3.24f, 2.46f);

            Vector2 posicionCierra = new Vector2(posX, posY);
            Instantiate(cherryPrefab, posicionCierra, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }

    }

    public static GameManager Instance;

    public void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        PlayerStats.Instance.setPuntosActuales(0);
    }
    public void HitCherry()
    {
        int puntos = PlayerStats.Instance.addPuntosActuales(2);
        canvasManager.UpdateCherryPoints(puntos);
    }
    private void OnDestroy()
    {
        PlayerStats.Instance.addPuntosTotales(PlayerStats.Instance.getPuntosActuales());
    }

}
