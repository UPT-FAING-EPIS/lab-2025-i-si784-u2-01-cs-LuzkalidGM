using System;

namespace Math.Lib
{
    /// <summary>
    /// Proporciona funciones matemáticas personalizadas, como el cálculo de raíces cuadradas.
    /// </summary>
    public class Rooter
    {
        /// <summary>
        /// Calcula la raíz cuadrada de un número positivo usando el método de Newton-Raphson.
        /// </summary>
        /// <param name="input">El número del cual se desea obtener la raíz cuadrada. Debe ser positivo.</param>
        /// <returns>La raíz cuadrada aproximada del valor de entrada.</returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Se lanza cuando el valor de entrada es menor o igual a cero.
        /// </exception>
        public double SquareRoot(double input)
        {
            if (input <= 0.0)
                throw new ArgumentOutOfRangeException(nameof(input), "El valor ingresado es invalido, solo se puede ingresar números positivos");

            double result = input;
            double previousResult = -input;
            while (System.Math.Abs(previousResult - result) > result / 1000)
            {
                previousResult = result;
                result = result - (result * result - input) / (2 * result);
            }
            return result;
        }
    }
}
