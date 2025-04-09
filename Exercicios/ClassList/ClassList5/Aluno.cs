using System;
using System.Globalization;

namespace ClassList5{
    class Aluno{
        
        public string Nome;
        public double PirmeiroTrimestre;
        public double SegundoTrimestre;
        public double TerceiroTrimestre;

        public double NotaFinal(){
            return PirmeiroTrimestre + SegundoTrimestre + TerceiroTrimestre;
        }

        public bool Aprovado(){
            if(NotaFinal() >= 60){
                return true;
            }
            else{
                return false;
            }
        }

        public double NotaRestante(){
            if(Aprovado()){
                return  0.0;
            }
            else{
                return 60 - NotaFinal();
            }
        }
    }
}
