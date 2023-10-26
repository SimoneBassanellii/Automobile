using System;
using System.Collections.Generic;
using System.Data;
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

        public Automobile(int velocità, int marcia, bool acceso) 
        {
            _velocità = velocità;
            _acceso = acceso;
            _marcia = marcia;
        }


        //costruttore di copia 
        public Automobile(Automobile previusAutomobile) 
        {
            _velocità = previusAutomobile._velocità;
            _acceso = previusAutomobile._acceso;
            _marcia = previusAutomobile._marcia;
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

        public string Accellerare()
        {
            if (_acceso && 35 * _marcia > _velocità)
            {
                _velocità += 5;
                return "";

            }
            else
            {
                return "";
            }
        }

        public void Deccellerare(int Velocità)
        {
            if (_acceso && _marcia > 0)
            {
                Velocità -= 5;
            }
        }

        public void Aumentomarcia(int Velocit, int marcia)
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
