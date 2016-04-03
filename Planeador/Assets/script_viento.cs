using UnityEngine;
using System.Collections;

public class script_viento : MonoBehaviour {

    public float velocidadX;
    public float velocidadY;
    public GameObject avion;
    public float cercania;
    bool parar = true;


	void Start () {
	
	}

    // Update is called once per frame
    void Update() {

        if (Vector3.Distance(new Vector3(this.gameObject.transform.position.x, 0, 0), new Vector3(avion.gameObject.transform.position.x, 0, 0)) <= cercania)
        {

            avion.GetComponent<Rigidbody2D>().AddForce(new Vector2(velocidadX, velocidadY), ForceMode2D.Force);
            parar = false;
        }
        else if (!parar){
            avion.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            avion.GetComponent<Rigidbody2D>().angularVelocity = 0;
            Destroy(this.gameObject);
        }
        



    }
}
