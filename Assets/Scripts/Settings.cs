using UnityEngine;
public class Settings
{
    public static string fileName = "test";
    public static float fixationPointSpeed = 10.0f; // [deg/s] Default: 10.0f
    public static float fixationPointInitialPosition = 18.0f; // [deg] Default: 18.0f
    public static float beltBaseSpeed = 12.0f; // [deg/s] Default: 12.0f
    public static float stimulusPresentationWaitingTime = 2.0f; // [sec] Default: 2.0f
    public static float stimulusPresentationTime = 0.5f; // [sec] Default: 0.5f
    public static double initialRatio = 2.5; // Default: 2.5
    public static double ratioStep = 0.1; // Default: 0.1
    public static int consecutiveCorrentAnswers = 2; // Default: 2
    public static int trials = 160; // Default: 160
}