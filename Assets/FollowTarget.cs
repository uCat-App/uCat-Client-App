using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;  // Reference to the target GameObject (set in the Unity Inspector)
    public float speed = 5.0f;  // Speed at which the follower moves

    public bool moving;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            moving = !moving;
        }

        if (target != null && moving)
        {
            // Calculate the direction from the follower to the target
            Vector3 direction = target.position - transform.position;

            // Normalize the direction vector to get a unit vector
            direction.Normalize();

            // Move the follower towards the target
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
