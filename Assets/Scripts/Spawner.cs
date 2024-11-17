using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject squareToMoveprefab;
    [SerializeField] private GameObject blackPawnPrefab;
    [SerializeField] private GameObject blackBishopPrefab;

    private void Start() {
        SpawnBlackChessPosition();
    }
    public void SpawnSquaresToMove (List<Coordinate.Point> coordinates) { //i must use pool
        foreach (Coordinate.Point coordinate in coordinates) {
            GameObject square = Instantiate(squareToMoveprefab);
            square.GetComponent<Coordinate>().ApplyCoordinates(coordinate);
        }        
    }
    public void DestroyAllSquaresToMove() {
        Debug.Log("Erase");
        GameObject[] gos = GameObject.FindGameObjectsWithTag("SquareToMove");
        foreach(GameObject go in gos)
            Destroy(go);
    }
    public void SpawnBlackChessPosition(){
        //spawn pawns
        for (int i=0; i<8; i++) {
            GameObject pawn = Instantiate(blackPawnPrefab);
            pawn.GetComponent<Coordinate>().ApplyCoordinates(new Coordinate.Point{x=i, y=1});
        }
        //spawn bishops
    }
}
