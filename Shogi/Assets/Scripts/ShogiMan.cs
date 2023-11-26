using System;
using UnityEngine;

public class ShogiMan : MonoBehaviour
{
    //References
    public GameObject controller;
    public GameObject movePlate;

    //Pozitions
    private int xBoard = -1;
    private int yBoard = -1;

    //Variable to keep track of black player or white player
    private string player;

    //References for all the sprites that the chesspiece can be
    public Sprite bishop_white, golden_general_white, king_white, knight_white, pawn_white, rook_white, silver_general_white, spear_white;
    public Sprite bishop_white_up, knight_white_up, pawn_white_up, rook_white_up, silver_general_white_up, spear_white_up;
    public Sprite bishop_black, golden_general_black, king_black, knight_black, pawn_black, rook_black, silver_general_black, spear_black;
    public Sprite bishop_black_up, knight_black_up, pawn_black_up, rook_black_up, silver_general_black_up, spear_black_up;

    public void Activate()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");

        //take the instantiated location and adjust the transform
        SetCoords();

        switch (this.name)
        {
            case "bishop_white": this.GetComponent<SpriteRenderer>().sprite = bishop_white; break;
            case "golden_general_white": this.GetComponent<SpriteRenderer>().sprite = golden_general_white; break;
            case "king_white": this.GetComponent<SpriteRenderer>().sprite = king_white; break;
            case "knight_white": this.GetComponent<SpriteRenderer>().sprite = knight_white; break;
            case "pawn_white": this.GetComponent<SpriteRenderer>().sprite = pawn_white; break;
            case "rook_white": this.GetComponent<SpriteRenderer>().sprite = rook_white; break;
            case "silver_general_white": this.GetComponent<SpriteRenderer>().sprite = silver_general_white; break;
            case "spear_white": this.GetComponent<SpriteRenderer>().sprite = spear_white; break;

            case "bishop_white_up": this.GetComponent<SpriteRenderer>().sprite = bishop_white_up; break;
            case "knight_white_up": this.GetComponent<SpriteRenderer>().sprite = knight_white_up; break;
            case "pawn_white_up": this.GetComponent<SpriteRenderer>().sprite = pawn_white_up; break;
            case "rook_white_up": this.GetComponent<SpriteRenderer>().sprite = rook_white_up; break;
            case "silver_general_white_up": this.GetComponent<SpriteRenderer>().sprite = silver_general_white_up; break;
            case "spear_white_up": this.GetComponent<SpriteRenderer>().sprite = spear_white_up; break;

            case "bishop_black": this.GetComponent<SpriteRenderer>().sprite = bishop_black; break;
            case "golden_general_black": this.GetComponent<SpriteRenderer>().sprite = golden_general_black; break;
            case "king_black": this.GetComponent<SpriteRenderer>().sprite = king_black; break;
            case "knight_black": this.GetComponent<SpriteRenderer>().sprite = knight_black; break;
            case "pawn_black": this.GetComponent<SpriteRenderer>().sprite = pawn_black; break;
            case "rook_black": this.GetComponent<SpriteRenderer>().sprite = rook_black; break;
            case "silver_general_black": this.GetComponent<SpriteRenderer>().sprite = silver_general_black; break;
            case "spear_black": this.GetComponent<SpriteRenderer>().sprite = spear_black; break;

            case "bishop_black_up": this.GetComponent<SpriteRenderer>().sprite = bishop_black_up; break;
            case "knight_black_up": this.GetComponent<SpriteRenderer>().sprite = knight_black_up; break;
            case "pawn_black_up": this.GetComponent<SpriteRenderer>().sprite = pawn_black_up; break;
            case "rook_black_up": this.GetComponent<SpriteRenderer>().sprite = rook_black_up; break;
            case "silver_general_black_up": this.GetComponent<SpriteRenderer>().sprite = silver_general_black_up; break;
            case "spear_black_up": this.GetComponent<SpriteRenderer>().sprite = spear_black_up; break;
        }
    }

    public void SetCoords()
    {
        float x = xBoard;
        float y = yBoard;

        x -= 4;
        y -= 4.1f;

        this.transform.position = new Vector3(x, y, -1.0f);
    }

    public int GetXBoard()
    {
        return xBoard;
    }

    public int GetYBoard()
    {
        return yBoard;
    }

    public void SetXBoard(int x)
    {
        xBoard = x;
    }

    public void SetYBoard(int y)
    {
        yBoard = y;
    }
}

