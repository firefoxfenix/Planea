using UnityEngine;
using System.Collections;

public class EliminarEnemigos : MonoBehaviour {


    // Update is called once per frame
    void Update() {


    }

    void OnCollision2DEnter(Collider2D col)
    {
        if (col.tag == "Camara")
        {
            Destroy(this.gameObject);
        }
    }

}
