using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public playermovement link;
    public Transform player;

    private void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "obstacle")
        {
            link.enabled = false;
            FindObjectOfType<GameManager>().EndGame();    
        }
    }
}
