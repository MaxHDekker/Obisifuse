using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollide : MonoBehaviour {

    private float Size;
    public Material[] myMaterials = new Material[3];

    public burgerBar healthbar;
    public GameObject health;


    public Time time;

    public void Start()
    {
        healthbar = health.GetComponent<burgerBar>();
        
    }

    void Update()
    {
        SizeIncrease();
        Size -= 0.00001f;

        if (Size <= 0)
        {
            Size = 0;
        }
    }

    void SizeIncrease()
    {
        myMaterials[0].SetFloat("_Amount", Size);
        myMaterials[1].SetFloat("_Amount", Size);
        myMaterials[2].SetFloat("_Amount", Size);
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "pickUp")
        {
            Size += 0.005f;
            Destroy(col.gameObject);
            healthbar.FillBar();
        }
    }
}
