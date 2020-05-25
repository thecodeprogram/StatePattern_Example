/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 25.05.2020
*/

using System;

namespace StatePattern_Example
{
    //This class is our context class. 
    //States are belong to this context class and 
    //we are going to manage those state class from here.
    class Aircraft
    {
        //We have to store the current state in the context class
        public AirGroundState airGndState;

        //Also we need to start the context with initial state.
        //I use contructor class to specify the initial state
        public Aircraft(AirGroundState _initialState)
        {
            this.airGndState = _initialState;
        }

        //Then we are going to change the current state with switch method.
        public void switchAirGNDState()
        {
            airGndState.ChangeState(this);
            Console.WriteLine("---------------------------------------");
        }
    }
}
