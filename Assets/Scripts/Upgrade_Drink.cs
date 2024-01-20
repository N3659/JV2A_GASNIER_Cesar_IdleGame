using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade_Drink : MonoBehaviour
{
    public ScoreManager scoreManager;
    public List<Button> Drinks2;

    private int index;

    public void UnlockDrink()
    {
        if (index >= Drinks2.Count)
        {
            return;
        }

        Drinks2[index].interactable = true;
        index++;
    }
}
