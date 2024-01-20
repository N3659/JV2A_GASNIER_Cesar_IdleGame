using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim_Shop : MonoBehaviour
{

    public float maxTime;
    public RectTransform rectTransform;
    private float timer;

    private int direction;
    // Start is called before the first frame update
    void Start()
    {

        timer = maxTime;
        direction = 0;
    }

    public void LaunchAnim()
    {
        direction *= -1;
        if(direction == 0) 
        { 
            direction = -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime*direction;
        timer = Mathf.Clamp(timer, 0, maxTime); 
        rectTransform.sizeDelta = Vector2.Lerp(new Vector2(100,200), Vector2.right * 100, timer/maxTime);
    }

}
