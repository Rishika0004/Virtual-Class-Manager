using System;

namespace VirtualClassroomManager.Logging
{
    public class Logger
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
    }
}
