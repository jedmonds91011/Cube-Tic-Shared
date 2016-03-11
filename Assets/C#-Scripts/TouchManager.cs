using UnityEngine;
using System.Collections;
using System.IO;
using UnityEngine.EventSystems;

public class TouchManager : MonoBehaviour, IPointerDownHandler {

	private Vector2 touchStart;
	private Vector2 touchEnd;
	private float timeDifference;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.touches.Length >0 && !GameManager.instance.gameIsOver)
		{
			Touch myTouch = Input.GetTouch(0);
			if(myTouch.phase == TouchPhase.Began)
			{
				touchStart = myTouch.position;
				touchEnd = myTouch.position;
				timeDifference = Time.time;
			}
			if(myTouch.phase == TouchPhase.Moved)
			{
				touchEnd = myTouch.position;
				if(timeDifference - Time.time > 0.1f)
				{
					GameManager.instance.resetButton.interactable = false;
					GameManager.instance.endGameButton.interactable = false;
				}
			}
			if(myTouch.phase == TouchPhase.Ended && !GameManager.instance.cubeSpinning && !GameManager.instance.hasBeenSpun)
			{
				float touchDelta = Mathf.Abs(touchEnd.x - touchStart.x)+ Mathf.Abs (touchEnd.y - touchStart.y);
				if(touchDelta > 75)
				{
					GameManager.instance.SpinButton();

				}
				GameManager.instance.resetButton.interactable = true;
				GameManager.instance.endGameButton.interactable = true;
			}
		}	
	}

	public void OnPointerDown(PointerEventData data)
	{
	}
}