using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoManager : MonoBehaviour
{
    public GameObject[] Objetos;
    public int CurrentIndex = 0;
    public int CurrentIndex2;
    bool XD;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < Objetos.Length; i++)
        {
            Objetos[i].SetActive(false);
        }

        CurrentIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (CurrentIndex < Objetos.Length)
            {
                DeActivateByIndex(CurrentIndex);
                CurrentIndex++;
                ActivateByIndex(CurrentIndex);
            }

            else
            {
                DeActivateByIndex(CurrentIndex);
                CurrentIndex = 0;
                ActivateByIndex(CurrentIndex);
            }

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (CurrentIndex > Objetos.Length)
            {
                DeActivateByIndex(CurrentIndex);
                CurrentIndex--;
                ActivateByIndex(CurrentIndex);
            }

            else
            {
                DeActivateByIndex(CurrentIndex);
                CurrentIndex = Objetos.Length - 1;
                ActivateByIndex(CurrentIndex);
            }
        }



    }

    void ActivateByIndex(int index)
    {
        Objetos[index].SetActive(true);
    }

    void DeActivateByIndex(int index)
    {
        Objetos[index].SetActive(false);
    }
}