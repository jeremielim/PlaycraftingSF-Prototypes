using UnityEngine;

public class PatrolMover : MonoBehaviour
{
	public float patrolTime = 1f;
	private float remainingPatrolTime;
	public Vector3 movementDirection = Vector3.back;

	void Start()
	{
        remainingPatrolTime = patrolTime;
    }


    public void Update()
    {
        remainingPatrolTime -= Time.deltaTime;

        //there's still patrol time left, so accelerate in our patrol direction
        if ( remainingPatrolTime > 0.0f )
        {
			transform.Translate(movementDirection * Time.deltaTime);
            // controlledMover.AccelerateInDirection( new Vector2( movementDirection, 0.0f ) );
        }
        //we're out of patrol time, so if we've come to rest by now, reverse direction and continue
        else
        {
            // movementDirection *= -1;
			movementDirection = -movementDirection;

            remainingPatrolTime = patrolTime;
        }
    }

    // void Update()
    // {
    //     // transform.Translate += transform;
    //     if (transform.position.y <= -1.42f)
    //     {
    //         transform.Translate(Vector3.back * Time.deltaTime);
    //     }
    //     // else if (transform.position.y >= 0)
    //     // {
    //     //     transform.Translate(Vector3.back * Time.deltaTime);
    //     // }

    // }
}
