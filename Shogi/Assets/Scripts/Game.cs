using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    public GameObject ShogiPiece;

    private GameObject[,] positions = new GameObject[9, 9];
    private GameObject[] playerWhite = new GameObject[20];
    private GameObject[] playerBlack = new GameObject[20];

    private string currentPlayer = "white";

    private bool gameOver = false;

    void Start()
    {
        playerWhite = new GameObject[]
        {
            Create("spear_white", 0, 0), Create("knight_white", 1, 0), Create("silver_general_white", 2, 0), Create("golden_general_white", 3, 0), Create("king_white", 4, 0), Create("golden_general_white", 5, 0), Create("silver_general_white", 6, 0),
            Create("knight_white", 7, 0), Create("spear_white", 8, 0), Create("rook_white", 7, 1), Create("bishop_white", 1, 1), Create("pawn_white", 0, 2), Create("pawn_white", 1, 2), Create("pawn_white", 2, 2),
            Create("pawn_white", 3, 2), Create("pawn_white", 4, 2), Create("pawn_white", 5, 2), Create("pawn_white", 6, 2), Create("pawn_white", 7, 2), Create("pawn_white", 8, 2)
        };

        playerBlack = new GameObject[]
        {
            Create("spear_black", 0, 8), Create("knight_black", 1, 8), Create("silver_general_black", 2, 8), Create("golden_general_black", 3, 8), Create("king_black", 4, 8), Create("golden_general_black", 5, 8), Create("silver_general_black", 6, 8),
            Create("knight_black", 7, 8), Create("spear_black", 8, 8), Create("rook_black", 7, 7), Create("bishop_black", 1, 7), Create("pawn_black", 0, 6), Create("pawn_black", 1, 6), Create("pawn_black", 2, 6),
            Create("pawn_black", 3, 6), Create("pawn_black", 4, 6), Create("pawn_black", 5, 6), Create("pawn_black", 6, 6), Create("pawn_black", 7, 6), Create("pawn_black", 8, 6)
        };

        for (int i = 0; i < playerBlack.Length; i++)
        {
            SetPosition(playerBlack[i]);
            SetPosition(playerBlack[i]);
        }

    }

    public GameObject Create(string name, int x, int y)
    {
        GameObject obj = Instantiate(ShogiPiece, new Vector3(0, 0, -1), Quaternion.identity);
        obj.transform.localScale = new Vector3(1.5f, 1.5f, 1.0f);
        ShogiMan sm = obj.GetComponent<ShogiMan>();
        sm.name = name;
        sm.SetXBoard(x);
        sm.SetYBoard(y);
        sm.Activate();
        return obj;
    }

    public void SetPosition(GameObject obj)
    {
        ShogiMan sm = obj.GetComponent<ShogiMan>();

        positions[sm.GetXBoard(), sm.GetYBoard()] = obj;
    }

    public void SetPositionNull(int x, int y)
    {
        positions[x, y] = null
    }

    public GameObject GetPositions(int x, int y)
    {
        return positions[x, y];
    }

    public bool PositionOnBoard(int x, int y)
    {
        if (x < 0 || y < 0 || x >= positions.GetLength(0) || y >= positions.GetLength(1))
            return false;
        return true;
    }
}
