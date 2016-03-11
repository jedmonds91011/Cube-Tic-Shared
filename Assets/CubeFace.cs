using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CubeFace : MonoBehaviour {

    public List<GameObject> tiles;
    public List<List<GameObject>> possibleWins;

    void Start()
    {
        possibleWins = new List<List<GameObject>>();
        possibleWins.Add(new List<GameObject> { tiles[0], tiles[1], tiles[2] });
        possibleWins.Add(new List<GameObject> { tiles[3], tiles[4], tiles[5] });
        possibleWins.Add(new List<GameObject> { tiles[6], tiles[7], tiles[8] });
        possibleWins.Add(new List<GameObject> { tiles[0], tiles[3], tiles[6] });
        possibleWins.Add(new List<GameObject> { tiles[1], tiles[4], tiles[7] });
        possibleWins.Add(new List<GameObject> { tiles[2], tiles[5], tiles[8] });
        possibleWins.Add(new List<GameObject> { tiles[0], tiles[4], tiles[8] });
        possibleWins.Add(new List<GameObject> { tiles[2], tiles[4], tiles[6] });

    }
    public void checkForBestMoves()
    {

        GameManager.instance.possibleBlocks.Clear();
        GameManager.instance.possibleWins.Clear();
        GameManager.instance.possibleMoves.Clear();


        for (int i = 0; i < 9; i++)
        {
            if (!tiles[i].GetComponent<ClickSquare>().isUsed)
            {
                GameManager.instance.possibleMoves.Add(tiles[i]);
                foreach (List<GameObject> winRow in possibleWins)
                {
                    if (winRow.Contains(tiles[i]))
                    {
                        int numXs = 0;
                        int numOs = 0;

                        for (int j = 0; j < 3; j++)
                        {
                            ClickSquare tempTile = winRow[j].GetComponent<ClickSquare>();
                            if (tempTile.myPieces[0].GetActive())
                            {
                                numXs++;
                            }
                            else if(tempTile.myPieces[1].GetActive())
                            {
                                numOs++;
                            }
                        }
                        if(numOs == 2 )
                        {
                            GameManager.instance.possibleWins.Add(tiles[i]);
                        }
                        else if(numXs == 2)
                        {
                            GameManager.instance.possibleBlocks.Add(tiles[i]);
                        }
                    }
                }
            }
        }
       

        
    }

}
