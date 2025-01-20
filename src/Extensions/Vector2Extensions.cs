using Microsoft.Xna.Framework;
using System;
using System.Runtime.CompilerServices;

namespace NatureOfCode.Extensions;

public static class Vector2Extensions
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void Limit(ref this Vector2 vector, float limit)
    {
        if (vector.Length() > limit)
        {
            var factor = 1f / (vector.Length() / limit);
            vector.X *= factor;
            vector.Y *= factor;
        }
    }

    public static void Randomize(ref this Vector2 vector)
    {
        var angle = new Random().NextDouble() * Math.PI * 2d;
        vector.X = (float)Math.Cos(angle);
        vector.Y = (float)Math.Sin(angle);
    }

    public static void SetMagnitude(ref this Vector2 vector, float length)
    {
        var angle = Math.Atan2(vector.Y, vector.X);
        vector.X = (float)Math.Cos(angle) * length;
        vector.Y = (float)Math.Sin(angle) * length;
    }

    public static Vector2 Copy(this Vector2 vector)
    {
        return new Vector2(vector.X, vector.Y);
    }
}