using UnityEngine;
using System.Collections;

public class AtributosGenerales : MonoBehaviour {

    public static int life=3;
    public static int speed=10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.Translate(Vector3.right*AtributosGenerales.speed*Time.deltaTime);
	
	}
}
