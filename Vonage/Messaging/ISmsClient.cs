using Vonage.Request;

namespace Vonage.Messaging
{
    public interface ISmsClient
    {
        /// <summary>
        /// Send an outbound SMS from your Vonage account
        /// </summary>
        /// <param name="request"></param>
        /// <param name="creds"></param>
        /// <returns></returns>
        SendSmsResponse SendAnSms(SendSmsRequest request, Credentials creds = null);
    }
}