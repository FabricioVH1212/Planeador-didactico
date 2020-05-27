using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronPdf;

namespace Proyecto
{
	class ExportarPDF
	{
		public bool guardar(string datos,string ruta)
		{
			try
			{
				HtmlToPdf convert = new HtmlToPdf();
				convert.RenderHtmlAsPdf(datos).SaveAs(ruta+".pdf"); ;
				return true;
			}
			catch (Exception)
			{
				return false;
			}

		}
	}

}

