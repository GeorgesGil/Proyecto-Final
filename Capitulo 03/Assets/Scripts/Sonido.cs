using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;


public class Sonido : MonoBehaviour
{
    // Start is called before the first frame update
	
	public GameObject window;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetKeyDown(KeyCode.V))
        {
            window.SetActive(!window.activeInHierarchy);
			
			
        }
    }
}
