using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;


public class Elevator : MonoBehaviour
{
    public bool IsItShabbat = true;
    public int numberOfFloors = 20;

    void Start()
    {
        CheckForShabbat();
    }

    void CheckForShabbat()
    {
        if (IsItShabbat)
        {
            DoShabbatBehaviour();
        }
        else
        {
            DontShabbatBehaviour();
        }
    }

    // If it is Shabbat
    void DoShabbatBehaviour()
    {
        int currentFloorShabat = 0;

        if (currentFloorShabat < numberOfFloors)
        {

            for (int i = currentFloorShabat; i <= numberOfFloors; i++)
            {
                Debug.Log($"Elevator going up, {numberOfFloors} floors");
                Debug.Log($"Moving to floor {currentFloorShabat + i}");
            }
        }
        else if (currentFloorShabat >= numberOfFloors)
        {
            for (int i = numberOfFloors; i <= currentFloorShabat; i--)
            {
                Debug.Log($"Elevator going down, {numberOfFloors} floors");
                Debug.Log($"Moving to floor {currentFloorShabat = currentFloorShabat - i}");
            }
            Debug.Log("You are not in Shabbat floor");
        }
    }
        // If it isn't Shabbat
        void DontShabbatBehaviour()
        {
            int currentFloor = 1;
            int userInputFloor = 10;

            StartFloor(currentFloor);
            TargetFloor(userInputFloor);
            GoingUpOrDown(currentFloor, userInputFloor);
        }

        void StartFloor(int CurrentFloor)
        {
            Debug.Log($"You are on {CurrentFloor} floor");
        }

        void TargetFloor(int UserInputFloor)
        {
            Debug.Log($"You have chosen to go to floor num {UserInputFloor}");
        }

        void GoingUpOrDown(int CurrentFloor, int UserInputFloor)
        {
            if (CurrentFloor < UserInputFloor)
            {
                int UporDown = UserInputFloor - CurrentFloor;

                for (int i = CurrentFloor; i <= UporDown; i++)
                {
                    Debug.Log($"Elevator going up, {UporDown} floors");
                    Debug.Log($"Moving to floor {CurrentFloor + i}");
                }
            }
            else if (CurrentFloor > UserInputFloor)
            {
                int UporDown = CurrentFloor - UserInputFloor;

                for (int i = CurrentFloor; i <= UporDown; i++)
                {
                    Debug.Log($"Elevator going down, {UporDown} floors");
                    Debug.Log($"Moving to floor {CurrentFloor - i}");
                }
            }
            else
            {
                Debug.Log("You are already on the target floor");
            }
        }
    }
