using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for FoundUsuarioException
/// </summary>
public class UsuarioNotFoundException : Exception
{
    public UsuarioNotFoundException(string err) : base(err)
    {
        //
        // TODO: Add constructor logic here
        //
    }
}