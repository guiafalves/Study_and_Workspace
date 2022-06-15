namespace Construtores.Models
{
    public class log{

    
    public static log _log;
    
    private log()
    {

    } 
    public static log GetInstance()
    {
        if (_log == null)
        {
            _log = new long ();
        }
        return _log;
    }
    }
    
}