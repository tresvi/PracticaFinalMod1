using CommandParser;
using FixedWidthTextUtils;
using System;
using System.Collections.Generic;

//Sugerencia. Agregar mas codigos de Retorno para poder dar salidas mas detalladas a CtrlM
namespace PracticaFinalMod1
{
    internal class Program
    {
        const int RET_CODE_OK = 0;
        const int RET_CODE_ERROR = 2;        //No uso 1 por estar reservado para CtrlM

        static int Main(string[] args)
        {
            try
            {
                Parametros_CLI parametros = CommandLine.Parse<Parametros_CLI>(args);
                FileParser fileParser = new FileParser(parametros.InputFilePath);

                List<Transferencia> transferencias = fileParser.Parse<Transferencia>(true);
                AFIPEntities dbContext = new AFIPEntities();
                transferencias.ForEach(x => x.CodigoActividadAFIP = dbContext.CodigoActividad.Find(x.ClaveTributaria).Codigo);
                
                fileParser.ToFlatFile(transferencias, parametros.OutputFilePath);
                Console.WriteLine("**Proceso concluido satisfactoriamente**");
                return RET_CODE_OK;         //Environment.Exit(RET_CODE_OK);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
                return RET_CODE_ERROR;      //Environment.Exit(RET_CODE_ERROR);
            }
        }

    }
}
