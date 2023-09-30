using System;
namespace Captions
{
    public class PrimeCaptionsJson : ICaptionsJson
    {
        private readonly PrimeCaptions PrimeCaptions;

        public PrimeCaptionsJson(int id)
        {
            PrimeCaptions = new(id);
        }

        public string GetJson()
        {
            return ""; // random json

        }
    }
}
