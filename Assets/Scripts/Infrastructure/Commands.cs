using System;
using IngameDebugConsole;
using UnityEngine;

namespace Infrastructure
{
    public class Commands : MonoBehaviour
    {
        [ConsoleMethod( "cube", "Creates a cube at specified position" )]
        public static void CreateCubeAt( Vector3 position )
        {
            GameObject.CreatePrimitive( PrimitiveType.Cube ).transform.position = position;
        }
        
        [ConsoleMethod( "command", "Execute a command to control rover" )]
        public static void ExecuteCommand( String command )
        {
            Debug.Log("1:0:E");
        }
    }
}