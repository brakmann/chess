using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject squareToMoveprefab;
    [SerializeField] private GameObject blackPawnPrefab;
    [SerializeField] private GameObject blackBishopPrefab;
    [SerializeField] private GameObject blackKnightPrefab;
    [SerializeField] private GameObject blackRookPrefab;
    [SerializeField] private GameObject blackQueenPrefab;
    [SerializeField] private GameObject blackKingPrefab;



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
        GameObject bishop1 = Instantiate(blackBishopPrefab);
        bishop1.GetComponent<Coordinate>().ApplyCoordinates(new Coordinate.Point{x=2, y=0});
        GameObject bishop2 = Instantiate(blackBishopPrefab);
        bishop2.GetComponent<Coordinate>().ApplyCoordinates(new Coordinate.Point{x=5, y=0});
        //spawn knights
        GameObject knight1 = Instantiate(blackKnightPrefab);
        knight1.GetComponent<Coordinate>().ApplyCoordinates(new Coordinate.Point{x=1, y=0});
        GameObject knight2 = Instantiate(blackKnightPrefab);
        knight2.GetComponent<Coordinate>().ApplyCoordinates(new Coordinate.Point{x=6, y=0});
        //spawn rooks
        GameObject rook1 = Instantiate(blackRookPrefab);
        rook1.GetComponent<Coordinate>().ApplyCoordinates(new Coordinate.Point{x=0, y=0});
        GameObject rook2 = Instantiate(blackRookPrefab);
        rook2.GetComponent<Coordinate>().ApplyCoordinates(new Coordinate.Point{x=7, y=0});
        //spawn queen
        GameObject queen = Instantiate(blackQueenPrefab);
        queen.GetComponent<Coordinate>().ApplyCoordinates(new Coordinate.Point{x=3, y=0});
        //spawn king
        GameObject king = Instantiate(blackKingPrefab);
        king.GetComponent<Coordinate>().ApplyCoordinates(new Coordinate.Point{x=4, y=0});
    }
}
