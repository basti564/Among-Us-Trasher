using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Among_Us_Trasher
{
    class Pointers
    {
        //Movement
        public static string PlayerX = "GameAssembly.dll+02C6C4B8,5c,10,60,2c,8,5c,2c";
        public static string PlayerY = "GameAssembly.dll+02C6C4B8,5c,10,60,2c,8,5c,30";
        public static string PlayerSpeedX = "GameAssembly.dll+02C6C4B8,5c,10,60,2c,8,5c,40";
        public static string PlayerSpeedY = "GameAssembly.dll+02C6C4B8,5c,10,60,2c,8,5c,44";

        //In-Game
        public static string PlayerState = "GameAssembly.dll+02C6C310,5c,0,34,28"; //0 = Crewmate / 1 = Impostor / 256 = Ghost / 257 = Ghost(Impostor)
        public static string EmergencyCount = "GameAssembly.dll+02C6C310,5c,0,48";
        public static string EmergencyCDlive = "GameAssembly.dll+02C6C3E8,5c,0,e0";
        public static string IGKillCD = "GameAssembly.dll+02C6C310,5C,0,44";
        public static string KillDistance = "GameAssembly.dll+02C6C310,5c,4,40"; //0 = Short / 1 = Medium / 2 = Long
        public static string ImpostorVision = "GameAssembly.dll+02C6C310,5c,4,1c";
        public static string ReportDistance = "GameAssembly.dll+02C6C310,5c,0,2c";

        //Cosmetics
        public static string Username = "GameAssembly.dll+02C4968C,44,540,10,8,4c,4";
        public static string Color = "GameAssembly.dll+02C4968C,44,540,10,8,4c,38";
        public static string Pet = "GameAssembly.dll+02C4968C,44,540,10,8,4c,3c";
        public static string Hat = "GameAssembly.dll+02C4968C,44,540,10,8,4c,40";
        public static string Costume = "GameAssembly.dll+02C4968C,44,540,10,8,4c,44";

        //Lobby
        public static string Map = "GameAssembly.dll+02C6C310,5C,4,10";
        public static string GhostTasks = "GameAssembly.dll+02C6C310,5c,4,3c";
        public static string DefaultVisualTasksConfirmEjects = "GameAssembly.dll+02C6C310,5c,4,4c";
        public static string PlayerSpeed = "GameAssembly.dll+02C6C310,5c,4,14";
        public static string CrewmateVision = "GameAssembly.dll+02C6C310,5c,4,18";
        public static string Impostors = "GameAssembly.dll+02C6C310,5c,4";
        public static string EmergencyCD = "GameAssembly.dll+02C6C310,5c,4,34";
    }
}