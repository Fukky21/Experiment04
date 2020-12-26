using UnityEngine;
public class Settings
{
    public static string fileName = "test";
    public static float fixationPointSpeed = 3.0f; // [deg/s] Default: 3.0f
    public static float fixationPointInitialPosition = 15.0f; // [deg] Default: 15.0f
    public static float beltBaseSpeed = 12.0f; // [deg/s] Default: 12.0f
    public static float stimulusPresentationTime = 0.5f; // [sec] Default: 0.5f
    public static double initialRatio = 2.5; // Default: 2.5
    public static double ratioStep = 0.1; // Default: 0.1
    public static int consecutiveCorrentAnswers = 2; // Default: 2
    public static int trials = 160; // Default: 40
}