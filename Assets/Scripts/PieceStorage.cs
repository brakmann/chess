using UnityEngine;

public class PieceStorage : MonoBehaviour
{
    private IMoveable storedPiece;
    public void StorePiece(IMoveable piece) {
        storedPiece = piece;
    }
    public IMoveable GetStoredPiece() { //null check
        return storedPiece;
    }

    public void EraseStorage() {
        storedPiece = null;
    }
}