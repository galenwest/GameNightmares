using UnityEngine;
using UnityEngine.UI;

public class _ScoreManager : MonoBehaviour
{
    public static int score;

    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
        score = 0;
    }

    void Update()
    {
        text.text = "Score: " + score;
    }
}
