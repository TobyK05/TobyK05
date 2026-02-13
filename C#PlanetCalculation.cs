//Lab 3 Toby Koladich Comp 1030


using System;

class Program
{
    static void Main(string[] args)
    {



// Step one, declared variables for the radius of each planet in our solar system (in kilometres)

double mercuryRadius = 2439.7;  

double venusRadius = 6051.8;

double earthRadius = 6371.0; 

double marsRadius = 3389.5;

double jupiterRadius = 69911.0;

double saturnRadius = 58232.0;

double uranusRadius = 25362.0;

double neptuneRadius = 24622.0;

// Step two, declared varibales for the suraface area of each plant in our solar system

double mercurySurfaceArea;


double venusSurfaceArea;


double earthSurfaceArea;


double marsSurfaceArea;


double jupiterSurfaceArea;


double saturnSurfaceArea;


double uranusSurfaceArea;


double neptuneSurfaceArea;


// Step three, calculate the surface area of each planet using the formula A=4πr2, where π = Math.PI.

mercuryRadius = 4 * Math.PI * mercuryRadius * mercuryRadius ;

venusRadius = 4 * Math.PI * venusRadius * venusRadius ;

earthRadius = 4 * Math.PI * earthRadius * earthRadius ;

marsRadius = 4 * Math.PI * marsRadius * marsRadius ;

jupiterRadius = 4 * Math.PI * jupiterRadius * jupiterRadius ; 

saturnRadius = 4 * Math.PI * saturnRadius * saturnRadius ; 

uranusRadius = 4 * Math.PI * uranusRadius * uranusRadius ; 

neptuneRadius = 4 * Math.PI * neptuneRadius * neptuneRadius ;

//Step 4, add console writeline statements to output the surface area of each planet in our solar system.

Console.WriteLine("The surface are of Mercury is " + mercuryRadius + " square kilometres.\n");

Console.WriteLine("The surface are of Venus is " + venusRadius + " square kilometres.\n");

Console.WriteLine("The surface are of Earth is " + earthRadius + " square kilometres.\n");

Console.WriteLine("The surface are of Mars is " + marsRadius + " square kilometres.\n");

Console.WriteLine("The surface are of Jupiter is " + jupiterRadius + " square kilometres.\n");

Console.WriteLine("The surface are of Saturn is " + saturnRadius + " square kilometres.\n");

Console.WriteLine("The surface are of Uranus is " + uranusRadius + " square kilometres.\n");

Console.WriteLine("The surface are of Neptune is " + neptuneRadius + " square kilometres.\n");

    }
}
