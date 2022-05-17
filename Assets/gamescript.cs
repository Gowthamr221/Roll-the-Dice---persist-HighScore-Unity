
using UnityEngine;
using UnityEngine.UI;
public class gamescript : MonoBehaviour
{
    public Text score;
    public Text HighScore;
    // Start is called before the first frame update
    public int HighScoreValue=0;
    private void Start()
    {
        HighScoreValue = PlayerPrefs.GetInt("HighScore", 0);
        HighScore.text = HighScoreValue.ToString(); 
    }
    public void RollDice()
    {
        int value = Random.Range(0, 7);
        score.text = value.ToString();
        if(value > HighScoreValue) HighScoreValue = value;
        HighScore.text = HighScoreValue.ToString();
        PlayerPrefs.SetInt("HighScore", HighScoreValue);
    }

    public void Reset()
    {
        HighScoreValue = 0;
        PlayerPrefs.SetInt("HighScore", 0);
        score.text = "0";
        HighScore.text = "0";
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
