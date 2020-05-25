/*
This File Created
By: Burak Hamdi TUFAN
On: https://thecodeprogram.com/
At: 25.05.2020
*/

namespace StatePattern_Example
{
    //This interface will derive the concrete state classes
    //All concrete states will have a change function
    //you can add here what function do you need in your project
    //like save it to a global variable or remote server.
    interface AirGroundState
    {
        void ChangeState(Aircraft _aircraft);
    }
}
