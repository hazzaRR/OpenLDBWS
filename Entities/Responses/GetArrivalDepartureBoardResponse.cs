using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;


[XmlRoot(ElementName = "GetArrivalDepartureBoardResponse", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/")]
public class GetArrivalDepartureBoardResponse
{
    [XmlElement(ElementName = "GetStationBoardResult")]
    public required StationBoard StationBoardWithDetails { get; set; }
}