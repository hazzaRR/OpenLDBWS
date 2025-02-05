namespace TrainDepartureBoard.Entities;
public class Service 
{
    public TimeSpan Std {get; set;}
    public string Etd {get; set;} = "";
    public string Platform {get; set;} = "";
    public string Operator {get; set;} = "";
    public string OperatorCode {get; set;} = "";
    public string ServiceType {get; set;} = "";
    public int length {get; set;} = 0;
    public string ServiceId {get; set;} = "";
    public required Station Origin {get; set;}
    public required Station Destination {get; set;}
    public required Formation Formation {get; set;}
    public required SubsequentCallingPoints SubsequentCallingPoints {get; set;}

}
