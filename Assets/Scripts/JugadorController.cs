using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class JugadorController : MonoBehaviour
{
        //Declaro la variable de tipo RigidBody que luego asociaremos a nuestro jugador
    private Rigidbody rb;

    private int contador;
    public Text textoContador, textoGanar, textoDatos;


    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        //Capturo esa variable al iniciar el juego
        rb=GetComponent<Rigidbody>();

        contador=0;
        setTextoContador();
        textoGanar.text="";
        textoDatos.text="Yamilka G. 2180529";
        



    }

    void Update(){

        float movimientoH=Input.GetAxis("Horizontal");
        float movimientoV=Input.GetAxis("Vertical");

        Vector3 movimiento=new Vector3(movimientoH,0.0f,movimientoV);

        rb.AddForce(movimiento * velocidad);


    }

    void OnTriggerEnter(Collider other){


        if(other.gameObject.CompareTag("Coleccionable")){


            other.gameObject.SetActive(false);
            contador=contador+1;

            setTextoContador();
        }


    }

    void setTextoContador(){


            textoContador.text="Contador:"+contador.ToString();

            if(contador>=12){

                textoGanar.text="Ganaste!";

            }


    }

}
