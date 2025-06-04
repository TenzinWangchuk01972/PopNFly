using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketManager : MonoBehaviour
{
    public Transform BasketH;

    private float randomNum;

    private float randomRotation;

    // Start is called before the first frame update
    void Start()
    {
        BasketH = transform.parent.transform.parent;

        randomNum = Random.Range(-1f, 1f);

        randomRotation = Random.Range(-30f, 30f);

        transform.eulerAngles = new Vector3(70, randomRotation, 0);

      transform.parent.position = new Vector3(transform.parent.position.x, randomNum, 0);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (transform.parent.GetSiblingIndex() == 2)
        {
            ShiftingPosition();
        }
    }

    void ShiftingPosition()
    {
        for (int i = 0; i < 2; i++)
        {
            var lastChild = BasketH.GetChild(BasketH.childCount - 1).transform.position;

            randomNum = Random.Range(-1f, 1f);

            randomRotation = Random.Range(-30f, 30f);

            transform.eulerAngles = new Vector3(70, randomRotation, 0);

            BasketH.GetChild(0).transform.position = new Vector3(lastChild.x + 5f, randomNum, 0);

            BasketH.GetChild(0).GetComponent<BoxCollider2D>().enabled = true;

            BasketH.GetChild(0).GetChild(0).GetComponent<BoxCollider2D>().enabled = true;

            BasketH.GetChild(0).transform.SetAsLastSibling();


        }
    }


}
