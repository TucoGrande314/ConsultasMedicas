using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for NoFoundPacienteException
/// </summary>
public class InsertPacientException : Exception
{
    public InsertPacientException(string err) :base(err)
    {
        
    }
}