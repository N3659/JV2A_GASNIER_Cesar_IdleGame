using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.ShaderKeywordFilter;

public class Price_Upgrade : MonoBehaviour
{

    public ScoreManager _scoreManager;

    private int Price_Upgrade_Pclic, Price_Upgrade_AC, Price_Upgrade_UD;

    public TextMeshProUGUI Price_Text_Pclic, Price_Text_AC, Price_Clic_UB ;

    public ClassicClic classicClic;

    public Autoclicker startAutoClicker;

    public Upgrade_Drink Unlocked;

    void Start()
    {
        Price_Upgrade_Pclic = 10;
        Price_Upgrade_AC = 250;
        Price_Upgrade_UD = 1;

    }

    public void Rise_Cost_Pclic (int amount)
    {
        if (_scoreManager._score >= Price_Upgrade_Pclic)
        {
            _scoreManager.RiseScore(-Price_Upgrade_Pclic);
            Price_Upgrade_Pclic = Price_Upgrade_Pclic * amount;
            Price_Text_Pclic.text = Price_Upgrade_Pclic.ToString();
            classicClic.UpgradeClick();
        }
    }

    public void Rise_Cost_AC(int amount)
    {

        if (_scoreManager._score >= Price_Upgrade_AC)
        {
            _scoreManager.RiseScore(-Price_Upgrade_AC);
            Price_Upgrade_AC = Price_Upgrade_AC * amount;
            Price_Text_AC.text = Price_Upgrade_AC.ToString();
            startAutoClicker.StartAutoClicker();
        }

    }

    public void Rise_Cost_UB(int amount)
    {
        if (_scoreManager._score >= Price_Upgrade_UD)
        {
            _scoreManager.RiseScore(-Price_Upgrade_UD);   
            Price_Upgrade_UD = Price_Upgrade_UD * amount;
            Price_Clic_UB.text = Price_Upgrade_UD.ToString();
            Unlocked.UnlockDrink();
        }
    }
}
