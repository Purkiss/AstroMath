using System.ServiceModel;
using AstroMath;


// 1.	Create the ServiceContract file called “IAstroContract.cs” which will require an Interface that references the AstroMath.DLL and four OperationContract (one for each calculation). 
namespace AstroServer
{
    [ServiceContract]
    internal interface IAstroContact
    {
        [OperationContract]
        double StarVelocity(double x, double y);

        [OperationContract]
        double TempKelvin(double x);

        [OperationContract]
        double StarDistance(double x);

        [OperationContract]
        double EventHorizon(double x);
    }
}
