using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class burgerBar : MonoBehaviour {

    public Image fatBar;
    public Image healthBar;

    void Start()
    {
        fatBar.fillAmount = 0;
        healthBar.fillAmount = 1;
    }

    public void Update()
    {
        healthBar.fillAmount += 0.0004f;

        if (healthBar.fillAmount <= 0.001)
        {
            Application.LoadLevel(1);
            print("nigger");
        }
    }

    public void FillBar()
    {
        fatBar.fillAmount += 0.20f;
        healthBar.fillAmount -= 0.35f;
    }

}
