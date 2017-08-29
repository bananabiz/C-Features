using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
            if (score < 10)
            {
                scoreText.text = "Score: " + score.ToString();
            }
            else if (score == 10)
            {
                scoreText.text = "STAGE CLEAR!";
                SceneManager.LoadScene(0);
            }
	    }
    }
}
