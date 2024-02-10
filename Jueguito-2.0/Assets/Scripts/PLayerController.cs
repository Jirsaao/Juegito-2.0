using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerController : MonoBehaviour
{
    float esMovimiento = 0;
    int salto = 0;
    [SerializeField] float velocidadSalto = 0.05f;
    [SerializeField]float velocidadMovimiento = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        esMovimiento = Input.GetAxis("Horizontal");
        if(Input.GetKeyDown(KeyCode.Space))
        {
            salto = 1;
        }
    }
    private void FixedUpdate()
    {
        if(esMovimiento == 0)
        {
            GetComponent<Animator>().SetBool("run", false);
        }
        else
        {
            GetComponent<Animator>().SetBool("run", true);

        }
        if (esMovimiento > 0) {
            Vector3 nuevaPosicion = transform.position;
            nuevaPosicion.x += velocidadMovimiento;

            gameObject.transform.position = nuevaPosicion;
            esMovimiento = 0;

            Vector3 giro = transform.localScale;
            giro.x = Mathf.Abs(giro.x);
            transform.localScale = giro;
        }
        if (esMovimiento < 0) {
            transform.Translate(Vector3.left * velocidadMovimiento);
            Vector3 giro = transform.localScale;
            giro.x = - Mathf.Abs(giro.x);
            transform.localScale = giro;
            esMovimiento = 0;
        }
        if(salto == 1)
        {
            GetComponent<Animator>().SetBool("salto", true);

            Rigidbody2D rigidBody = gameObject.GetComponent<Rigidbody2D>();
            rigidBody.AddForce(new Vector2(0,velocidadSalto), ForceMode2D.Impulse);
            salto = 0;
        }else
        {
           // GetComponent<Animator>().SetBool("salto", false);

        }
    }
}
