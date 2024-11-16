using UnityEngine;

public class SquareToMove : MonoBehaviour
{
    private PieceStorage pieceStorage;
    private IMoveable piece;
    private void Start() {
        //pieceStorage = GameObject.FindGameObjectWithTag("PieceStorage").GetComponent(typeof(IMoveable)) as IMoveable;
        pieceStorage = GameObject.FindGameObjectWithTag("PieceStorage").GetComponent<PieceStorage>();
    }
    void OnMouseDown(){
        piece = pieceStorage.GetStoredPiece() as IMoveable;
        piece.Move(GetComponent<Coordinate>().GetCoordinates());
    }
}
