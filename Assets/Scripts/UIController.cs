using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    public Transform player;
    public TMP_Text text;

    private float highestY;
    private float score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        highestY = player.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        if (player.position.y > highestY)
        {
            highestY = player.position.y;
            score = Mathf.RoundToInt(highestY * 10f);
        }

        text.SetText("Score: " + score);
    }
}
