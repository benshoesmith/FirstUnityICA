using UnityEngine;
using System.Collections;
public class shooter2 : MonoBehaviour
{
    public Rigidbody bullet;
    public int power = 1500;
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Rigidbody newInstance = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            newInstance.AddForce(fwd * power, ForceMode.Force);
        }
    }
}