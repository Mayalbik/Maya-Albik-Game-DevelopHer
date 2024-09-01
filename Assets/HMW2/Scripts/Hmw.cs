using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Hmw2 : MonoBehaviour
{
    void Start()
    {
        AcceptingInt(5);
        TryToAcceptInt(7);
        threeCases(3);
    }

    void AcceptingInt(int acceptedInt)
    {
        Debug.Log($"You now have {acceptedInt + 6} power points!");
    }

    void TryToAcceptInt(int acceptedIntIf)
    {
        if (acceptedIntIf < 8)
        {
            Debug.Log($"You rolled {acceptedIntIf}. You have taken damage.");
        }
        else
        {
            Debug.Log($"You rolled {acceptedIntIf}. You defeated the boss!");
        }
    }
    void threeCases(int CaseInt)
    {
        switch(CaseInt)
        {
            case 1:
                Debug.Log("You selected option 1, you are dead.");
                break;
            case 2:
                Debug.Log("You selected option 2, you were saved.");
                break;
            case 3:
                Debug.Log("You selected option 3, you found a secret room.");
                break;
            default:
                Debug.Log("Not the number I was looking for.");
                break;

        }

        }

}
