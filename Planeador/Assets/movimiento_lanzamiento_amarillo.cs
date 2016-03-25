using UnityEngine;
using System.Collections;

public class movimiento_lanzamiento_amarillo : MonoBehaviour {
    public GameObject Avion;
    public int speed = 10;
    public int speedLanzamiento = 1000;
    bool arriba = true;
    bool embestida = false;
    int limite = 0;
    int cont = 0;

	void Update () {
       if (embestida == false) {
            if (arriba == true)
            {
                this.transform.Translate(Vector3.up * speed * Time.deltaTime);
            }
            else
            {
                this.transform.Translate(Vector3.down * speed * Time.deltaTime);
            }
        }


        if (Vector3.Distance(new Vector3(0, this.gameObject.transform.position.y, 0), new Vector3(0, Avion.gameObject.transform.position.y, 0)) <= 1f  && Vector3.Distance(new Vector3(this.gameObject.transform.position.x, 0, 0), new Vector3(Avion.gameObject.transform.position.x, 0, 0)) <= 9f)
        {
            Debug.Log(Vector3.Distance(new Vector3(0, this.gameObject.transform.position.y, 0), new Vector3(0, Avion.gameObject.transform.position.y, 0)));
            this.transform.Translate(Vector3.left * speedLanzamiento * Time.deltaTime);
            embestida = true;

        }



    }


    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Main Camera")
        {
            if (arriba == true)
                arriba = false;
            else
                arriba = true;
        }

    }





    











}
