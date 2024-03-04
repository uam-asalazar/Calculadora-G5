using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Calculadora_G5.Calculadora_G5;

namespace BLL_Calculadora_G5.Calculadora_G5
{
    public class cls_CalculadoraG5_BLL
    {
        public float sumar(ref cls_CalculadoraG5_DAL obj_DAL)
        {
            obj_DAL.fResultado = obj_DAL.fNum1 + obj_DAL.fNum2;
            return obj_DAL.fResultado;
        }

        public float restar(ref cls_CalculadoraG5_DAL obj_DAL)
        {
            obj_DAL.fResultado = obj_DAL.fNum1 - obj_DAL.fNum2;
            return obj_DAL.fResultado;
        }

        public float multiplicar(ref cls_CalculadoraG5_DAL obj_DAL)
        {
            obj_DAL.fResultado = obj_DAL.fNum1 * obj_DAL.fNum2;
            return obj_DAL.fResultado;
        }

        public float dividir(ref cls_CalculadoraG5_DAL obj_DAL)
        {
            obj_DAL.fResultado = obj_DAL.fNum1 / obj_DAL.fNum2;
            return obj_DAL.fResultado;
        }
    }



}
