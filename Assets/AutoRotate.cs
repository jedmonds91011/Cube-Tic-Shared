using UnityEngine;
using System.Collections;

public class AutoRotate : MonoBehaviour {

    Quaternion rotationTo;

    public Animator menuButton;
    public Animator SettingsButton;

    public Animator SettingsPanel;
    public Animator MenuPanel;
    public Animator HelpPanel;

    public bool rotateCube = true;

    void Start () {
        CloseSettings();
        CloseMenu();
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

    public void OpenHelp()
    {
        rotateCube = false;
        menuButton.SetBool("isHidden", true);
        SettingsButton.SetBool("isHidden", true);
        HelpPanel.SetBool("isHidden", false);
    }

    public void CloseHelp()
    {
        menuButton.SetBool("isHidden", false);
        SettingsButton.SetBool("isHidden", false);
        HelpPanel.SetBool("isHidden", true);
        rotateCube = true;
    }
}
