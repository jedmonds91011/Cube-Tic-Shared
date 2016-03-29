using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour {


	public void letsPlayButtonAction(int gameType)
    {
        //Application.LoadLevel("test2.5d");
        switch(gameType)
        {
            case 0:
                {
                    PlayerPrefs.SetInt("mode", 0);
                    SceneManager.LoadScene("MultiplayerScene");
                    break;
                }
            case 1:
                {
                    PlayerPrefs.SetInt("mode", 1);
                    SceneManager.LoadScene("SinglePlayerAIScene");
                    break;
                }
            default:
                {
                    PlayerPrefs.SetInt("mode", 2);
                    SceneManager.LoadScene("SinglePlayerScene");
                    break;
                }
        }
        
    }
}
