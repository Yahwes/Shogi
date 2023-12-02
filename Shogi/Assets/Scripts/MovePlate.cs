using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlate : MonoBehaviour
{
    public GameObject controller;
    public GameObject reference = null;

    int matrixX;
    int matrixY;

    //false: move, true: attack
    public bool attack = false;
    
    public void Start()
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
            GameObject sp = controller.GetComponent<Game>().GetPositions(matrixX, matrixY);

            if (sp.name == "king_white") controller.GetComponent<Game>().Winner("Black");
            if (sp.name == "king_black") controller.GetComponent<Game>().Winner("White");

            Destroy(sp);
        }

        controller.GetComponent<Game>().SetPositionNull(reference.GetComponent<ShogiMan>().GetXBoard(), reference.GetComponent<ShogiMan>().GetYBoard());

        reference.GetComponent<ShogiMan>().SetXBoard(matrixX);
        reference.GetComponent<ShogiMan>().SetYBoard(matrixY);
        reference.GetComponent<ShogiMan>().SetCoords();

        controller.GetComponent<Game>().SetPosition(reference);

        GameObject changeP = controller.GetComponent<Game>().GetPositions(matrixX, matrixY);
        if ((changeP.name == "bishop_white" || changeP.name == "knight_white" || changeP.name == "pawn_white" || changeP.name == "rook_white" || changeP.name == "silver_general_white" || changeP.name == "spear_white") && matrixY >= 6)
        {
            if (changeP.name == "bishop_white")
            {
                reference.GetComponent<ShogiMan>().SetUpSprite("bishop_white");
                changeP.name = "bishop_white_up";
            }
            if (changeP.name == "pawn_white")
            {
                reference.GetComponent<ShogiMan>().SetUpSprite("pawn_white");
                changeP.name = "pawn_white_up";
            }
            if (changeP.name == "knight_white")
            {
                reference.GetComponent<ShogiMan>().SetUpSprite("knight_white");
                changeP.name = "knight_white_up";
            }
            if (changeP.name == "rook_white")
            {
                reference.GetComponent<ShogiMan>().SetUpSprite("rook_white");
                changeP.name = "rook_white_up";
            }
            if (changeP.name == "silver_general_white")
            {
                reference.GetComponent<ShogiMan>().SetUpSprite("silver_general_white");
                changeP.name = "silver_general_white_up";
            }
            if (changeP.name == "spear_white")
            {
                reference.GetComponent<ShogiMan>().SetUpSprite("spear_white");
                changeP.name = "spear_white_up";
            }
        }
        if ((changeP.name == "bishop_black" || changeP.name == "knight_black" || changeP.name == "pawn_black" || changeP.name == "rook_black" || changeP.name == "silver_general_black" || changeP.name == "spear_black") && matrixY <= 2)
        {
            if (changeP.name == "bishop_black")
            {
                reference.GetComponent<ShogiMan>().SetUpSprite("bishop_black");
                changeP.name = "bishop_black_up";
            }
            if (changeP.name == "pawn_black")
            {
                reference.GetComponent<ShogiMan>().SetUpSprite("pawn_black");
                changeP.name = "pawn_black_up";
            }
            if (changeP.name == "knight_black")
            {
                reference.GetComponent<ShogiMan>().SetUpSprite("knight_black");
                changeP.name = "knight_black_up";
            }
            if (changeP.name == "rook_black")
            {
                reference.GetComponent<ShogiMan>().SetUpSprite("rook_black");
                changeP.name = "rook_black_up";
            }
            if (changeP.name == "silver_general_black")
            {
                reference.GetComponent<ShogiMan>().SetUpSprite("silver_general_black");
                changeP.name = "silver_general_black_up";
            }
            if (changeP.name == "spear_black")
            {
                reference.GetComponent<ShogiMan>().SetUpSprite("spear_black");
                changeP.name = "spear_black_up";
            }

        }

        controller.GetComponent<Game>().NextTurn();

        reference.GetComponent<ShogiMan>().DestroyMovePlates();
    }

    public void SetCoords(int x, int y)
    {
        matrixX = x;
        matrixY = y;
    }

    public void SetReference(GameObject obj)
    {
        reference = obj;
    }

    public GameObject GetReference()
    {
        return reference;
    }
}
