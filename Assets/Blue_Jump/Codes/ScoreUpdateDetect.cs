using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdateDetect : MonoBehaviour
{
    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag.CompareTo("Player") == 0)
        {
            GameManager.score += 1;
        }
    }
}
