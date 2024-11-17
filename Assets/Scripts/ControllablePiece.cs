using System.Collections.Generic;
using UnityEngine;

public class ControllablePiece : MonoBehaviour
{
    private Spawner spawner;
    private IMoveable piece;
    private PieceStorage pieceStorage;
    void OnMouseDown(){
        spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>();
        piece = gameObject.GetComponent(typeof(IMoveable)) as IMoveable;
        pieceStorage = GameObject.FindGameObjectWithTag("PieceStorage").GetComponent<PieceStorage>();
        pieceStorage.StorePiece(piece);
        spawner.DestroyAllSquaresToMove();
        spawner.SpawnSquaresToMove(piece.GetAvailableSquares());
    }
}
