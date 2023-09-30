using System;
using Newtonsoft.Json;
using System.Xml;

namespace Captions
{
	public class HBOMaxCaptionsJsonAdapter : ICaptionsJson
    {
        private readonly HBOMaxCaptions HBOMaxCaptions;

        public HBOMaxCaptionsJsonAdapter(int id)
        {
            HBOMaxCaptions = new HBOMaxCaptions(id);
        }

        public string GetJson()
        {
            XmlDocument doc = new();

            string captions = HBOMaxCaptions.GetContent();
            doc.LoadXml(captions);

            return JsonConvert.SerializeXmlNode(doc);
        }
    }
}

