using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointAI : MonoBehaviour
{
    [SerializeField]    private float speed = 1f;
    [SerializeField]    private GameObject goal;
    [SerializeField]    private GameObject goal2;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // homework: once the square has reached the goal, move towards
    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(transform.position, goal.transform.position);

        if (distance > 0.05f)
        {
            Vector2 direction = (goal.transform.position - transform.position).normalized;
            Vector2 position = transform.position;
            position += (direction * speed * Time.deltaTime);
            transform.position = position;
        }
        else
        {
            Vector2 direction = (goal2.transform.position - transform.position).normalized;
            Vector2 position = transform.position;
            position += (direction * speed * Time.deltaTime);
            transform.position = position;
        }


        // direction = direction.normalized;
        // direction.Normalize();



        /*        speedX = 0;
                speedY = 0;

                if (Input.GetKey(KeyCode.W))
                {
                    speedY = 50f;
                }

                if(Input.GetKey(KeyCode.S))
                {
                    speedY = -50f;
                }

                if(Input.GetKey(KeyCode.D))
                {
                    speedX = 50f;
                }

                if (Input.GetKey(KeyCode.A))
                {
                    speedX = -50f;
                }*/
    }
}
