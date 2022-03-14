using UnityEngine;

public class playermovement : MonoBehaviour
{
    public Rigidbody rb;
    public int fforce=2500;
    public int sideforce;
    public Transform pos;
    // Update is called once per frame
    void FixedUpdate()
    {
        if(pos.position.z>=100)
        {
            fforce = 5000;
        }
        rb.AddForce(0, 0, fforce * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sideforce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-sideforce*Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if(pos.position.y<-1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    
}
