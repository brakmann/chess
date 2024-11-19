using UnityEngine;

public class SquareToMove : MonoBehaviour
{
    private PieceStorage pieceStorage;
    private ControllablePiece piece;
    private void Start() {
        pieceStorage = GameObject.FindGameObjectWithTag("PieceStorage").GetComponent<PieceStorage>();
    }
    void OnMouseDown(){
        piece = pieceStorage.GetStoredPiece().GetComponent<ControllablePiece>();
        piece.Move(GetComponent<Coordinate>().GetCoordinates());
        pieceStorage.EraseStorage();
    }
}
