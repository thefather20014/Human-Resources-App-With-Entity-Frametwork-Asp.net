
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Human_Resources
{

using System;
    using System.Collections.Generic;
    
public partial class Holidays
{

    public int Id { get; set; }

    public int Employee { get; set; }

    public System.DateTime Desde { get; set; }

    public System.DateTime Hasta { get; set; }

    public string Correspondiente { get; set; }

    public string Comentarios { get; set; }



    public virtual Employee Employee1 { get; set; }

}

}
