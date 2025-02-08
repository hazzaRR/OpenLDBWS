using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;

public class BaseDeparturesBoard
{
    [XmlElement("generatedAt")]
    public string GeneratedAt { get; set; } = "";

    [XmlElement("locationName")]
    public string LocationName { get; set; } = "";

    [XmlElement("crs")]
    public string Crs { get; set; } = "";

    [XmlElement("filterLocationName")]
    public string FilterLocationName { get; set; } = "";

    [XmlElement("filtercrs")]
    public string FilterCrs { get; set; } = "";

    [XmlElement("filterType")]
    public string FilterType { get; set; } = "";

    [XmlArray("nrccMessages")]
    [XmlArrayItem("message")]
    public List<string> NrccMessages { get; set; } = [];

    [XmlElement("platformAvailable")]
    public bool? PlatformAvailable { get; set; }

    [XmlElement("areServicesAvailable")]
    public bool? AreServicesAvailable { get; set; }
}