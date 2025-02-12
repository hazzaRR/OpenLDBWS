using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;

[XmlRoot(ElementName = "GetArrDepBoardWithDetailsResponse", Namespace = "http://thalesgroup.com/RTTI/2021-11-01/ldb/")]
public class GetArrDepBoardWithDetailsResponse
{
    [XmlElement(ElementName = "GetStationBoardResult")]
    public required StationBoardWithDetails StationBoardWithDetails { get; set; }
}