using UnityEngine;
using System.Collections;

public class movimiento_foca : MonoBehaviour {
    public GameObject Avion;
    public int VelocidadX = 10;
    public int VelocidadY = 10;
    public int cercania = 10;
    bool impedir = true; 
    
	
	// Update is called once per frame
	void Update () {


        if (Vector3.Distance(new Vector3(this.gameObject.transform.position.x, 0, 0), new Vector3(Avion.gameObject.transform.position.x, 0, 0)) <= cercania  &&  impedir) {

            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(VelocidadX, VelocidadY), ForceMode2D.Impulse);
            impedir = false; 


        }




	}
}
