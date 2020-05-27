using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    class Datos
    {
        public string datos;

        public Datos()
        {
            datos = "";
        }

        public void StringPDF(string dirReg, string circuito, string centroEduc,string email, string docente,string asignatura,
                                string periodoLectivo,string nivel,string seccion,string prueba,DateTime fecha,int valorPorcentual,
                                int ptPreliminar,int totalLecciones,int constUtilizar,string rutaImg)
        {
            
            datos = (@"
            <header style='background-color:rgb(129,204,204)'>
                <table>
                    <tr>

                    <td> <img src='https://www.mep.go.cr/sites/default/files/imagecache/blog_teaser_grande/blog/portada/captura_1.jpg' width='100' height='50'> </td>" +

                    @"<td>
                       <div>
                       <p>") +
                            "Fecha : " + fecha + "<br>" +
                            dirReg + "<br>" +
                            circuito + "<br>" +
                            "Centro Educativo: " + centroEduc + "<br>" +
                            "E-mail: " + email + "<br>" +
                            "Docente: " + docente + "<br>" +
                            "Asignatura: " + asignatura + "<br>" +
                            "Periodo Lectivo: " + periodoLectivo + "<br>" +
                            "Nivel: " + nivel + "<br>" +
                            "Sección : " + seccion + "<br>" +
                            "Prueba : " + prueba + "<br>" +(@"
                    </p>
                       </div>
                    </td>
                    
                     <td> <img src='file:///" + rutaImg + "' width='100' height='50' align=top> </td>" +

                      @"</tr>
                
                </table>
                    
                </header>

                <body>
                    <h2> Items </h2>
                    <table border=1 style>
                        <tr>
                           <td>Valor Porcentual:</td> <td>"+ valorPorcentual + @"  </td>
                        </tr>
  
                        <tr>
                            <td>Puntuación Preliminar:</td><td>"+ ptPreliminar + @"</td>
                        </tr>
 
                        <tr>
                            <td>Total de lecciones:</td><td>"+ totalLecciones + @"</td>
                        </tr>

                        <tr>
                            <td>Constante a Utilizar:</td><td>"+ constUtilizar + @" </td>
                        </tr>
                    </table>
                <br><br><br>

                <h2> Tabla de Especificaciones "+prueba+" prueba del periodo "+periodoLectivo+", "+asignatura+" "+fecha.Year+@"</h2>
                 <table border=1 cellspacing=0 style='border: 2px solid black'>
                
                <tr>
                    <th>
                        Aprendizajes esperados
                    </th>
                    <th>
                        Estrategias de Mediación
                    </th>
                    <th>
                        Indicadores
                    </th>
  
                    <th>
                        Número de lecciones
                    </th>
                    <th>
                        Puntos
                    </th>
  
                    <th>
                        SU
                    </th>
                    <th>
                        RC
                    </th>
  
                    <th>
                        ID
                    </th>
                    <th>
                        C
                    </th>
  
                    <th>
                        RE
                    </th>
                    <th>
                        Total Asignado
                    </th>
                </tr>
");

            
        }
        
    
        public void DataGridPDF(string aprendizajesEsperados,string estrategiasMediación,string indicadores,string numLecciones,
            string puntos,string SU,string RC,string ID,string C,string RE,string totalAsignado)
        {
            datos += @"
                <tr>
                    <td>"
                        + aprendizajesEsperados + @"  
                    </td>
                    <td>"
                        + estrategiasMediación + @"
                    </td>
                    <td>"
                        + indicadores + @"
                    </td>
                    <td>"
                        + numLecciones + @"
                    </td>
                    <td>"
                        + puntos + @"
                    </td>
                    <td>"
                        + SU + @"
                    </td>
                    <td>"
                        + RC + @"
                    </td>
                    <td>"
                        + ID + @"
                    </td>
                    <td>"
                        + C + @"
                    </td>
                    <td>"
                        + RE + @"
                    </td>
                    <td>"
                        + totalAsignado + @"
                    </td>
                </tr>
            ";
        }   

        public void FinalizarCodHTML()
        {
            datos += @"</table><h2><b>Simbología:</b></h2>
                <ul>
                <li><strong> SU :</strong> Selección Única </li>
                <li><strong> RC :</strong> Respuesta Corta </li>
                <li><strong> ID :</strong> Identificación </li>
                <li><strong> C  :</strong> Correspondencia o apareamiento</li>
                <li><strong> RE :</strong> Resolución de ejercicios</li>
                <li><strong> RR :</strong> Respuesta restringida </li>                            
                <li><strong> RP :</strong> Resolución de problemas</li>
                <li><strong> E  :</strong> Ensayo </li>
                <li><strong> RSC :</strong> Resolución de Casos</li></ul></body>";
        }
    
    }
}
