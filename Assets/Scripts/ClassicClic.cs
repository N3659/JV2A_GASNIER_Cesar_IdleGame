using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassicClic : MonoBehaviour
{
    public int ClickPower ;
    public ScoreManager scoreManager;


    public void UpgradeClick()
    {
        ClickPower = ClickPower*2;
    }

    public void ClickWithPower(int factor = 1)
    {
        scoreManager.RiseScore(ClickPower*factor);
    }

}