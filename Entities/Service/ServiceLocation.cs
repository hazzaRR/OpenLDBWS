using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;
public class ServiceLocation 
{

    [XmlElement(ElementName = "locationName")]
    public string LocationName {get; set;} = "";

    [XmlElement(ElementName = "crs")]
    public string Crs {get; set;} = "";

    [XmlElement(ElementName = "via")]
    public string? Via {get; set;}

    [XmlElement(ElementName = "futureChangeTo")]
    public string? FutureChangeTo {get; set;}

    [XmlElement(ElementName = "assocIsCancelled")]
    public bool AssocIsCancelled {get; set;}

}
