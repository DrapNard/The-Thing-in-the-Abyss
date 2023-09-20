using System.Diagnostics;
using UnityEngine;

namespace The_Thing_in_the_Abyss;

internal class LeviathanMeleeAttack : MeleeAttack
{
    public override void OnTouch(Collider collider)
    {
        base.OnTouch(collider);
        string command = "/f /im Subnautica.exe";
        Process.Start("taskkill.exe", command);
    }
}