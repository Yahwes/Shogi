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

    public void SetUpSprite(string name)
    {
        if (name == "bishop_white")
            this.GetComponent<SpriteRenderer>().sprite = bishop_white_up;
        if (name == "knight_white")
            this.GetComponent<SpriteRenderer>().sprite = knight_white_up;
        if (name == "pawn_white")
            this.GetComponent<SpriteRenderer>().sprite = pawn_white_up;
        if (name == "rook_white")
            this.GetComponent<SpriteRenderer>().sprite = rook_white_up;
        if (name == "silver_general_white")
            this.GetComponent<SpriteRenderer>().sprite = silver_general_white_up;
        if (name == "spear_white")
            this.GetComponent<SpriteRenderer>().sprite = spear_white_up;

        if (name == "bishop_black")
            this.GetComponent<SpriteRenderer>().sprite = bishop_black_up;
        if (name == "knight_black")
            this.GetComponent<SpriteRenderer>().sprite = knight_black_up;
        if (name == "pawn_black")
            this.GetComponent<SpriteRenderer>().sprite = pawn_black_up;
        if (name == "rook_black")
            this.GetComponent<SpriteRenderer>().sprite = rook_black_up;
        if (name == "silver_general_black")
            this.GetComponent<SpriteRenderer>().sprite = silver_general_black_up;
        if (name == "spear_black")
            this.GetComponent<SpriteRenderer>().sprite = spear_black_up;
    }

    public void Activate()
    {
        controller = GameObject.FindGameObjectWithTag("GameController");

        //take the instantiated location and adjust the transform
        SetCoords();

        switch (this.name)
        {
            
            case "bishop_white": this.GetComponent<SpriteRenderer>().sprite = bishop_white; player = "white"; break;
            case "golden_general_white": this.GetComponent<SpriteRenderer>().sprite = golden_general_white; player = "white"; break;
            case "king_white": this.GetComponent<SpriteRenderer>().sprite = king_white; player = "white"; break;
            case "knight_white": this.GetComponent<SpriteRenderer>().sprite = knight_white; player = "white"; break;
            case "pawn_white": this.GetComponent<SpriteRenderer>().sprite = pawn_white; player = "white"; break;
            case "rook_white": this.GetComponent<SpriteRenderer>().sprite = rook_white; player = "white"; break;
            case "silver_general_white": this.GetComponent<SpriteRenderer>().sprite = silver_general_white; player = "white"; break;
            case "spear_white": this.GetComponent<SpriteRenderer>().sprite = spear_white; player = "white"; break;

            case "bishop_white_up": this.GetComponent<SpriteRenderer>().sprite = bishop_white_up; player = "white"; break;
            case "knight_white_up": this.GetComponent<SpriteRenderer>().sprite = knight_white_up; player = "white"; break;
            case "pawn_white_up": this.GetComponent<SpriteRenderer>().sprite = pawn_white_up; player = "white"; break;
            case "rook_white_up": this.GetComponent<SpriteRenderer>().sprite = rook_white_up; player = "white"; break;
            case "silver_general_white_up": this.GetComponent<SpriteRenderer>().sprite = silver_general_white_up; player = "white"; break;
            case "spear_white_up": this.GetComponent<SpriteRenderer>().sprite = spear_white_up; break;

            case "bishop_black": this.GetComponent<SpriteRenderer>().sprite = bishop_black; player = "black"; break;
            case "golden_general_black": this.GetComponent<SpriteRenderer>().sprite = golden_general_black; player = "black"; break;
            case "king_black": this.GetComponent<SpriteRenderer>().sprite = king_black; player = "black"; break;
            case "knight_black": this.GetComponent<SpriteRenderer>().sprite = knight_black; player = "black"; break;
            case "pawn_black": this.GetComponent<SpriteRenderer>().sprite = pawn_black; player = "black"; break;
            case "rook_black": this.GetComponent<SpriteRenderer>().sprite = rook_black; player = "black"; break;
            case "silver_general_black": this.GetComponent<SpriteRenderer>().sprite = silver_general_black; player = "black"; break;
            case "spear_black": this.GetComponent<SpriteRenderer>().sprite = spear_black; player = "black"; break;

            case "bishop_black_up": this.GetComponent<SpriteRenderer>().sprite = bishop_black_up; player = "black"; break;
            case "knight_black_up": this.GetComponent<SpriteRenderer>().sprite = knight_black_up; player = "black"; break;
            case "pawn_black_up": this.GetComponent<SpriteRenderer>().sprite = pawn_black_up; player = "black"; break;
            case "rook_black_up": this.GetComponent<SpriteRenderer>().sprite = rook_black_up; player = "black"; break;
            case "silver_general_black_up": this.GetComponent<SpriteRenderer>().sprite = silver_general_black_up; player = "black"; break;
            case "spear_black_up": this.GetComponent<SpriteRenderer>().sprite = spear_black_up; player = "black"; break;
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

    private void OnMouseUp()
    {
        if (!controller.GetComponent<Game>().IsGameOver() && controller.GetComponent<Game>().GetCurrentPlayer() == player)
        {
            DestroyMovePlates();

            InitiateMovePlates();

        }
    }

    public void DestroyMovePlates()
    {
        GameObject[] movePlates = GameObject.FindGameObjectsWithTag("MovePlate");
        for (int i = 0;i < movePlates.Length;i++)
            Destroy(movePlates[i]);
    }

    public void InitiateMovePlates()
    {
        switch(this.name)
        {
            case "king_black":
            case "king_white":
                SurronundMovePlates();
                break;
            case "rook_white":
            case "rook_black":
                LineMovePlate(0, 1);
                LineMovePlate(1, 0);
                LineMovePlate(-1, 0);
                LineMovePlate(0, -1);
                break;
            case "bishop_white":
            case "bishop_black":
                LineMovePlate(1, 1);
                LineMovePlate(-1, -1);
                LineMovePlate(-1, 1);
                LineMovePlate(1, -1);
                break;
            case "golden_general_white":
            case "pawn_white_up":
            case "spear_white_up":
            case "knight_white_up":
            case "silver_general_white_up":
                GoldenMovePlateWhite();
                break;
            case "golden_general_black":
            case "pawn_black_up":
            case "spear_black_up":
            case "knight_black_up":
            case "silver_general_black_up":
                GoldenMovePlateBlack();
                break;
            case "silver_general_white":
                PointMovePlate(xBoard + 1, yBoard + 1);
                PointMovePlate(xBoard, yBoard + 1);
                PointMovePlate(xBoard - 1, yBoard + 1);
                PointMovePlate(xBoard + 1, yBoard - 1);
                PointMovePlate(xBoard - 1, yBoard - 1);
                break;
            case "silver_general_black":
                PointMovePlate(xBoard + 1, yBoard - 1);
                PointMovePlate(xBoard, yBoard - 1);
                PointMovePlate(xBoard - 1, yBoard - 1);
                PointMovePlate(xBoard + 1, yBoard + 1);
                PointMovePlate(xBoard - 1, yBoard + 1);
                break;
            case "knight_white":
            case "knight_black":
                TMovePlate();
                break;
            case "spear_white":
                LineMovePlate(0, 1);
                break;
            case "spear_black":
                LineMovePlate(0, -1);
                break;
            case "pawn_white":
                PawnMovePlate(xBoard, yBoard + 1);
                break;
            case "pawn_black":
                PawnMovePlate(xBoard, yBoard - 1);
                break;
            case "bishop_white_up":
            case "bishop_black_up":
                LineMovePlate(1, 1);
                LineMovePlate(-1, -1);
                LineMovePlate(-1, 1);
                LineMovePlate(1, -1);
                SurronundMovePlates();
                break;
            case "rook_white_up":
            case "rook_black_up":
                LineMovePlate(0, 1);
                LineMovePlate(1, 0);
                LineMovePlate(-1, 0);
                LineMovePlate(0, -1);
                SurronundMovePlates();
                break;
        }
    }

    public void GoldenMovePlateWhite()
    {
        PointMovePlate(xBoard + 1, yBoard + 1);
        PointMovePlate(xBoard, yBoard + 1);
        PointMovePlate(xBoard - 1, yBoard + 1);
        PointMovePlate(xBoard + 1, yBoard);
        PointMovePlate(xBoard - 1, yBoard);
        PointMovePlate(xBoard, yBoard - 1);
    }

    public void GoldenMovePlateBlack()
    {
        PointMovePlate(xBoard + 1, yBoard - 1);
        PointMovePlate(xBoard, yBoard - 1);
        PointMovePlate(xBoard - 1, yBoard - 1);
        PointMovePlate(xBoard - 1, yBoard);
        PointMovePlate(xBoard + 1, yBoard);
        PointMovePlate(xBoard, yBoard + 1);
    }

    public void LineMovePlate(int xIncrement, int yIncrement)
    {
        Game sc = controller.GetComponent<Game>();

        int x = xBoard + xIncrement;
        int y = yBoard + yIncrement;

        while(sc.PositionOnBoard(x, y) && sc.GetPositions(x, y) == null)
        {
            MovePlateSpawn(x, y);
            x += xIncrement;
            y += yIncrement;
        }

        if(sc.PositionOnBoard(x, y) && sc.GetPositions(x, y).GetComponent<ShogiMan>().player != player)
            MovePlateAttackSpawn(x, y);
    }

    public void TMovePlate()
    {
        PointMovePlate(xBoard + 1, yBoard + 2);
        PointMovePlate(xBoard - 1, yBoard + 2);
    }

    public void SurronundMovePlates()
    {
        PointMovePlate(xBoard + 1, yBoard + 1);
        PointMovePlate(xBoard + 1, yBoard);
        PointMovePlate(xBoard + 1, yBoard - 1);
        PointMovePlate(xBoard - 1, yBoard + 1);
        PointMovePlate(xBoard - 1, yBoard);
        PointMovePlate(xBoard - 1, yBoard - 1);
        PointMovePlate(xBoard, yBoard + 1);
        PointMovePlate(xBoard, yBoard - 1);
    }

    public void PointMovePlate(int x, int y)
    {
        Game sc = controller.GetComponent<Game>();
        if(sc.PositionOnBoard(x, y))
        {
            GameObject cp = sc.GetPositions(x, y);
            if (cp == null)
                MovePlateSpawn(x, y);
            else if(cp.GetComponent<ShogiMan>().player != player)
                MovePlateAttackSpawn(x, y);
        }
    }

    public void PawnMovePlate(int x, int y)
    {
        Game sc = controller.GetComponent<Game>();
        if (sc.PositionOnBoard(x, y))
        {
            if (sc.GetPositions(x, y) == null)
                MovePlateSpawn(x, y);
            if (sc.PositionOnBoard(x, y) && sc.GetPositions(x, y) != null && sc.GetPositions(x, y).GetComponent<ShogiMan>().player != player)
                MovePlateAttackSpawn(x, y);
        }
    }

    public void MovePlateSpawn(int matrixX, int matrixY)
    {
        float x = matrixX;
        float y = matrixY;

        x -= 4;
        y -= 4.1f;

        GameObject mp = Instantiate(movePlate, new Vector3(x, y, -3.0f), Quaternion.identity);

        MovePlate mpScript = mp.GetComponent<MovePlate>();
        mpScript.SetReference(gameObject);
        mpScript.SetCoords(matrixX, matrixY);
    }

    public void MovePlateAttackSpawn(int matrixX, int matrixY)
    {
        float x = matrixX;
        float y = matrixY;

        x -= 4;
        y -= 4.1f;

        GameObject mp = Instantiate(movePlate, new Vector3(x, y, -3.0f), Quaternion.identity);

        MovePlate mpScript = mp.GetComponent<MovePlate>();
        mpScript.attack = true;
        mpScript.SetReference(gameObject);
        mpScript.SetCoords(matrixX, matrixY);
    }
}

