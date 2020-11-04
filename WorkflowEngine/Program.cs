using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{

   class Program
   {
      static void Main(string[] args)
      {
         var wFlow = new Workflow();

         wFlow.Add(new VideoEditor());
         wFlow.Add(new FileExtractor());
         wFlow.Add(new PdfConverter());
         wFlow.Add(new FileArchiver());

         var engine = new WorkflowEngine();
         engine.Run(wFlow);

      }
   }
}
