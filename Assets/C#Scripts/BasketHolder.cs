using System.Collections;
using System.Collections.Generic;
using System.Threading;
using JetBrains.Annotations;
using UnityEngine;

public class basketHolder : MonoBehaviour
{
    public Transform BasketHolderTransform;

    // Start is called before the first frame update
    void Start()
    {
        BasketHolderTransform = this.transform;
        /*Debug.Log(BasketHolderTransform.childCount);    //Shows the number of child the parent has inside it


        for (int i = 0; i < BasketHolderTransform.childCount; i++)
        {
            Debug.Log(BasketHolderTransform.GetChild(i).name);    //shows the name of all the child inside the parent
        }*/
        
        this.transform.SetSiblingIndex(0);
    }
}
