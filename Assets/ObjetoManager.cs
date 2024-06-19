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
        DeactivateAll();
        CurrentIndex2 = Objetos.Length - 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (CurrentIndex == Objetos.Length)
            {
                CurrentIndex = -1;
            }

            CurrentIndex++;


            if (CurrentIndex < Objetos.Length && XD == false)
            {
                DeactivateAll();
                ActivateByIndex(CurrentIndex);
            }

        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            CurrentIndex--;



            if (CurrentIndex < 0)
            {
                CurrentIndex = 0;
                CurrentIndex = Objetos.Length - 1;
                DeactivateAll();
                ActivateByIndex(CurrentIndex);
            }

  



            if (CurrentIndex < Objetos.Length && XD == false)
            {

                DeactivateAll();
                ActivateByIndex(CurrentIndex);

            }



        }
    }

        void DeactivateAll()
        {
            for (int i = 0; i < Objetos.Length; i++)
            {
                Objetos[i].SetActive(false);
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