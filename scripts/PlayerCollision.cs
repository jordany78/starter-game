using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playerMovement1 movement;

    void OnCollisionEnter (Collision collisonInfo)
    {
        if (collisonInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager1>().EndGame();
        }
    }
}
