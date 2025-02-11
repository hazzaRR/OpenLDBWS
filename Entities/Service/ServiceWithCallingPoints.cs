using System.Xml.Serialization;

namespace TrainDepartureBoard.Entities;


public class ServiceWithCallingPoints : BaseService
{

    [XmlElement("subsequentCallingPoints")]
    public SubsequentCallingPoints? SubsequentCallingPoints {get; set;}

    [XmlElement("previousCallingPoints")]
    public PreviousCallingPoints? PreviousCallingPoints {get; set;}

}