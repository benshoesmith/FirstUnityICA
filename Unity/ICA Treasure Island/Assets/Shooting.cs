using UnityEngine;
using System.Collections;

public class Shooting : MonoBehaviour {

    public Rigidbody bullet;
    public int power = 1500;

    public float lifeTime;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody newInstance = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            newInstance.AddForce(fwd * power, ForceMode.Force);

        }

        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(bullet);
        }
	
	}
}
