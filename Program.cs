using System;
using Calculators;
using CommercialRegistration;
using ConsumerVehicleRegistration;


var tollCalc = new TollCalculator();
var car = new Car();
var taxi = new Taxi();
var bus = new Bus();
var truck = new DeliveryTruck();
Console.WriteLine($"The toll for a car is {tollCalc.CalculateToll(car)}");
Console.WriteLine($"The toll for a taxi is {tollCalc.CalculateToll(taxi)}");
Console.WriteLine($"The toll for a bus is {tollCalc.CalculateToll(bus)}");
Console.WriteLine($"The toll for a truck is {tollCalc.CalculateToll(truck)}");

try
{
    tollCalc.CalculateToll("Wrong");
}catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}

try
{
    tollCalc.CalculateToll(null!);
}
catch (ArgumentNullException e)
{
    Console.WriteLine($"Caught an argument exception when using null{e}");
}