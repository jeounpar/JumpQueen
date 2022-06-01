using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform TPlayer;

    [SerializeField]private int posY;
    void Start()
    {
        posY = 0;
    }

    // Update is called once per frame
    void Update()
    {
        setPositionY();    
    }

    void setPositionY()
    {
        transform.position =new Vector3(transform.position.x,((int)(TPlayer.position.y + 5f) / 10)*10,-10) ;

        posY = (int)((TPlayer.position.y + 5f) / 10) * 10;
    }
}
