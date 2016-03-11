using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

[RequireComponent(typeof(PhotonView))]
public class networkTest : Photon.MonoBehaviour
{
    public Button spinButton;
    public bool myTurn;
    public int myIndex;
    public string myTextBase;
    public PhotonView myPhotonView;
	public List<int> myMagicCubes;
    public bool isAI;


    void Awake()
    {
        myPhotonView = GetComponent<PhotonView>();
        myTextBase = "Player " + myIndex + ": " + myPhotonView.viewID;// + this.netId.ToString();
        GameManager.instance.networkIds.Add(myPhotonView.viewID);
        myIndex = GameManager.instance.players.Count;
    }

    [PunRPC]
    public void addPlayerToGmRPC()
    {
        GameManager.instance.players.Add(this);
    }

	void Update()
	{
        if (GameManager.instance.players.Count > 1)
        {
            if (this == GameManager.instance.players[GameManager.instance.currentPlayer])
            {
                myTurn = true;
            }
            else
            {
                myTurn = false;
            }
        }
	}
}