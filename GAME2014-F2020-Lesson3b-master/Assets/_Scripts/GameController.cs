using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public TMP_Text SceneLabel;
    public TMP_Text LivesLabel;
    public TMP_Text ScoreLabel;

    private ScreenOrientation screenOri;
    private Vector2 livesOffset;
    private Vector2 scoreOffset;

    // Start is called before the first frame update
    // Save relative positions, can rebuild proper position on orientation change
    // Uses the pivot
    void Start()
    {
        screenOri = Screen.orientation;
        livesOffset = LivesLabel.rectTransform.anchoredPosition;
        scoreOffset = ScoreLabel.rectTransform.anchoredPosition;

        LivesLabel.rectTransform.position =
            new Vector2(
                Screen.safeArea.xMin + 
                (Screen.safeArea.width * LivesLabel.rectTransform.pivot.x) +
                livesOffset.x,

                Screen.safeArea.yMin +
                (Screen.safeArea.height * LivesLabel.rectTransform.pivot.y) +
                livesOffset.y);
        
        ScoreLabel.rectTransform.position =
            new Vector2(
                Screen.safeArea.xMin + 
                (Screen.safeArea.width * ScoreLabel.rectTransform.pivot.x) +
                scoreOffset.x,

                Screen.safeArea.yMin +
                (Screen.safeArea.height * ScoreLabel.rectTransform.pivot.y) +
                scoreOffset.y);
    }

    // Update is called once per frame
    void Update()
    {        
        if(Screen.orientation != screenOri)
        {
            screenOri = Screen.orientation;
            LivesLabel.rectTransform.position =
            new Vector2(
                Screen.safeArea.xMin +
                (Screen.safeArea.width * LivesLabel.rectTransform.pivot.x) +
                livesOffset.x,

                Screen.safeArea.yMin +
                (Screen.safeArea.height * LivesLabel.rectTransform.pivot.y) +
                livesOffset.y);

            ScoreLabel.rectTransform.position =
                new Vector2(
                    Screen.safeArea.xMin +
                    (Screen.safeArea.width * ScoreLabel.rectTransform.pivot.x) +
                    scoreOffset.x,

                    Screen.safeArea.yMin +
                    (Screen.safeArea.height * ScoreLabel.rectTransform.pivot.y) +
                    scoreOffset.y);
        }       
    }
}
