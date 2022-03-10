using UnityEngine;

public class EndTriggger : MonoBehaviour
{
    public GameManager gM;
    public void OnTriggerEnter()
    {   
        gM.completelevel();
    }
}
