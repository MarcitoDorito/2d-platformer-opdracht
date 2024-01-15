using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Coinmanager : MonoBehaviour
{
    public static int score;

    public void FixedUpdate()
    {
    }
    public static void Addscore()
    {
            score++;
            Debug.Log("Je hebt " + score+ " coin");
    }
}
