using System.Xml;
using Newtonsoft.Json;

public class HBOMaxCaptions
{

    public XML content {  get; set; }

    // public string Minions = " <?xml version="1.0" encoding="UTF-8"?> <subtitle>\r\n  <index>2</index>\r\n  <start>00:01:43,428</start>\r\n  <end>00:01:45,234</end>\r\n  <text>Minions.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>3</index>\r\n  <start>00:01:45,274</start>\r\n  <end>00:01:49,818</end>\r\n  <text>Minions have been on this planet far longer than we have.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>4</index>\r\n  <start>00:01:49,843</start>\r\n  <end>00:01:51,547</end>\r\n  <text>They go by many names.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>5</index>\r\n  <start>00:01:51,572</start>\r\n  <end>00:01:55,177</end>\r\n  <text>Dave, Carl, Paul, Mike.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>6</index>\r\n  <start>00:01:56,597</start>\r\n  <end>00:01:58,719</end>\r\n  <text>Oh, that one is Norbert.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>7</index>\r\n  <start>00:01:59,101</start>\r\n  <end>00:02:00,929</end>\r\n  <text>He's an idiot.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>8</index>\r\n  <start>00:02:00,954</start>\r\n  <end>00:02:04,884</end>\r\n  <text>They're all different. But they all share the same goal.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>9</index>\r\n  <start>00:02:04,909</start>\r\n  <end>00:02:08,212</end>\r\n  <text>To serve the most despicable master they could find.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>10</index>\r\n  <start>00:02:08,237</start>\r\n  <end>00:02:10,097</end>\r\n  <text>BOSS!</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>11</index>\r\n  <start>00:02:14,618</start>\r\n  <end>00:02:19,478</end>\r\n  <text>Making their master happy was the tribe's very reason for existence.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>12</index>\r\n  <start>00:02:19,706</start>\r\n  <end>00:02:23,759</end>\r\n  <text>But that's not to say that they didn’t have other passions.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>13</index>\r\n  <start>00:02:24,033</start>\r\n  <end>00:02:26,834</end>\r\n  <text>- Look. It's a banana.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>14</index>\r\n  <start>00:02:28,365</start>\r\n  <end>00:02:30,243</end>\r\n  <text>- Move over.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>15</index>\r\n  <start>00:02:30,268</start>\r\n  <end>00:02:32,238</end>\r\n  <text>It's a banana. Ha-hah-ha.</text>\r\n</subtitle>\r\n";
    //public string BreakingBad = "<?xml version="1.0" encoding="UTF-8"?> <subtitle>\r\n  <index>130</index>\r\n  <start>00:09:27,644</start>\r\n  <end>00:09:29,712</end>\r\n  <text>Who are you talking to right now?</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>131</index>\r\n  <start>00:09:32,315</start>\r\n  <end>00:09:34,550</end>\r\n  <text>Who is it you think you see?</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>132</index>\r\n  <start>00:09:36,987</start>\r\n  <end>00:09:39,722</end>\r\n  <text>Do you know how much I make a year?</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>133</index>\r\n  <start>00:09:39,757</start>\r\n  <end>00:09:42,426</end>\r\n  <text>I mean, even if I told you, you wouldn't believe it.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>134</index>\r\n  <start>00:09:42,460</start>\r\n  <end>00:09:43,827</end>\r\n  <text>Do you know what would happen</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>135</index>\r\n  <start>00:09:43,862</start>\r\n  <end>00:09:46,364</end>\r\n  <text>if I suddenly decided to stop going in to work?</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>136</index>\r\n  <start>00:09:46,398</start>\r\n  <end>00:09:48,299</end>\r\n  <text>A business big enough</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>137</index>\r\n  <start>00:09:48,334</start>\r\n  <end>00:09:49,701</end>\r\n  <text>that it could be listed on the NASDAQ</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>138</index>\r\n  <start>00:09:49,735</start>\r\n  <end>00:09:52,103</end>\r\n  <text>goes belly-up, disappears.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>139</index>\r\n  <start>00:09:52,137</start>\r\n  <end>00:09:54,939</end>\r\n  <text>It ceases to exist without me. No.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>140</index>\r\n  <start>00:09:54,974</start>\r\n  <end>00:09:57,909</end>\r\n  <text>You clearly don't know who you're talking to,</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>141</index>\r\n  <start>00:09:57,943</start>\r\n  <end>00:09:59,077</end>\r\n  <text>so let me clue you in.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>142</index>\r\n  <start>00:09:59,111</start>\r\n  <end>00:10:01,779</end>\r\n  <text>I am not in danger, Skyler.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>143</index>\r\n  <start>00:10:01,814</start>\r\n  <end>00:10:03,381</end>\r\n  <text>I am the danger.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>144</index>\r\n  <start>00:10:03,415</start>\r\n  <end>00:10:05,216</end>\r\n  <text>A guy opens his door and gets shot,</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>145</index>\r\n  <start>00:10:05,250</start>\r\n  <end>00:10:06,616</end>\r\n  <text>and you think that of me?</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>146</index>\r\n  <start>00:10:06,651</start>\r\n  <end>00:10:07,717</end>\r\n  <text>No.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>147</index>\r\n  <start>00:10:07,752</start>\r\n  <end>00:10:10,086</end>\r\n  <text>I am the one who knocks.</text>\r\n</subtitle>\r\n";
    //public string OnePiece = "<?xml version="1.0" encoding="UTF-8"?> <subtitle>\r\n  <index>1</index>\r\n  <start>00:00:09,384</start>\r\n  <end>00:00:11,761</end>\r\n  <text><i>This is a world like no other,</i></text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>2</index>\r\n  <start>00:00:12,262</start>\r\n  <end>00:00:16,182</end>\r\n  <text><i>one brimming with mystery and teeming with danger,</i></text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>3</index>\r\n  <start>00:00:16,683</start>\r\n  <end>00:00:20,603</end>\r\n  <text><i>filled with hundreds of islands strewn across vast seas.</i></text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>4</index>\r\n  <start>00:00:24,899</start>\r\n  <end>00:00:29,696</end>\r\n  <text><i>And throughout these seas are those who live according to their own rules,</i></text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>5</index>\r\n  <start>00:00:30,864</start>\r\n  <end>00:00:33,783</end>\r\n  <text><i>who seek a life of freedom and adventure.</i></text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>6</index>\r\n  <start>00:00:34,701</start>\r\n  <end>00:00:38,455</end>\r\n  <text><i>This is a world of pirates!</i></text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>7</index>\r\n  <start>00:00:41,708</start>\r\n  <end>00:00:44,586</end>\r\n  <text>Piracy is a scourge upon this world.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>8</index>\r\n  <start>00:00:45,211</start>\r\n  <end>00:00:50,091</end>\r\n  <text>{\\an8}For too long, villains and miscreants have sown havoc across our seas.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>9</index>\r\n  <start>00:00:50,592</start>\r\n  <end>00:00:53,970</end>\r\n  <text>{\\an8}But the Marines, on behalf of your World Government,</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>10</index>\r\n  <start>00:00:54,054</start>\r\n  <end>00:00:56,931</end>\r\n  <text>strive to keep you safe and protected.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>11</index>\r\n  <start>00:00:58,391</start>\r\n  <end>00:01:02,812</end>\r\n  <text>And today we've made a great stride in that effort.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>12</index>\r\n  <start>00:01:04,272</start>\r\n  <end>00:01:05,648</end>\r\n  <text>Gold Roger,</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>13</index>\r\n  <start>00:01:06,649</start>\r\n  <end>00:01:09,444</end>\r\n  <text>the so-called King of the Pirates,</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>14</index>\r\n  <start>00:01:09,527</start>\r\n  <end>00:01:11,112</end>\r\n  <text>has been captured.</text>\r\n</subtitle>\r\n";
    //public string Rango = "<?xml version="1.0" encoding="UTF-8"?> <subtitle>\r\n  <index>1</index>\r\n  <start>00:01:16,869</start>\r\n  <end>00:01:20,037</end>\r\n  <text>We are gathered here today to immortalize in song</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>2</index>\r\n  <start>00:01:20,164</start>\r\n  <end>00:01:23,624</end>\r\n  <text>the life and untimely death of a great legend.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>3</index>\r\n  <start>00:01:23,709</start>\r\n  <end>00:01:26,043</end>\r\n  <text>- Rango.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>4</index>\r\n  <start>00:01:26,170</start>\r\n  <end>00:01:30,047</end>\r\n  <text>So sit back, relax, and enjoy your low-calorie popcorn and assorted confections</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>5</index>\r\n  <start>00:01:30,174</start>\r\n  <end>00:01:34,969</end>\r\n  <text>while we tell you the strange and bewildering tale of a hero</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>6</index>\r\n  <start>00:01:35,053</start>\r\n  <end>00:01:38,514</end>\r\n  <text>who has yet to enter his own story.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>7</index>\r\n  <start>00:01:53,197</start>\r\n  <end>00:01:55,907</end>\r\n  <text>Crunchy, creamy, cookie, candy, cupcake.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>8</index>\r\n  <start>00:01:57,242</start>\r\n  <end>00:01:59,410</end>\r\n  <text>Okay, everybody, let's take it from the top.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>9</index>\r\n  <start>00:02:00,746</start>\r\n  <end>00:02:04,248</end>\r\n  <text>The stage is set, the night moist with apprehension.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>10</index>\r\n  <start>00:02:04,333</start>\r\n  <end>00:02:08,336</end>\r\n  <text>Alone in her chamber, the princess prepares to take her own life.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>11</index>\r\n  <start>00:02:09,046</start>\r\n  <end>00:02:12,924</end>\r\n  <text>\"It is far better to nourish worms than to live without love.\"</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>12</index>\r\n  <start>00:02:13,008</start>\r\n  <end>00:02:14,926</end>\r\n  <text>She reaches for the poisoned chalice.</text>\r\n</subtitle>\r\n<subtitle>\r\n  <index>13</index>\r\n  <start>00:02:15,052</start>\r\n  <end>00:02:18,387</end>\r\n  <text>Meanwhile, the wicked Malvolio plots his ascension to the throne</text>\r\n</subtitle>\r\n";


