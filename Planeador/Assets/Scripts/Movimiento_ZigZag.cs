using UnityEngine;
using System.Collections;

public class Movimiento_ZigZag : MonoBehaviour {
    public int speed = 10;
    bool arriba = true;
    int limite = 0;
    int cont = 0;
    // Use this for initialization
    void Start () {
	



	}
	
	// Update is called once per frame
	void Update () {
       
    
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
                this.transform.Translate(Vector3.up*speed*Time.deltaTime  );
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
}
