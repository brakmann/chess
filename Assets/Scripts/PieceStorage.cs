using Unity.VisualScripting;
using UnityEngine;

public class PieceStorage : MonoBehaviour
{
    private IMoveable storedPiece;
    private Spawner spawner;

    private void Start(){
        spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>();
    }
    public void StorePiece(IMoveable piece) {
        storedPiece = piece;
    }
    public IMoveable GetStoredPiece() { //null check
        return storedPiece;
    }
    public void EraseStorage() {
        spawner.DestroyAllSquaresToMove();

        //storedPiece = null;
    }
}