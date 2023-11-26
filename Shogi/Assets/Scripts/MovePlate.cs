using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlate : MonoBehaviour
{
    public GameObject controller;

    GameObject reference = null;
    int matrixX;
    int matrixY;

    //false: move, true: attack
    public bool attack = false;
    
    public vois Start()
    {
        if(attack)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(1.0f, 0.0f, 0.0f, 1.0f);
        }
    }
    
    public void OnMouseUp()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");

        if(attack)
        {
            GameObject sp = controller.GetComponent<Game>().GetPosition(matrixX, matrixY);

            Destroy(sp);
        }

        controller.GetComponent<Game>().SetPositionEmpty(reference.GetComponent<ShogiMan>().GetXBoard(), reference.GetComponent<ShogiMan>().GetYBoard());

        reference.GetComponent<ShogiMan>().SetXBoard(matrixX);
        reference.GetComponent<ShogiMan>().SetYBoard(matrixY);
        reference.GetComponent<ShogiMan>().SetCoords();

        controller.GetComponent<Game>().SetPosition(reference);

        reference.GetComponent<ShogiMan>().DestroyMovePlates();
    }

    public void SetCoords(int x, int y)
    {
        matrixX = x;
        matrixY = y;
    }

    public void SetReferense(GameObject obj)
    {
        reference = obj;
    }

    public GameObject GetReferense()
    {
        return reference;
    }
}
