using System;

namespace WorkFlowEngine
{
    public class WebServiceNotify : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("[" + DateTime.Now.ToLongTimeString() + "] " + "Notifying web service that video is ready for encoding.");
        }
    }
}