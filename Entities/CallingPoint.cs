using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;

public class CallingPoint
{

    [XmlElement("locationName")]
    public string LocationName { get; set; } = "";

    [XmlElement("crs")]
    public string Crs { get; set; } = "";

    [XmlElement("st")]
    public string St { get; set; } = "";

    [XmlElement("et")]
    public string Et { get; set; } = "";

    [XmlElement("length")]
    public int Length { get; set; }

    [XmlElement("formation")]
    public Formation? Formation { get; set; }
}