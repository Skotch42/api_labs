using System.ServiceModel;

namespace Soap.Business_Logic
{
    [ServiceContract]
    public interface ISoapService
    {
        [OperationContract]
        string StringToUpper(string words);

        [OperationContract]
        string StringToLower(string words);

    }
    public class SoapService : ISoapService
    {
        public string StringToUpper(string words)
        {
            var up = words.ToUpper();
            return up;
        }

        public string StringToLower(string words)
        {
            var down= words.ToLower();
            return new string(down);
        }
    }
}
