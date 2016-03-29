using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AutoRotate : MonoBehaviour {

    Quaternion rotationTo;

    public Animator menuButton;
    public Animator SettingsButton;

    public Animator SettingsPanel;
    public Animator MenuPanel;
    public Animator FactsPanel;
    public Animator HelpPanel;
    public Animator UserPanel;

    public UserProfile mainUser;

    public Text FirstName;
    public Text LastName;
    public Text EmailAddr;
    public Text GamesPlayed;
    public Text GamesWon;
    public Text MagicSquares;
    public bool rotateCube = true;

    void Start () {
        CloseSettings();
        CloseMenu();
        CloseFacts();
        CloseHelp();
        CloseUser();
        rotationTo = Random.rotationUniform;
    }
	
	void Update () 
	{
		if (rotateCube) this.transform.RotateAround (transform.position, new Vector3(5f,10f, 1f),1f);

		//this.transform.rotation = Quaternion.Slerp (this.transform.rotation,rotationTo,1f*Time.deltaTime);
//		this.transform.rotation = Quaternion.Lerp (this.transform.rotation, rotationTo, Time.deltaTime);
//		//yield return new WaitForEndOfFrame();
//		if(Quaternion.Angle(this.transform.rotation,rotationTo) <= 15.0f)
//		{
//			rotationTo = Random.rotationUniform;
//		}

	}

    public void OpenSettings()
    {
        rotateCube = false;
        menuButton.SetBool("isHidden", true);
        SettingsButton.SetBool("isHidden", true);
        SettingsPanel.SetBool("isHidden", false);
    }

    public void CloseSettings()
    {
        menuButton.SetBool("isHidden", false);
        SettingsButton.SetBool("isHidden", false);
        SettingsPanel.SetBool("isHidden", true);
        rotateCube = true;
    }

    public void OpenMenu()
    {
        rotateCube = false;
        menuButton.SetBool("isHidden", true);
        SettingsButton.SetBool("isHidden", true);
        MenuPanel.SetBool("isHidden", false);
    }

    public void CloseMenu()
    {
        menuButton.SetBool("isHidden", false);
        SettingsButton.SetBool("isHidden", false);
        MenuPanel.SetBool("isHidden", true);
        rotateCube = true;
    }

    public void OpenFacts()
    {
        FactsPanel.SetBool("isHidden", false);
    }

    public void CloseFacts()
    {
        FactsPanel.SetBool("isHidden", true);
    }

    public void OpenHelp()
    {
        HelpPanel.SetBool("isHidden", false);
    }

    public void CloseHelp()
    {
        HelpPanel.SetBool("isHidden", true);
    }

    public void OpenUser()
    {
        UserPanel.SetBool("isHidden", false);
        FirstName.text = mainUser.firstName;
        LastName.text = mainUser.lastName;
        EmailAddr.text = mainUser.emailAddress;
        GamesPlayed.text = mainUser.gamesPlayed.ToString();
        GamesWon.text = mainUser.gamesWon.ToString();
        MagicSquares.text = mainUser.magicSquares.ToString();
    }

    public void CloseUser()
    {
        UserPanel.SetBool("isHidden", true);
    }

}
