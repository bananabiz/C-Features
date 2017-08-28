using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Breakout
{
public class ScoreManager : MonoBehaviour
    {
        public int score;
        public Text scoreText;

        // Use this for initialization
        void Start()
        {
            scoreText = this.GetComponent<Text>();
        }

	    void Update ()
        {
            if (score < 150)
            {
                scoreText.text = "Score: " + score.ToString();
            }
            else if (score == 150)
            {
                scoreText.text = "STAGE CLEAR!";
                Application.Quit();
            }
	    }
    }
}
