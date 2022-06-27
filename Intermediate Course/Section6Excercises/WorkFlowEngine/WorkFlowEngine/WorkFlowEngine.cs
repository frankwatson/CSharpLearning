namespace WorkFlowEngine
{
    public class WorkFlowEngine
    {
        private UploadVideo _uploadVideo;
        private WebServiceNotify _webServiceNotify;
        private SendEmail _sendEmail;
        private DbUpdate _dbUpdate;


        public void Run()
        {
            _uploadVideo = new UploadVideo();
            _webServiceNotify = new WebServiceNotify();
            _sendEmail = new SendEmail();
            _dbUpdate = new DbUpdate();

            _uploadVideo.Execute();
            _webServiceNotify.Execute();
            _sendEmail.Execute();
            _dbUpdate.Execute();
        }
    }
}