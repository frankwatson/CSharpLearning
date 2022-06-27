using System;

namespace WorkFlowEngine
{
    public class DbUpdate : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("[" + DateTime.Now.ToLongTimeString() + "] " + "Updating database to change status of video to processing.");
        }
    }
}