using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject squareToMoveprefab;
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
}
