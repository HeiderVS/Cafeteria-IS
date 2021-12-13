using System;

namespace Controladores
{
    public class AdminReportesControlador
    {
        public void GetReportes(DateTime startDate, DateTime endDate)
        {
            System.Diagnostics.Debug.WriteLine("Aqui se hara una consulta a Modelos, para traer la info de BD para " + 
                          startDate.Date + " " + endDate.Date);
        }
    }
}