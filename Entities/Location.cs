using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;
public class Location 
{

    [XmlElement(ElementName = "locationName", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]
    public string LocationName {get; set;} = "";

    [XmlElement(ElementName = "crs", Namespace = "http://thalesgroup.com/RTTI/2015-11-27/ldb/types")]

    public string Crs {get; set;} = "";

}
