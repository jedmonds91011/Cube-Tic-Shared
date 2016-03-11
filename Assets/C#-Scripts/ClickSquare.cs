using UnityEngine;
using System.Collections;
using UnityEngine.Networking;
using System.Collections.Generic;

public class ClickSquare : MonoBehaviour {
	
	public int side;
	public int x;
	public int y;

	public int xCount = 0;
	public int oCount = 0;
	
	public bool isUsed = false;

	public List<GameObject> myPieces;

	void Awake()
	{
		foreach (Transform child in transform) {
			myPieces.Add (child.gameObject);
		}
	}
		
	// Change for touch
	void OnMouseDown () 
	{

		if (GameManager.instance.hasBeenSpun && !GameManager.instance.cubeSpinning) 
		{
			GameManager.instance.playSquare (gameObject);
		}
		else
		{
			GameManager.instance.UpdateInfo("Gotta Spin before you can Click!");
		}
//			if(!isUsed)
//			{
//				foreach(Transform child in transform)
//				{
//					if(child.name == GameManager.instance.playerObjName[GameManager.instance.currentPlayer])
//					{
//						GameManager.instance.source.PlayOneShot(GameManager.instance.soundClips[4]);
//						//child.active = true; DIDN'T WORK W/ 5.0
//						child.gameObject.SetActive(true);
//						//Debug.Log( "BEFORE " + this.gameObject.name + " asides[" + side + "]= " + GameManager.instance.aSides[side] + " @ " + Time.time);
//						isUsed = true;
//						int answer = (side * 100) + (x * 10) + (y * 1);
//						GameManager.instance.aSquares[answer] = GameManager.instance.currentPlayer;
//						GameManager.instance.clickCount++;
//						GameManager.instance.aSides[side-1]++;
//						GameManager.instance.hasBeenSpun = false;
//						//Debug.Log( "AFTER IS........ asides[" + side + "]= " + GameManager.instance.aSides[side] + " @ " + Time.time);
//					}	
//				}
//				CheckForWinner();
//				ChangePlayer();
//				if(!GameManager.instance.gameIsOver) 
//				{
//					GameManager.instance.UpdateInfo("Ok, " + GameManager.instance.playerName[GameManager.instance.currentPlayer] + " it's your turn to Spin");
//			
//				}
//			}
//			else
//			{
//				GameManager.instance.UpdateInfo("Come on, Pick an Empty Square!");
//			}
//		}
//		else
//		{
//			GameManager.instance.UpdateInfo("Gotta Spin before you can Click!");
//		}
	}

	

}