    public void getCaptions()
    {

    }
}

public class PrimeVideoCaptions : CaptionsJson
{

    public void getJson()
    {

    }
}

public class HBOMaxCaptionsJsonAdapter : CaptionsJson
{
    public HBOMaxCaptionsJsonAdapter(string XML)
    {
        
    }
    //XmlDocument BreakingBadXML = new XmlDocument();
    //BreakingBadXML.LoadXml(BreakingBad);

    //string BreakingBadJSON = JsonConvert.SerializeXmlNode(BreakingBadXML);
    public void getJson()
    {

    }
}

public interface CaptionsJson
{
    public void getJson()
    {

    }
}
public interface Movie
{
    public string name { get; set; }
    public string description { get; set; }
    public DateOnly datePublished { get; set; }

    public void playMovie()
    {

    }
}
public class MoviePrime
{
    public string name { get; set; }
    public string description { get; set; }
    public DateOnly datePublished { get; set; }

    public MoviePrime (string name, string description, DateOnly datePublished)
    {
        this.name = name;
        this.description = description;
        this.datePublished = datePublished;
    }

    public void playMovie()
    {

    }
}

public class MovieHBO
{
    public string name { get; set; }
    public string description { get; set; }
    public DateOnly datePublished { get; set; }

    public MovieHBO(string name, string description, DateOnly datePublished)
    {
        this.name = name;
        this.description = description;
        this.datePublished = datePublished;
    }

    public void playMovie()
    {

    }
}

public class PrimeVideo
{
    public static void main()
    {
        Console.WriteLine("Bienvenido a PrimeVideo!, Selecciona una de las siguientes opciones\n");
        Console.WriteLine("1. Minions");
        Console.WriteLine("2. OnePiece");
        Console.WriteLine("3. Breaking Bad");
        Console.WriteLine("4. Rango");
        
        int opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                Console.WriteLine();
                break;

            case 2:
                Console.WriteLine();
                break;

            case 3:
                Console.WriteLine();
                break;

            case 4:
                Console.WriteLine();
                break;
        }
    }
}