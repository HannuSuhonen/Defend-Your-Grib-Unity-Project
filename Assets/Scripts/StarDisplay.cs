using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StarDisplay : MonoBehaviour
{
    [SerializeField] int stars = 100;
    Text starCounter;

    void Start()
    {
        starCounter = GetComponent<Text>();
        UpdateStarCounter();
    }

    private void UpdateStarCounter()
    {
        starCounter.text = stars.ToString();
    }

    public void AddStars(int amount)
    {
        stars += amount;
        UpdateStarCounter();
    }

    public void SubtractStars(int amount)
    {
        if(stars <= amount)
        {
            return;
        }
        stars -= amount;
        UpdateStarCounter();
    }

    public bool EnoughStar(int amount)
    {
        return stars >= amount;
    }
}
