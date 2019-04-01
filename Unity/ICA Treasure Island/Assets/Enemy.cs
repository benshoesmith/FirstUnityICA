using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    public int health;
    public GameObject item;

    void Update ()
    {
        Debug.Log(health.ToString());

        

        if (health <= 0)
        {
            Instantiate(item, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}