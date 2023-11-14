using System.Collections;
using UnityEngine;

public class moveBarrel : MonoBehaviour
{
    public Vector3 moveUp = new Vector3(0f, 9f, 0f);//move barrel up
    public Vector3 moveDown = new Vector3(0f, 4f, 0f);//move barrel down
    public float Speed = 2.0f;//move barrel speed

    private bool Moving = false;//checks if barrel is moving

    void OnEnable()
    {
        // starts moving the barrel up and down
        StartCoroutine(isMoviing());
    }

    IEnumerator isMoviing()
    {
        while (true)
        {
            yield return StartCoroutine(MoveTo(moveUp));
            yield return StartCoroutine(MoveTo(moveDown));
        }
    }

    IEnumerator MoveTo(Vector3 targetPosition)
    {
        Moving = true;
        if(Moving == true)
        {

        
        while (Vector3.Distance(transform.position, targetPosition) > 1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, Speed * Time.deltaTime);
            yield return null;
        }
            Moving = false;
        }
        
    }
}
