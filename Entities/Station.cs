using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;
public class Station 
{

    [XmlElement(ElementName = "location", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public required Location Location {get; set;}

}
