using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;

    public delegate void PlayerCollided();
    public static event PlayerCollided OnPlayerCollided;

    void OnCollisionEnter(Collision collisionInfo) // gets info on item colliding into
    {
        if (collisionInfo.collider.tag == "Obstacle") // check to see if it's Obstacle
        {
            GetComponent<PlayerMovement>().enabled = false;

            if (OnPlayerCollided != null)
            {
                Debug.Log("OnPlayerCollided");
                OnPlayerCollided();
            }

            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
