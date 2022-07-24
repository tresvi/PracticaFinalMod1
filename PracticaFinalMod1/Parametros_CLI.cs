using CommandParser.Attributes.Formatter;
using CommandParser.Attributes.Validation;
using CommandParser.Attributtes.Keywords;
using System;

namespace PracticaFinalMod1
{
    internal class Parametros_CLI
    {
        [FileExists]
        [Option("inputfilepath", 'i', true, helpText: "Ruta completa del archivo de entrada")]
        public string InputFilePath { get; set; }

       // [FileNotExists]
        [Option("outputfilepath", 'o', true, helpText: "Ruta completa del archivo de salida. El mismo no debe existir")]
        public string OutputFilePath { get; set; }

    }
}
