using System;
using AstroMath;
using System.ServiceModel;

/*
 * Zac Purkiss (P444025)
 * AT2 Astro Server
 * references DLL so that client can connect and returns calculations
 */


// 2.	Create the server file called “AstroServer.cs” which implements the IAstroContract. Add a new instance of the class library method and then create four methods with the suitable input parameters and return types.
namespace AstroServer
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    internal class AstroServer : IAstroContact
    {
        public double StarVelocity(double x, double y)
        {
            return DoAstroMath.StarVelocity(x, y);
        }

        public double TempKelvin(double x)
        {
            return DoAstroMath.TempKelvin(x);
        }

        public double StarDistance(double x)
        {
            return DoAstroMath.StarDistance(x);
        }

        public double EventHorizon(double x)
        {
            return DoAstroMath.EventHorizon(x);
        }
    }
}
