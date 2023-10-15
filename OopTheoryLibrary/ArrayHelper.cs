using System;
namespace OopTheoryLibrary
{
	public class ArrayHelper
	{
		

        public static int MinRecursiv(int[] arr, int index)
        {

            //verificam daca vectorul este null sau empty si ridicam exceptie
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Exceptie null sau empty");

            // daca indexul e 0 returnam gol
            if (index == 0)
                return arr[0];

            int currentMin = MinRecursiv(arr, index - 1);
            if (arr[index] < currentMin)
                return arr[index];
            else
                return currentMin;
        }

        public static int MaxRecursiv(int[] arr, int index)
        {

            //verificam daca vectorul este null sau empty si ridicam exceptie
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Exceptie null sau empty");

            // daca indexul e 0 returnam gol
            if (index == 0)
                return arr[0];

            int currentMax = MaxRecursiv(arr, index - 1);
            if (arr[index] > currentMax)
                return arr[index];
            else
                return currentMax;
        }
    }
    
}

