using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minion_shooting : MonoBehaviour
{
    public float speed = 0.1f;
    public float currentDistance;
    public float movement;
    public GameObject target;
     public float playerDistance = 5f;
    [SerializeField] EnemyMovement enemyMovement;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void FixedUpdate()
    {
        movement = speed * Time.fixedDeltaTime;
        currentDistance = Vector3.Distance(transform.position, target.transform.position);
       // Debug.Log(currentDistance);

        if (currentDistance > playerDistance && enemyMovement.pause.gamePaused == false)
        {


            transform.rotation = Quaternion.LookRotation(target.transform.position - transform.position, transform.up);

            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, movement);
            enemyMovement.shooting = false;
        }
    }
    
}
