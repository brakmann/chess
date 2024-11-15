using System.Collections.Generic;
using UnityEngine;

public class ControllablePiece : MonoBehaviour
{
    private Spawner spawner;
    private IMoveable mover;
    void OnMouseDown(){
        spawner = GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>();
        mover = gameObject.GetComponent(typeof(IMoveable)) as IMoveable;
        List<Coordinate.Point> spawnList = mover.GetAvailableSquares();
        spawner.SpawnSquaresToMove(spawnList);
    }
}
