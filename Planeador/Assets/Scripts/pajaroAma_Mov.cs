using UnityEngine;
using System.Collections;

public class pajaroAma_Mov : MonoBehaviour {
    public GameObject Avion;
    public int speed = 10;
    public int speedLanzamiento = 1000;
    bool arriba = true;
    bool embestida = false;
    int limite = 0;
    int cont = 0;

	void Update () {
       if (embestida == false) {
            if (limite == cont)
            {
                limite = Random.Range(3, 30);


                if (arriba == true)
                    arriba = false;
                else
                    arriba = true;

                cont = 0;

            }
            else
            {
                if (arriba == true)
                {
                    this.transform.Translate(Vector3.up * speed * Time.deltaTime);
                    this.transform.Translate(Vector3.left * speed * Time.deltaTime);
                }
                else
                {
                    this.transform.Translate(Vector3.down * speed * Time.deltaTime);
                    this.transform.Translate(Vector3.left * speed * Time.deltaTime);
                }


                cont++;
            }
        }


        if (Vector3.Distance(new Vector3(0, this.gameObject.transform.position.y, 0), new Vector3(0, Avion.gameObject.transform.position.y, 0)) <= 1f )
        {
            this.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePositionY;
            this.transform.Translate(Vector3.left * speedLanzamiento * Time.deltaTime);
            embestida = true;
        }



    }








}
