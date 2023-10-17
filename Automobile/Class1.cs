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

        public Automobile (int Velocità, bool Acceso, int Marcia)
        {
            _velocità = Velocità;
            _acceso = false;
            _marcia = Marcia;
        }

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
                Velocità += 10;
            }
        }

        public void Deccellerare(int Velocità)
        {
            if (_acceso = true && _marcia > 0)
            {
                Velocità -= 10;
            }
        }



    } 
}
