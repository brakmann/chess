using System.Collections.Generic;
using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    public void ApplyTurnDamage(GameController.GameState turn){
        if (turn == GameController.GameState.blackTurn) {
            List<Coordinate.Point> squaresToDamage = new List<Coordinate.Point>();
            //for each black piece that has DealDamageComponent 
            //calculate square where the damage will be applied CalculateDamagedSquares
            //append lists
            //Then deal damage to every square
        }
    }
    private List<Coordinate.Point> CalculateDamagedSquares(Coordinate.Point piece) {
        List<Coordinate.Point> listToReturn = new List<Coordinate.Point>();
        return listToReturn;
    }

    private void RegisterDamageToSquare(Coordinate.Point square) {
        //if there is a gameobject with TakeDamage, register damage to it
    }

    private void RegisterDamageToPiece (GameObject piece){
        //if piece has 1hp destroy it
        GameObject.Destroy(piece);
    }
    
}
