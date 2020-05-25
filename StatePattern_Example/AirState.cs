/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 25.05.2020
*/

using System;

namespace StatePattern_Example
{
    //This class will change the state to the Ground state.
    class AirState : AirGroundState
    {
        public void ChangeState(Aircraft _aircraft)
        {
            _aircraft.airGndState = new GroundState();
            Console.WriteLine("Air/Ground Mode switched to GND Mode...");
        }
    }
}
