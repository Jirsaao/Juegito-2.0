using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpController : MonoBehaviour
{
   internal bool pucSaltar = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)

    {

        pucSaltar = true;
        GameObject.Find("Player").GetComponent<Animator>().SetBool("salto", false);

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        pucSaltar = false;
        GameObject.Find("Player").GetComponent<Animator>().SetBool("salto", true);
    }

}
