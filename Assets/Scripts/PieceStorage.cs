using Unity.VisualScripting;
using UnityEngine;

public class PieceStorage : MonoBehaviour
{
    private GameObject storedPiece;
    private Spawner spawner;

    private void Start(){
        spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>();
    }
    public void StorePiece(GameObject piece) {
        storedPiece = piece;
    }
    public GameObject GetStoredPiece() { //null check
        return storedPiece;
    }
    public void EraseStorage() {
        spawner.DestroyAllSquaresToMove();

        //storedPiece = null;
    }
}