/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 25.05.2020
*/

using System;

namespace StatePattern_Example
{
    //this concrete state class was derived from State interface.
    //This state classes will operate the state changings.
    //Here we can make the required tasks before and after state changings.

    //This class will change the state to the air state.
    class GroundState : AirGroundState
    {
        public void ChangeState(Aircraft _aircraft)
        {
            _aircraft.airGndState = new AirState();
            Console.WriteLine("Air/Ground Mode switched to Air Mode...");
        }
    }
}
