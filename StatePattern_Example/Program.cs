/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 25.05.2020
*/

using System;

namespace StatePattern_Example
{
    class Program
    {
        //at the main program we need to initialize the context class with initial state.
        //and we can make state changings with method which belongs to context class.
        static void Main(string[] args)
        {
            Console.Title = "State Design Pattern Example - Thecodeprogram";

            Aircraft aircraft = new Aircraft(new GroundState());
            aircraft.switchAirGNDState();
            aircraft.switchAirGNDState();
            aircraft.switchAirGNDState();
            aircraft.switchAirGNDState();
            aircraft.switchAirGNDState();

            Console.ReadLine();
        }
    }
}
