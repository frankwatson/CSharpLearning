using System;

namespace WorkFlowEngine
{
    public class SendEmail : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("[" + DateTime.Now.ToLongTimeString() + "] " + "Sending email to user.");
        }
    }
}