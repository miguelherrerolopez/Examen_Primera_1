using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BOLA_2 : MonoBehaviour {

    public string nombre;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        void OnTriggerEnter(Collider collider)
        {
            Destroy(this);
        }

    }
}
