using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public int lives;
	public int characterIndex;
	private static GameManager gameManager;

	// Use this for initialization
	void Awake () {
		
		if(gameManager == null)
		{
			gameManager = this;
		}
		else if(gameManager != this)
		{
			Destroy(gameObject);
		}

		DontDestroyOnLoad(gameObject);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
