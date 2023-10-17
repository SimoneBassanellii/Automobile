using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    public class Automobile 
    {
        protected int _velocità;
        protected bool _acceso;
        protected int _marcia;

        public void AccendiMotore()
        {
            _acceso = true;
        }

        public void SpegniMotore()
        {
            if (_velocità <= 0) 
            {
                _acceso= false; 
            }
            else
            {
                _acceso = true;
            }
        }

        public void Accellerare(int Velocità)
        {
            if (_acceso = true && _marcia < 5)
            {
                Velocità += 5;
            }
        }

        public void Deccellerare(int Velocità)
        {
            if (_acceso = true && _marcia > 0)
            {
                Velocità -= 5;
            }
        }

        public void Aumentomarcia(int Velocit)
        {
            if (_acceso && _marcia < 5)
            {
                _marcia++;
            }
        }

        public void diminuiscimarcia(int Velocit)
        {
            if (_acceso && _marcia > 0)
            {
                _marcia--;
            }
        }

    } 
}
