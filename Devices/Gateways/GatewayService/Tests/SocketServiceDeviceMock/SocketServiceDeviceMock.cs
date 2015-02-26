﻿using Gateway.DataIntake;
using CoreTest.Devices;
using SocketDeviceMock.Utils.Logger;

namespace SocketServiceDeviceMock
{
    class SocketServiceDeviceMock
    {
        static void Main(string[] args)
        {
            ConsoleLogger logger = new ConsoleLogger();
            SocketServiceTestDevice device = new SocketServiceTestDevice(logger);
            SensorEndpoint endpoint = new SensorEndpoint
            {
                Host = "127.0.0.1",
                Port = 5000
            };
            device.RunSocketServer(endpoint);
        }
    }
}