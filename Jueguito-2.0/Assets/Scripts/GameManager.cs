using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine(CreaCerezas());
    }

    // Update is called once per frame
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
            yield return new WaitForSeconds(4f);
        }
    }

}
