using System;

namespace Clinica.Ultils;

public class Appointment
{
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Text { get; set; }
    
    public string Titulo { get; set; }
    
    public string Cliente { get; set; }
    
}