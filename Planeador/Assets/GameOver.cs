using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Exit()
    {
        Application.Quit();
    }

    public void Retry()
    {
        AtributosGenerales.life = 3;
        Application.LoadLevel("Mundo");
    }

    public void MainMenu()
    {
        Application.LoadLevel("MainMenu");
    }

}
