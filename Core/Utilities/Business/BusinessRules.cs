using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics) //Params verdiğimizde run  içine istediğimiz kadar IResult atabiliriz.
        {
            foreach (var logic in logics) //bütün kuralları gez
            {
                if (!logic.Success)//kurala uymayan varsa
                {
                    return logic;//o kuralı döndür
                }
            }

            return null;
        }
    }
}
