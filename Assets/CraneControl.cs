using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraneControl : MonoBehaviour
{

    public Transform[] patrol;
    public int Speed;

    private int patrolPoint;
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        patrolPoint = 0;
        transform.LookAt(patrol[patrolPoint].position);
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(transform.position, patrol[patrolPoint].position);
        if (distance < 1f)
        {
            Increment();
        }
        goTo();
    }

    void goTo()
    {
        transform.Translate(Vector3.forward * Speed * Time.deltaTime);
    }

    void Increment()
    {
        patrolPoint++;
        if (patrolPoint >= patrol.Length)
        {
            patrolPoint = 0;
        }
        transform.LookAt(patrol[patrolPoint].position);

    }
}
