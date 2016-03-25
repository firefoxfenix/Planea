using UnityEngine;
using System.Collections;

public class AvionBehaviourScript : MonoBehaviour {

    public GameObject temporito;
    public bool vulnerable=true;

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
        else if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.right* AtributosGenerales.speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.left * AtributosGenerales.speed * Time.deltaTime);
        }

    }
    void OnCollisionEnter2D(Collision2D col)
    {

        if (col.gameObject.tag == "Enemy" )
        {
            AtributosGenerales.life--;
        }
        this.transform.position = temporito.transform.position;
        vulnerable = false;
        this.GetComponent<Collider2D>().isTrigger = true;
        Debug.Log("Muero");
        Invoke("VolverVulnerable",1.5f);
    }


    public void VolverVulnerable()
    {
        this.GetComponent<Collider2D>().isTrigger = false;
        vulnerable = true;
    }
}
