public class WeerberichtContent
{
    public decimal temperature_2m { get; set; }
    public decimal apparent_temperature {  get; set; }
    public decimal relativehumidity_2m { get; set; }
    public decimal rain {  get; set; }

}

public class Weerbericht
{ 
    public WeerberichtContent current {  get; set; }
}

