using System;

namespace WorkFlowEngine
{
    public class UploadVideo : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("[" + DateTime.Now.ToLongTimeString() + "] " + "Uploading video to cloud storage.");
        }
    }
}