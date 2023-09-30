using Newtonsoft.Json.Linq;

public class MergeCaptionTexts
{
    public static string MergeCaptions(string json)
    {
        // Parse the JSON string into a JObject
        JObject jsonObject = JObject.Parse(json);

        // Access the "subtitle" array within the "subtitles" object
        JArray subtitleArray = (JArray)jsonObject["subtitles"]["subtitle"];

        // Merge all caption texts into a single long text
        string mergedText = string.Empty;
        foreach (var subtitle in subtitleArray)
        {
            mergedText += subtitle["text"].ToString() + " ";
        }
        mergedText = mergedText.Trim();

        return mergedText;
    }

}

