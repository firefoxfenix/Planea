using UnityEngine;
using System.Collections;

public class EliminarEnemigos : MonoBehaviour {


    // Update is called once per frame
    void Update() {


    }

    void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "MainCamera" || col.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

}
