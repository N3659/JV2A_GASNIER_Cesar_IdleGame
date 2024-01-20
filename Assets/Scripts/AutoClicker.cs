using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Autoclicker : MonoBehaviour
{

    public ScoreManager scoreManager;
    public int clickPower;
    public float timeBetClick = 1;

    public void StartAutoClicker()
    {
        StartCoroutine(AutoClicker());
    }

    private IEnumerator AutoClicker()
    {
        while (true)
        {
            scoreManager.RiseScore(clickPower);
            yield return new WaitForSeconds(timeBetClick);
        }
    }


}
