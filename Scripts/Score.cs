using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;

    public Text scoreText;

    public delegate void ScoreCountingStarted();
    public static event ScoreCountingStarted OnScoreCountingStarted;

    public delegate void Halfway();
    public static event Halfway OnHalfway;

    private void Start()
    {
        if (OnScoreCountingStarted != null)  // Check to see if there's actually listeners
        {
            OnScoreCountingStarted();
        }
    }

    // Update is called once per frame
    void Update () {
        scoreText.text = player.position.z.ToString("0");

        if (player.position.z > 75) // if score reaches over 75, trigger event, which specialText will listen for and act on
        {
            if (OnHalfway != null)
            {
                OnHalfway();
            }
        }

	}
}
