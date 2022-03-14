using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    public Transform player;
    public Text score;
    bool valid = true;
    float ScoreNum;
     // Update is called once per frame
    void Update()
    {
        if (valid == true)
        {
            ScoreNum = player.position.z-1;
        }

        if (player.position.y < -1)
        {
            valid = false;
        }

        if (valid == false)
        {
            score.text = ScoreNum.ToString("0");
        }

        else
        {
            score.text = player.position.z.ToString("0");
        }
    }
}
