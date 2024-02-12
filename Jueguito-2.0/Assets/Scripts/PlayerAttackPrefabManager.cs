using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;
public class PlayerAttackPrefabManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SelfDestroy()
    {
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "candestroy")
        {
            Destroy(collision.gameObject);
            GameObject puntuacion = GameObject.Find("TextCherryUI");
            int cherryDestroyed = ++GameObject.Find("GameManager")
                .GetComponent<GameManager>().numeroCherryDestroy;
         //   puntuacion.GetComponent<TextMeshProUGUI>().SetText(cherryDestroyed+"");
        }
    }
}
