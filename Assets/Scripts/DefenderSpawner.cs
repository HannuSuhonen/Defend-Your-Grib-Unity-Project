using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderSpawner : MonoBehaviour
{
    Defender defender;
    [SerializeField] int timeToDespawn;
    private void OnMouseDown()
    {
        if(!defender)
        {
            return;
        }
        AttemptToPlaceDefender(GetSquareClicked());
    }

    public void SetSelectedDefender(Defender defenderToSelect)
    {
        defender = defenderToSelect;
    }

    private Vector2 GetSquareClicked()
    {
        Vector2 clickPos = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 worldPos = Camera.main.ScreenToWorldPoint(clickPos);
        Vector2 gridPos = SnapToGrid(worldPos);
        return gridPos;
    }
    private Vector2 SnapToGrid (Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    private void SpawnDefender(Vector2 roundedPos)
    {
        if (!defender)
        {
            return;
        }
        Defender newDefender = Instantiate(defender,roundedPos, Quaternion.identity) as Defender;
    }
    private void AttemptToPlaceDefender(Vector2 gridPos)
    {
        var starDisplay = FindObjectOfType<StarDisplay>();
        int defenderCost = defender.GetStarCost();
        if(starDisplay.EnoughStar(defenderCost))
        {
            SpawnDefender(gridPos);
            starDisplay.SubtractStars(defenderCost);
        }
        //If enough stars
            //Spawn
            //Spend the monies
    }
}