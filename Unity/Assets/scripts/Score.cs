using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoretext;
    bool valid = true;
       // Update is called once per frame
    void Update()
    {
        if(player.position.y<-1)
        {
            valid = false;
        }
        if(valid==true)
        {
            scoretext.text = player.position.z.ToString("0");
        }
    }
}
