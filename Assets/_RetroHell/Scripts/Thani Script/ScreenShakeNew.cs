using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShakeNew : MonoBehaviour
{
    public interface ScreenShaker
    {
        Displacement displacement { get; }
        bool isFinished { get; }
        void Initialize(Vector3 cameraPosition, Quaternion cameraRotation);
        void Update(float deltaTime, Vector3 cameraPosition, Quaternion cameraRotation);
    }

    public struct Displacement
    {
        public Vector3 CMRPosition;
        public Vector3 eulersAngles;

        public Displacement(Vector3 CMRPosition, Vector3 eulersAngles)
        {
            this.CMRPosition = CMRPosition;
            this.eulersAngles = eulersAngles;
        }
    }

    //public static Displacement operator +(Displacement a, Displacement b)
    //{
    //return new Displacement(a.CMRPosition + b.CMRPosition, b.eulersAngles + a.eulersAngles);
    //}

    //public static Displacement operator -(Displacement a, Displacement b)
    //{
    //return new Displacement(a.CMRPosition - b.CMRPosition, b.eulersAngles - a.eulersAngles);
    //}

    //public static Displacement operator *(Displacement coordinates, float number)
    //{
    //return new Displacement(coordinates.CMRPosition * number, coordinates.eulersAngles * number);
    //}

    //public static Displacement operator *(float number, Displacement coordinates)
    //{
    //return coordinates * number;
    //}

    public static Displacement Scale(Displacement a, Displacement b)
    {
        return new Displacement(Vector3.Scale(a.CMRPosition, b.CMRPosition), Vector3.Scale(b.eulersAngles, a.eulersAngles));
    }

    public static Displacement Lerp(Displacement a, Displacement b, float t)
    {
        return new Displacement(Vector3.Lerp(a.CMRPosition, b.CMRPosition, t), Vector3.Lerp(a.eulersAngles, b.eulersAngles, t));
    }
}
