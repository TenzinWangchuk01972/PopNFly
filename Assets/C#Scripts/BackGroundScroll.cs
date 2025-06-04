using System.Collections;
using System.Collections.Generic;
using Cinemachine.Examples;
using UnityEngine;

public class BackGroundScroll : MonoBehaviour
{
    public Material bg;
    public float a;
    public CircleMovement player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        bg.mainTextureOffset = new Vector2(a * player.transform.position.x * 0.354f, 0);
    }



}
