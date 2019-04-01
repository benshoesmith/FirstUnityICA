using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
    Light myLight;
	// Use this for initialization
	void Start () {
        myLight = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.L))
        {
            myLight.enabled = !myLight.enabled;
        }
	}
}
