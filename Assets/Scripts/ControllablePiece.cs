using System.Collections.Generic;
using UnityEngine;

public class ControllablePiece : MonoBehaviour
{
    private Spawner spawner;
    private IMoveable piece;
    private PieceStorage pieceStorage;
    private Coordinate coordinate;
    void OnMouseDown(){
        spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>();
        piece = gameObject.GetComponent(typeof(IMoveable)) as IMoveable;
        pieceStorage = GameObject.FindGameObjectWithTag("PieceStorage").GetComponent<PieceStorage>();
        pieceStorage.StorePiece(gameObject);
        spawner.DestroyAllSquaresToMove();
        spawner.SpawnSquaresToMove(piece.GetAvailableSquares());
    }
    public void Move(Coordinate.Point coordinateToMove) {
        coordinate = gameObject.GetComponent<Coordinate>();
        coordinate.ApplyCoordinates(coordinateToMove);
    }
}
