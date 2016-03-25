using UnityEngine;
using System.Collections;

public class AvionBehaviourScript : MonoBehaviour {


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.right * AtributosGenerales.speed * Time.deltaTime);
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(new Vector3(0,1*AtributosGenerales.speed * Time.deltaTime,0), Space.World);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(new Vector3(0,-1 * AtributosGenerales.speed * Time.deltaTime,0),Space.World);
        }

    }
}
