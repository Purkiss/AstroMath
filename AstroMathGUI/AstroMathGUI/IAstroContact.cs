using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

// 1.	Create the ServiceContract called “IAstroContract.cs” which will need to be identical to the server without a reference to the AstroMath.DLL.
namespace AstroMathGUI
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
