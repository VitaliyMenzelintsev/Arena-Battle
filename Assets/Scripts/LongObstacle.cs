using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LongObstacle : MonoBehaviour
{
    [SerializeField] 
    private float speed;
    private Rigidbody enemyRB;
    private GameObject player;
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("SE");
    }

     void FixedUpdate()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized; // надо заблочить противникам возможность летать за игроком
        enemyRB.AddForce(lookDirection * speed);

        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
