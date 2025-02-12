using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;


[XmlRoot(ElementName = "GetArrivalBoardResponse", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/")]
public class GetArrivalBoardResponse
{
    
    [XmlElement(ElementName = "GetStationBoardResult")]
    public required StationBoard StationBoardWithDetails { get; set; }
}